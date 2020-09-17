using System.Diagnostics;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using SiteResume.DataBase.Services.Interfaces;
using SiteResume.Models;
namespace SiteResume.Controllers
{
    public class MainController : Controller
    {
        private readonly ILogger<MainController> _logger;
        private readonly IAboutMeService _aboutMeService;
        public MainController(ILogger<MainController> logger, IAboutMeService aboutMeService)
        {
            _logger = logger;
            _aboutMeService = aboutMeService;
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
            return View(_aboutMeService.GetEntry());
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

