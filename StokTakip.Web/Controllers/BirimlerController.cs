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
        public async Task< IActionResult> Update(int id)
        {
            var data = await _birimService.Get(id);
            return View(new BirimUpdateDto
            {
                Id =data.Data.Birim.Id,
                Aciklama = data.Data.Birim.Aciklama,
                Adi=data.Data.Birim.Adi
            });
        }
        [HttpPost]
        public async Task<IActionResult> Update(BirimUpdateDto model)
        {
         await   _birimService.Update(model);
            return RedirectToAction(nameof(Index));
        }


    }
}
