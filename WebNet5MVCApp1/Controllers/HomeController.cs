using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using MingChi.CRMApplication;
using MingChi.CRMApplication.CRMs;
using MingChi.Infrastructure.Configuration.CRMs;
using System.Diagnostics;
using WebNet5MVCApp1.Models;

namespace WebNet5MVCApp1.Controllers
{
    public class HomeController : Controller
    {
        private readonly IApplicationDbContext _applicationDbContext;
        private readonly IJsonConfigurationBuilder _jsonConfigurationBuilder;
        private readonly ILogger<HomeController> _logger;

        public HomeController(
            IApplicationDbContext applicationDbContext,
            IJsonConfigurationBuilder jsonConfigurationBuilder,
            ILogger<HomeController> logger)
        {
            _applicationDbContext = applicationDbContext;
            _jsonConfigurationBuilder = jsonConfigurationBuilder;
            _logger = logger;
        }

        public IActionResult Index()
        {
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

        public IActionResult CustomerList()
        {
            CRM crm = new CRM(_jsonConfigurationBuilder, _applicationDbContext);

            var result = crm.GetCustomers();

            return View(result);
        }
    }
}
