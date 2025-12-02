
using CadastroAlunoTorloni.Models;
using Microsoft.AspNetCore.Mvc;

namespace CadastroAlunoTorloni.Controllers
{
    public class FrutasController : Controller
    {
        private readonly ILogger<FrutasController> _logger;

        public FrutasController(ILogger<FrutasController> logger)
        {
            _logger = logger;
        }




        // Criar uma lista de Frutas
        private List<Fruta> frutas = new List<Fruta>
        {
            new Fruta { Id = 1, Nome = "Maça", Cor = "Vermelha", Categoria = "Tropícal"},
            new Fruta { Id = 2, Nome = "Banana", Cor = "Amarela", Categoria = "Tropícal"},
            new Fruta { Id = 3, Nome = "Uva", Cor = "Roxa", Categoria = "Tropícal"},
            new Fruta { Id = 4, Nome = "Limão", Cor = "Verde", Categoria = "cítrico"},
            new Fruta { Id = 5, Nome = "Abacaxi", Cor = "Amarelo", Categoria = "Cítrico"},
        };


        public IActionResult Index()
        {
            return View(frutas);
        }
        public IActionResult Create()
        {
            return View();
        }


        public IActionResult Create(Fruta fruta)
        {
            //cria o proximo id
            fruta.Id = frutas.Max( f => f.Id) + 1;
            //Salvar no array
            frutas.Add(fruta);
            //redirecionar o usuario para o index
            return RedirectToAction("Index");
        }









        public IActionResult FrutasCítricas()
        {
            return View();
        }
        public IActionResult FrutasTropícais()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View("Error!");
        }
    }
}