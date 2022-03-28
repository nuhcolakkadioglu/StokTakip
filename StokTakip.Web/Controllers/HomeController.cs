using Microsoft.AspNetCore.Mvc;
using StokTakip.Services.Abstract;
using StokTakip.Web.Models;
using System.Diagnostics;

namespace StokTakip.Web.Controllers
{
    public class HomeController : Controller
    {
        private readonly IBirimService _birimService;
        public HomeController(IBirimService birimService)
        {
            _birimService = birimService;
        }

        public async Task<IActionResult> Index()
        {
            
            var birim =await _birimService.GetAll();
          
            return View();
        }


        public  IActionResult Store()
        {
 
            return View();
        }
        public IActionResult Products()
        {

            return View();
        }

    }
}