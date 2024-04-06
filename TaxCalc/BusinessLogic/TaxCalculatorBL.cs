﻿using TaxCalc.Models;
namespace TaxCalc.BusinessLogic
{
    public class TaxCalculatorBL : ITaxCalculatorBL
    {
        public TaxCalculatorBL() { }
        public int CalculateTaxBracket(double grossIncome)
        {
            if (grossIncome <= 5000) return 0;
            else if (grossIncome > 5000 && grossIncome <= 20000) return 20;
            else if (grossIncome > 20000) return 40;
            else return 0;
        }

        public double CalculateAnnualNetSalary(double grossIncome)
        {
            double val = grossIncome - 
                (((double)CalculateTaxBracket(grossIncome) / 100) * grossIncome);
            return Math.Round(val, 2);
        }

        public double CalculateAnnualTaxPaid(double grossIncome)
        {
            double val = (((double)CalculateTaxBracket(grossIncome) / 100.0) * grossIncome);
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