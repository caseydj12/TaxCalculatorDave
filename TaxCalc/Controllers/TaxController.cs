using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;
using TaxCalc.Models;
using TaxCalc.BusinessLogic;

namespace TaxCalc.Controllers
{
    public class TaxController : Controller
    {
        ITaxCalculatorBL mTaxCalculatorBL = new TaxCalculatorBL();

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
