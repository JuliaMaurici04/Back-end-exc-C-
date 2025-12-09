using System.Threading.Tasks;
using DevConnectTorloni.Contexts;
using DevConnectTorloni.Models;
using Microsoft.AspNetCore.Mvc;

namespace DevConnectTorloni.Controllers
{
    public class UsuarioController : Controller
    {
        private readonly DevConnectContext _context;
        private readonly ILogger<UsuarioController> _logger;

        public UsuarioController(ILogger<UsuarioController> logger, DevConnectContext context)
        {
            _logger = logger;
            _context = context;
        }

        //listar
        [HttpGet]
        public IActionResult Index()
        {
            ViewBag.usuarioNovoCadastro = "";
            TempData["usuarioNovoCadastro"] = "";
            return View();
        }

        //Cadastrar
        [HttpPost]
        public async Task<IActionResult> Index(IFormCollection form)
        {
            // System.Console.WriteLine($"{form["NomeCompleto"]}");
            // System.Console.WriteLine($"{form.Files[0].FileName}");

            Usuario novoUsuario = new Usuario
            {
                NomeCompleto    = form["NomeCompleto"].ToString(),
                NomeUsuario     = form["NomeUsuario"].ToString(),
                Email           = form["Email"].ToString(),
                Senha           = form["Senha"].ToString(),

            };

            if(form.Files.Count > 0)
            {
                var file = form.Files[0];
                var folder = Path.Combine(Directory.GetCurrentDirectory(), "wwwroot/images");

                if (! Directory.Exists(folder))
                {
                    //Cria a pasta images
                   Directory.CreateDirectory(folder); 
                }

                var path = Path.Combine(folder, file.FileName);


                using(var stream = new FileStream(path, FileMode.Create))

                {
                    await file.CopyToAsync(stream);
                }

                novoUsuario.FotoPerfilUrl = file.FileName;

            }

            else
            {
                novoUsuario.FotoPerfilUrl = "";
            }

            try
            {
                //Adiciona um novo usuario na tabela usuario
                _context.Usuario.Add(novoUsuario);

                //salva no banco de dados as alteracoes feitas
                await _context.SaveChangesAsync();

                TempData["usuarioNovoCadastro"] = "Cadastrado";
                ViewBag.usuarioNovoCadastro ="";

                return RedirectToAction("Index", "Home");
            }

            catch (System.Exception)
            {
                ViewBag.usuarioNovoCadastro ="Nao cadastrado";
                TempData["usuarioNovoCadastro"] = "";
                //vamos pedir para a view falar no usuario que nao foi cadastrado
                return View();
            }

        }

        public IActionResult Perfil()
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