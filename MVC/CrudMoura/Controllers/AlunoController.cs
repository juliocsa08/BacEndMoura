using CrudMoura.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace CrudMoura.Controllers
{
    public class AlunoController : Controller
    {

        public static List<Aluno> ListaDeAluno = new List<Aluno>
            {
                new Aluno {Id = 1, Nome = "Rafaela", Idade = 17, Sala = "2A", Cidade = "SP"},
                new Aluno {Id = 2, Nome = "Anne", Idade = 17, Sala = "2A", Cidade = "SP"},
                new Aluno {Id = 3, Nome = "Bia", Idade = 16, Sala = "2A", Cidade = "SP"},
                new Aluno {Id = 4, Nome = "Maria", Idade = 17, Sala = "2A", Cidade = "SP"},
            };
        private readonly ILogger<AlunoController> _logger;
        private readonly CrudMouraContext _context;

        public AlunoController(ILogger<AlunoController> logger, CrudMouraContext context)
        {
            _logger = logger;
            _context = context;
        }
        

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult ListarAluno()
        {
            ViewBag.Aluno = ListaDeAluno;
            return View();
        }

        [HttpGet]
        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public IActionResult SalvarAluno(Aluno AlunoCadastrado)
        {
            AlunoCadastrado.Id = ListaDeAluno.Max(f => f.Id) + 1;
            ListaDeAluno.Add(AlunoCadastrado);
            return RedirectToAction(nameof(ListarAluno));
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View("Error!");
        }
    }
}
