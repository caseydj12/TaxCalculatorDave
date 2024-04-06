namespace TaxCalc.BusinessLogic
{
    public interface ITaxCalculatorBL
    {
        /// <summary>
        /// Calculates the Tax bracket for for Gross Annual income passed.
        /// </summary>
        /// <param name="grossAnnualIncome"></param>
        /// <returns></returns>
        public int CalculateTaxBracket(double grossAnnualIncome);
        /// <summary>
        /// Calculates the Monthly Gross Salary for Gross Annual income passed.
        /// </summary>
        /// <param name="grossAnnualIncome"></param>
        /// <returns></returns>
        public double CalculateMonthlyGrossSalary(double grossAnnualIncome);
        /// <summary>
        /// Calculates the Annual Net Salary after taxes for Gross Annual income passed.
        /// </summary>
        /// <param name="grossAnnualIncome"></param>
        /// <returns></returns>
        public double CalculateAnnualNetSalary(double grossAnnualIncome);
        /// <summary>
        /// Calculates the Monthly Net Salary after taxes for Gross Annual income passed.
        /// </summary>
        /// <param name="grossAnnualIncome"></param>
        /// <returns></returns>
        public double CalculateMonthlyNetSalary(double grossAnnualIncome);
        /// <summary>
        /// Calculates the Annual Taxes paid for Gross Annual income passed.
        /// </summary>
        /// <param name="grossAnnualIncome"></param>
        /// <returns></returns>
        public double CalculateAnnualTaxPaid(double grossAnnualIncome);
        /// <summary>
        /// Calculates the Monthly Taxes paid for Gross Annual income passed.
        /// </summary>
        /// <param name="grossAnnualIncome"></param>
        /// <returns></returns>
        public double CalculateMonthlyTaxPaid(double grossAnnualIncome);
    }
}
