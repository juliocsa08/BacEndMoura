
using Microsoft.AspNetCore.Mvc;
using CrudMoura.Models;

namespace CrudMoura.Controllers
{
    public class FrutasController : Controller
    {
        private readonly ILogger<FrutasController> _logger;

        public static List<Frutas> listaDeFrutas = new List<Frutas>
       {

         new Frutas  { Id = 1, Nome ="Morango", Preco = 5.99f, Quantidade = 10 , Categoria = "Tropical"},
         new Frutas  { Id = 2, Nome ="Abacate", Preco = 5.90f, Quantidade = 12 , Categoria = "Tropical"},
         new Frutas  { Id = 3, Nome ="Limão", Preco = 2.95f, Quantidade = 100 , Categoria = "Cítrica"},

       };

        public FrutasController(ILogger<FrutasController> logger)
        {
            _logger = logger;
        }


        public IActionResult Index()
        {
            return View();
        }



        public IActionResult ListarFrutas()
        {
            ViewBag.sacolinha = listaDeFrutas;
            return View();
        }


            public IActionResult Create()
        {
            return View();
        }
    


 [HttpPost]
        public IActionResult SalvarFruta(Frutas frutaCadastrada)
        {
           
            frutaCadastrada.Id = listaDeFrutas.Max(f => f.Id) + 1;
             listaDeFrutas.Add(frutaCadastrada);
            return RedirectToAction( nameof (ListarFrutas));


        }
    }
}