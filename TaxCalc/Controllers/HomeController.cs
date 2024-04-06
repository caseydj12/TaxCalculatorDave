using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;
using TaxCalc.BusinessLogic;
using TaxCalc.Models;

namespace TaxCalc.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        ITaxCalculatorBL mTaxCalculatorBL = new TaxCalculatorBL();

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
            return View(new TaxViewModel
            {
                GrossAnnualSalary = 0,
                GrossMonthlySalary = 0,
                NetAnnualSalary = 0,
                NetMonthlySalary = 0,
                AnnualTaxPaid = 0,
                MonthlyTaxPaid = 0,
            });
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

        [HttpGet]
        public IActionResult CalculateTaxes(double income)
        {
            TaxViewModel taxData = new TaxViewModel();
            taxData.GrossAnnualSalary = income;
            taxData.GrossMonthlySalary = mTaxCalculatorBL.CalculateMonthlyGrossSalary(income);
            taxData.NetAnnualSalary = mTaxCalculatorBL.CalculateAnnualNetSalary(income);
            taxData.NetMonthlySalary = mTaxCalculatorBL.CalculateMonthlyNetSalary(income);
            taxData.AnnualTaxPaid = mTaxCalculatorBL.CalculateAnnualTaxPaid(income);
            taxData.MonthlyTaxPaid = mTaxCalculatorBL.CalculateMonthlyTaxPaid(income);
            return View(taxData);
        }
    }
}