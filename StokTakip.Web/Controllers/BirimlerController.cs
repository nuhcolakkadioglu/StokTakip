using Microsoft.AspNetCore.Mvc;
using StokTakip.Entities.Dtos.BirimDtos;
using StokTakip.Services.Abstract;

namespace StokTakip.Web.Controllers
{
    public class BirimlerController : Controller
    {
        private readonly IBirimService _birimService;
        public BirimlerController(IBirimService birimService)
        {
            _birimService = birimService;
        }

        public async Task<IActionResult> Index()
        {
            var data = await _birimService.GetAll();
            return View(data.Data);
        }

        public IActionResult Create()
        {

            return View();
        }
        [HttpPost]
        public async Task<IActionResult> Create(BirimAddDto birimAddDto)
        {
            await _birimService.Add(birimAddDto);
            return RedirectToAction(nameof(Index));
        }



    }
}
