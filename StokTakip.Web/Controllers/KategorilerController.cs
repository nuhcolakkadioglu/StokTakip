using Microsoft.AspNetCore.Mvc;
using StokTakip.Services.Abstract;

namespace StokTakip.Web.Controllers
{
    public class KategorilerController : Controller
    {
        private readonly IKategoriService _kategoriService;

        public KategorilerController(IKategoriService kategoriService)
        {
            _kategoriService = kategoriService;
        }

        public async Task< IActionResult> Index()
        {
            

            var data = await _kategoriService.GetAll();
            return View(data.Data);
        }
    }
}
