using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using CrudMoura.Models;

namespace CrudMoura.Controllers;

public class HomeController : Controller
{
    private readonly ILogger<HomeController> _logger;

    public HomeController(ILogger<HomeController> logger)
    {
        _logger = logger;
    }
//ação padrão inicial
    public IActionResult Index()
    {
        return View();
    }

public IActionResult MinhaAcao()
    {
        return View(); // Retorna a pagina MinhaAcao.cshtml
    }

    public IActionResult ListaNomes()
    {
        String [] nomes = { "julio lindo", "Madudazy", "oFidalgo", "Anne ", "Torolho TT" };
        ViewBag.Teste = "Olá, eu vim através da ViewBag";
        ViewBag.Nomes = nomes;
        return View();
    }

    public IActionResult Privacy()
    {
        return View();
    }

    [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
    public IActionResult Error()
    {
        return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
    }

    


}
