using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;
using TaxCalc.Models;
using TaxCalc.BusinessLogic;
using TaxCalc.Data;

namespace TaxCalc.Controllers
{
    public class TaxController : Controller
    {
        ITaxCalculatorBL mTaxCalculatorBL = new TaxCalculatorBL();
        ApplicationDbContext dbContext;
        public TaxController(ApplicationDbContext context)
        {
            this.dbContext = context;
        }

        // Todo: you need to fix routing and razor page load between the index / tax calculator
        // this route wont register but the Get save is working in the db LOL

        //[Route("CalculateTaxes/{income}")]
        //[HttpPost]
        //public async Task<IActionResult> CalculateTaxes(double income)
        //{
        //    // Todo: do we need async for this?? how fast we runnin this C#? hmmm
        //    TaxViewModel taxData = new TaxViewModel();
        //    taxData.GrossAnnualSalary = income;
        //    taxData.GrossMonthlySalary = mTaxCalculatorBL.CalculateMonthlyGrossSalary(income);
        //    taxData.NetAnnualSalary = mTaxCalculatorBL.CalculateAnnualNetSalary(income);
        //    taxData.NetMonthlySalary = mTaxCalculatorBL.CalculateMonthlyNetSalary(income);
        //    taxData.AnnualTaxPaid = mTaxCalculatorBL.CalculateAnnualTaxPaid(income);
        //    taxData.MonthlyTaxPaid = mTaxCalculatorBL.CalculateMonthlyTaxPaid(income);

        //    await dbContext.TaxIds.AddAsync(taxData);
        //    await dbContext.SaveChangesAsync();

        //    return View(taxData);
        //}

        // Todo: lets clean this API up for correct post vs. get etc... not sure what else fancy DB
        // things we want?
        [HttpGet]
        public IActionResult CalculateTaxes(double income)
        {
            // Todo: do we need async for this?? how fast we runnin this C#? hmmm
            TaxViewModel taxData = new TaxViewModel();
            taxData.GrossAnnualSalary = income;
            taxData.GrossMonthlySalary = mTaxCalculatorBL.CalculateMonthlyGrossSalary(income);
            taxData.NetAnnualSalary = mTaxCalculatorBL.CalculateAnnualNetSalary(income);
            taxData.NetMonthlySalary = mTaxCalculatorBL.CalculateMonthlyNetSalary(income);
            taxData.AnnualTaxPaid = mTaxCalculatorBL.CalculateAnnualTaxPaid(income);
            taxData.MonthlyTaxPaid = mTaxCalculatorBL.CalculateMonthlyTaxPaid(income);

            // the database is now successfully saving to localdb
            dbContext.TaxIds.Add(taxData);
            dbContext.SaveChanges();

            return View(taxData);
        }
    }
}
