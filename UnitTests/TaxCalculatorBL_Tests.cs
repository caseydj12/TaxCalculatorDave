using TaxCalc.BusinessLogic;
namespace UnitTests
{
    [TestClass]
    public class TaxCalculatorBL_Tests
    {
        [TestMethod]
        public void CalculateTaxBracket_DoesMathCorrectly()
        {
            // Arrange
            double grossIncome_1 = 4000;
            double grossIncome_2 = 19000;
            double grossIncome_3 = 80000;
            double grossIncome_4 = 899111;

            // Act
            TaxCalculatorBL calculatorBL = new TaxCalculatorBL();
            double actual = calculatorBL.CalculateTaxBracket(grossIncome_1);
            double actual2 = calculatorBL.CalculateTaxBracket(grossIncome_2);
            double actual3 = calculatorBL.CalculateTaxBracket(grossIncome_3);
            double actual4 = calculatorBL.CalculateTaxBracket(grossIncome_4);

            // Assert
            Assert.AreEqual(actual, 0);
            Assert.AreEqual(actual2, 20);
            Assert.AreEqual(actual3, 40);
            Assert.AreEqual(actual4, 40);
        }

        [TestMethod]
        public void CalculateAnnualNetSalary_DoesMathCorrectly()
        {
            // Arrange
            double grossIncome_1 = 4000;
            double grossIncome_2 = 19000;
            double grossIncome_3 = 80000;
            double grossIncome_4 = 899111;

            // Act
            TaxCalculatorBL calculatorBL = new TaxCalculatorBL();
            double actual = calculatorBL.CalculateAnnualNetSalary(grossIncome_1);
            double actual2 = calculatorBL.CalculateAnnualNetSalary(grossIncome_2);
            double actual3 = calculatorBL.CalculateAnnualNetSalary(grossIncome_3);
            double actual4 = calculatorBL.CalculateAnnualNetSalary(grossIncome_4);

            // Assert
            Assert.AreEqual(actual, 4000);
            Assert.AreEqual(actual2, 15200);
            Assert.AreEqual(actual3, 48000);
            Assert.AreEqual(actual4, 539466.6);
        }

        [TestMethod]
        public void CalculateAnnualTaxPaid_DoesMathCorrectly()
        {
            // Arrange
            double grossIncome_1 = 4000;
            double grossIncome_2 = 19000;
            double grossIncome_3 = 80000;
            double grossIncome_4 = 899111;

            // Act
            TaxCalculatorBL calculatorBL = new TaxCalculatorBL();
            double actual = calculatorBL.CalculateAnnualTaxPaid(grossIncome_1);
            double actual2 = calculatorBL.CalculateAnnualTaxPaid(grossIncome_2);
            double actual3 = calculatorBL.CalculateAnnualTaxPaid(grossIncome_3);
            double actual4 = calculatorBL.CalculateAnnualTaxPaid(grossIncome_4);

            // Assert
            Assert.AreEqual(actual, 0);
            Assert.AreEqual(actual2, 3800);
            Assert.AreEqual(actual3, 32000);
            Assert.AreEqual(actual4, 359644.4);
        }

        [TestMethod]
        public void CalculateMonthlyGrossSalary_DoesMathCorrectly()
        {
            // Arrange
            double grossIncome_1 = 4000;
            double grossIncome_2 = 19000;
            double grossIncome_3 = 80000;
            double grossIncome_4 = 899111;

            // Act
            TaxCalculatorBL calculatorBL = new TaxCalculatorBL();
            double actual = calculatorBL.CalculateMonthlyGrossSalary(grossIncome_1);
            double actual2 = calculatorBL.CalculateMonthlyGrossSalary(grossIncome_2);
            double actual3 = calculatorBL.CalculateMonthlyGrossSalary(grossIncome_3);
            double actual4 = calculatorBL.CalculateMonthlyGrossSalary(grossIncome_4);

            // Assert
            Assert.AreEqual(actual, 333.33);
            Assert.AreEqual(actual2, 1583.33);
            Assert.AreEqual(actual3, 6666.67);
            Assert.AreEqual(actual4, 74925.92);
        }

        [TestMethod]
        public void CalculateMonthlyNetSalary_DoesMathCorrectly()
        {
            // Arrange
            double grossIncome_1 = 4000;
            double grossIncome_2 = 19000;
            double grossIncome_3 = 80000;
            double grossIncome_4 = 899111;

            // Act
            TaxCalculatorBL calculatorBL = new TaxCalculatorBL();
            double actual = calculatorBL.CalculateMonthlyNetSalary(grossIncome_1);
            double actual2 = calculatorBL.CalculateMonthlyNetSalary(grossIncome_2);
            double actual3 = calculatorBL.CalculateMonthlyNetSalary(grossIncome_3);
            double actual4 = calculatorBL.CalculateMonthlyNetSalary(grossIncome_4);

            // Assert
            Assert.AreEqual(actual, 333.33);
            Assert.AreEqual(actual2, 1266.67);
            Assert.AreEqual(actual3, 4000);
            Assert.AreEqual(actual4, 44955.55);
        }

        [TestMethod]
        public void CalculateMonthlyTaxPaid_DoesMathCorrectly()
        {
            // Arrange
            double grossIncome_1 = 4000;
            double grossIncome_2 = 19000;
            double grossIncome_3 = 80000;
            double grossIncome_4 = 899111;

            // Act
            TaxCalculatorBL calculatorBL = new TaxCalculatorBL();
            double actual = calculatorBL.CalculateMonthlyTaxPaid(grossIncome_1);
            double actual2 = calculatorBL.CalculateMonthlyTaxPaid(grossIncome_2);
            double actual3 = calculatorBL.CalculateMonthlyTaxPaid(grossIncome_3);
            double actual4 = calculatorBL.CalculateMonthlyTaxPaid(grossIncome_4);

            // Assert
            Assert.AreEqual(actual, 0);
            Assert.AreEqual(actual2, 316.67);
            Assert.AreEqual(actual3, 2666.67);
            Assert.AreEqual(actual4, 29970.37);
        }
    }
}