using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;


namespace PremiumCalculator.MVC.Controllers
{
    public class HomeController : Controller
    {

        private readonly IPremiumService _premiumService;

        private readonly IConfiguration _config;
        public HomeController(IConfiguration configuration, IPremiumService premiumService)
        {
            _config = configuration;

            _premiumService = premiumService;
        }

        public IActionResult Index()
        {

            HomeViewModel m = new HomeViewModel();

            // string baseAddress = "https://localhost:44346/";
            //Information from the appsettings.json
            string baseAddress = _config["WebAPIConfig:WebAddress"];

            ViewBag.BaseAddress = baseAddress;



            m.States = _premiumService.GetStates();
            m.Plans = _premiumService.GetPlans();
            m.Periods = _premiumService.GetPeriods();

            return View(m);
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