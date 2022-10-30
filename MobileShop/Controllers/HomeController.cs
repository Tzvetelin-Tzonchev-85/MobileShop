namespace MobileShop.Controllers
{
    using Microsoft.AspNetCore.Mvc;
    using MobileShop.Core.Constants;
    using MobileShop.Models;
    using System.Diagnostics;

    public class HomeController : BaseController
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
            ViewData[MessageConstant.SuccessMessage] = "Bravo uspqhme da podkarame tostera!";
            return View();
        }

        public IActionResult Privacy(ErrorViewModel error)
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