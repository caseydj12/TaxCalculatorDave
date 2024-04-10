namespace TaxCalc.BusinessLogic
{
    public interface ITaxCalculatorBL
    {
        /// <summary>
        /// Calculates the Annual Taxes paid for Gross Annual income passed.
        /// Tax Band Annual Salary Range (£) Tax Rate (%)
        /// First 5k is 0, the next 15k gets 20% tax, anything over that is 40%
        /// Tax Band A: 0 - 5000 0%
        /// Tax Band B: 5000 - 20000 20%
        /// Tax Band C: 20000+ 40 %
        /// </summary>
        /// <param name="grossAnnualIncome"></param>
        /// <returns></returns>
        public double CalculateAnnualTaxPaid(double grossAnnualIncome);
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
        /// Calculates the Monthly Taxes paid for Gross Annual income passed.
        /// </summary>
        /// <param name="grossAnnualIncome"></param>
        /// <returns></returns>
        public double CalculateMonthlyTaxPaid(double grossAnnualIncome);
    }
}
