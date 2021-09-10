using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using MingChi.CRMApplication;
using MingChi.CRMApplication.CRMs;
using MingChi.CRMApplication.CRMs.ViewModels;
using MingChi.Infrastructure.Configuration.CRMs;
using System.Diagnostics;
using WebNet5MVCApp1.Models;

namespace WebNet5MVCApp1.Controllers
{
    public class HomeController : Controller
    {
        private readonly ICustomerRepository _customerRepository;
        private readonly IUnitOfWork _unitOfWork;
        private readonly ILogger<HomeController> _logger;

        public HomeController(
            ICustomerRepository customerRepository,
            IUnitOfWork unitOfWork,
            ILogger<HomeController> logger)
        {
            _customerRepository = customerRepository;
            _unitOfWork = unitOfWork;
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
            CRM crm = new CRM(_customerRepository, _unitOfWork);

            var result = crm.GetCustomers();

            return View(result);
        }

        public IActionResult AddCustomer()
        {
            return View();
        }

        [HttpPost]
        public IActionResult AddCustomer(CustomerViewModel customer)
        {
            CRM crm = new CRM(_customerRepository, _unitOfWork);

            crm.AddCustomer(customer);

            return RedirectToAction("CustomerList");
        }
    }
}
