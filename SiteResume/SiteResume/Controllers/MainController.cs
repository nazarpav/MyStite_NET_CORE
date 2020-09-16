using System.Diagnostics;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using SiteResume.Models;
namespace SiteResume.Controllers
{
    public class MainController : Controller
    {
        private readonly ILogger<MainController> _logger;
        public MainController(ILogger<MainController> logger)
        {
            _logger = logger;
        }
        [AllowAnonymous]
        public IActionResult Index()
        {
            return View();
        }
        //[Authorize(Roles = "Admin")]
        [AllowAnonymous]
        public IActionResult AboutMe()
        {
            return View();
        }
        [AllowAnonymous]
        public IActionResult DownloadResume()
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

