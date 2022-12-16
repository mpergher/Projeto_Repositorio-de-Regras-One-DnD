using GlossarioOneDnD_MVC.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Newtonsoft.Json;
using System.Diagnostics;

namespace GlossarioOneDnD_MVC.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }

        public IActionResult DataTable()
        {
            Context contexto = new Context();
            List<Regra> list = new List<Regra>();
            list = (from Regra r in contexto.Regras select r).Include(g => g.Glossario).ToList<Regra>();

            return View(list);
        }

        [HttpPost]
        public string GetRegras()
        {
            var list = GetAllRegras();
            var result = JsonConvert.SerializeObject(new { data = list });
            return result;
        }

        private List<Regra> GetAllRegras()
        {
            Context contexto = new Context();
            List<Regra> list = new List<Regra>();
            list = (from Regra r in contexto.Regras select r).ToList<Regra>();

            return list;
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}