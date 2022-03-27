using Microsoft.AspNetCore.Mvc;
using StokTakip.Services.Abstract;
using StokTakip.Web.Models;
using System.Diagnostics;

namespace StokTakip.Web.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly IBirimService _birimService;
        public HomeController(ILogger<HomeController> logger, IBirimService birimService)
        {
            _logger = logger;
            _birimService = birimService;
        }

        public async Task<IActionResult> Index()
        {
            await _birimService.Add(new Entities.Dtos.BirimDtos.BirimAddDto
            {
                Adi ="Metre",
                Aciklama ="metre birimi açıklama"
            });

            var birim =await _birimService.GetAll();
          
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
}