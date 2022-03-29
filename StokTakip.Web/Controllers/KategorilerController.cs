using Microsoft.AspNetCore.Mvc;
using StokTakip.Entities.Dtos.KategoriDtos;
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

        public async Task<IActionResult> Index()
        {

            var data = await _kategoriService.GetAll();
            return View(data.Data);
        }
        public IActionResult Create()
        {

            return View();
        }
        [HttpPost]
        public async Task<IActionResult> Create(KategoriAddDto kategoriAddDto)
        {
            await _kategoriService.Add(kategoriAddDto);
            return RedirectToAction(nameof(Index));
        }
        public async Task<IActionResult> Update(int id)
        {
            var data =  await _kategoriService.Get(id);

            return View(new KategoriUpdateDto
            {
                Id = data.Data.Kategori.Id,
                Adi = data.Data.Kategori.Adi,
                Aciklama =data.Data.Kategori.Aciklama
            });  
            
        }
        [HttpPost]
        public async Task<IActionResult> Update(KategoriUpdateDto model)
        {
            var data = await _kategoriService.Update(model);
            return RedirectToAction(nameof(Index));

        }

    }
}
