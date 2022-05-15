using Limpou.Faxinas.Controllers.RequestModels;
using Limpou.Faxinas.Controllers.RequestModels.Usuario;
using Limpou.Faxinas.Servicos.Usuario;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System.Threading.Tasks;

namespace Limpou.Faxinas.Controllers
{
    public class LoginController : Controller
    {
        private readonly ILogger<LoginController> _logger;
        private readonly IUsuarioServico _usuarioServico;

        public LoginController(ILogger<LoginController> logger, IUsuarioServico usuarioServico)
        {
            _logger = logger;
            _usuarioServico = usuarioServico;
        }

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Cadastro()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> Cadastrar([FromBody] CadastrarUsuarioRequestModel requisicao)
        {
            var validacao = requisicao.Validar();
            if (!validacao.Valido)
            {
                return BadRequest(new HttpResponseModel
                {
                    StatusCode = System.Net.HttpStatusCode.BadRequest,
                    Mensagem = validacao.MensagemDeErro
                });
            }

            var usuario = requisicao.CriarEntidade();
            var resultado = await _usuarioServico.CadastrarUsuario(usuario);

            if (!resultado.Sucesso)
            {
                return Conflict(new HttpResponseModel
                {
                    StatusCode = System.Net.HttpStatusCode.Conflict,
                    Mensagem = resultado.Mensagem,
                    Corpo = null
                });
            }

            return Created("/Usuarios", new HttpResponseModel
            {
                StatusCode = System.Net.HttpStatusCode.Created,
                Mensagem = resultado.Mensagem,
                Corpo = new { CodigoUsuarioCadastrado = resultado.CodigoUsuarioCadastrado }
            });
        }

        [HttpPost]
        public async Task<IActionResult> Autenticar([FromBody] AutenticarUsuarioRequestModel requisicao)
        {
            var validacao = requisicao.Validar();
            if (!validacao.Valido)
            {
                return BadRequest(new HttpResponseModel
                {
                    StatusCode = System.Net.HttpStatusCode.BadRequest,
                    Mensagem = validacao.MensagemDeErro
                });
            }

            var resultadoAutenticacao = await _usuarioServico.AutenticarUsuario(requisicao.EmailUsuario, requisicao.SenhaUsuario, requisicao.PerfilUsuario);

            if (!resultadoAutenticacao.Sucesso)
            {
                return Unauthorized(new HttpResponseModel
                {
                    StatusCode = System.Net.HttpStatusCode.Unauthorized,
                    Mensagem = resultadoAutenticacao.Mensagem,
                    Corpo = null
                });
            }

            return Ok(new HttpResponseModel
            {
                StatusCode = System.Net.HttpStatusCode.OK,
                Mensagem = resultadoAutenticacao.Mensagem,
                Corpo = resultadoAutenticacao.UsuarioLogado
            });
        }
    }
}
