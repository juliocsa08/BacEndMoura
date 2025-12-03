using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace CrudMoura.Controllers
{

    public class Teste : Controller
    {
        private readonly ILogger<Teste> _logger;

        public Teste(ILogger<Teste> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
            ViewData["Title"] = "Página Inicial";
            return View();
        }

        public IActionResult Listar()
        {
            ViewData["Title"] = "Listar Itens";
            return View();
        }

        public IActionResult Cadastrar()
        {
            ViewData["Title"] = "Cadastrar Item";
            return View();
        }

        public IActionResult Editar()
        {
            ViewData["Title"] = "Editar Item";
            return View();
        }
        public IActionResult Excluir()
        {
            ViewData["Title"] = "Excluir Item";
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View("Error!");
        }
    }
}