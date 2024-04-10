using TaxCalc.Models;
namespace TaxCalc.BusinessLogic
{
    public class TaxCalculatorBL : ITaxCalculatorBL
    {
        public TaxCalculatorBL() { }
        public double CalculateAnnualTaxPaid(double grossIncome)
        {
            if (grossIncome <= 5000)
            {
                return 0;
            }
            else if (grossIncome > 5000 && grossIncome <= 20000)
            {
                return (grossIncome - 5000) * .20;
            }
            else if (grossIncome > 20000)
            {
                double taxOnIncomeUnder20k = 15000 * .20;
                double taxOnIncomeOver20k = (grossIncome - 20000) * .40;
                return taxOnIncomeUnder20k + taxOnIncomeOver20k;
            }
            else return 0;
        }

        public double CalculateAnnualNetSalary(double grossIncome)
        {
            double val = grossIncome - CalculateAnnualTaxPaid(grossIncome);
            return Math.Round(val, 2);
        }

        public double CalculateMonthlyGrossSalary(double grossIncome)
        {
            double val = grossIncome / 12;
            return Math.Round(val, 2);
        }

        public double CalculateMonthlyNetSalary(double grossIncome)
        {
            double val = CalculateAnnualNetSalary(grossIncome) / 12.0;
            return Math.Round(val, 2);
        }

        public double CalculateMonthlyTaxPaid(double grossIncome)
        {
            double val = CalculateAnnualTaxPaid(grossIncome) / 12.0;
            return Math.Round(val, 2);
        }
    }
}
