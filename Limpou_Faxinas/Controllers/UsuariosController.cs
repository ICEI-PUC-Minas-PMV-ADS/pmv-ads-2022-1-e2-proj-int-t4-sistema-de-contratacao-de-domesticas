using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Security.Claims;
using System.Threading.Tasks;
using System.Linq;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;

namespace Limpou_Faxinas.Controllers
{
    public class UsuariosController : Controller
    {
        private readonly ApplicationDbContext _context;

        public UsuariosController(ApplicationDbContext context)
        {
            _context = context;
        }

        [HttpPost]
        public async Task<IActionResult> Login([Bind("Id, Senha")]UsuariosController usuario)
        {
            var user = await _context.Usuarios
                .FirstOrDefaultAsync(m => m.Id == usuario.Id);


            if (user == null)
            {
                ViewBag.Message = "Usuário e/ou senha inválidos";
                return View();
            }

            bool senhaCorreta = BCrypt.Net.BCrypt.Verify(usuario.Senha, user.Senha);

            if (senhaCorreta)
            {
                var claims = new List<Claim>
                {
                    new Claim(ClaimTypes.Name, user.Nome),
                    new Claim(ClaimTypes.NameIdentifier, user.Nome),
                    new Claim(ClaimTypes.Role, user.Perfil.ToString())
                };

                var userIdentity = new ClaimsIdentity(claims, "login");

                ClaimsPrincipal principal = new ClaimsPrincipal(userIdentity);

                var propriedades = new AuthenticationProperties
                {
                    AllowRefresh = true,
                    ExpiresUtc = DateTime.Now.ToLocalTime().AddDays(7),
                    IsPersistent = true
                };

                await HttpContext.SignInAsync(principal, propriedades);

                return Redirect("/");
            }
                ViewBag.Message = "Usuário e/ou Senha inválidos!";
                return View();
        }

        public IActionResult AccessDenied()
        {
            return View();
        }
    }
}
