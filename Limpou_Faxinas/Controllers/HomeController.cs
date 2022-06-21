﻿using Limpou_Faxinas.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace Limpou_Faxinas.Controllers
{
    public class HomeController : Controller
    {
        
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Duvidas()
        {
            return View();
        }

        public IActionResult Pagamento ()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}