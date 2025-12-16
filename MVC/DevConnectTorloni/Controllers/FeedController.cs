using System.Threading.Tasks;
using DevConnectTorloni.Contexts;
using DevConnectTorloni.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace DevConnectTorloni.Controllers
{
    public class FeedController : Controller
    {
        private readonly DevConnectContext _context;

        private readonly ILogger<FeedController> _logger;

        public FeedController(ILogger<FeedController> logger, DevConnectContext context )
        {
            _logger = logger;
            _context = context;
        }

        [HttpGet]
        public async Task<IActionResult> Index()
        {
            try
            {
                List<Publicacao> publicacao = await _context.Publicacao.Include(p => p.IdUsuarioNavigation).ToListAsync();
                return View(publicacao);
            }
            catch (System.Exception)
            {
                
                throw;
            }
            //var frutas = await _context.fruta.TolistAsync();

            List<Publicacao> publicacaos = await _context.Publicacao.ToListAsync();

            //listar as publis
            return View(publicacaos);
        }

        [HttpPost]
        public async Task<IActionResult> Index(IFormCollection form)
        {
            Publicacao novaPublicacao = new Publicacao
            {
                Descricao       = form["Descricao"].ToString(),
                DataPublicacao  = DateOnly.FromDateTime(DateTime.Now)

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

                novaPublicacao.ImagemUrl = file.FileName;

            }

            try
            {
                //Adiciona um novo usuario na tabela usuario
                _context.Publicacao.Add(novaPublicacao);

                //salva no banco de dados as alteracoes feitas
                 await _context.SaveChangesAsync();

                // TempData["novaPublicacao"] = "Publicado";
                // ViewBag.novaPublicacao ="Publicado";

                
                return RedirectToAction("Index", "Feed");
                //return View(publicacaos);
            }

            catch (System.Exception)
            {
                ViewBag.novaPublicacao ="Nao publicado";
                // TempData["novaPublicacao"] = "";
                //vamos pedir para a view falar no usuario que nao foi cadastrado
                return View();
            }

            
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View("Error!");
        }
    }
}