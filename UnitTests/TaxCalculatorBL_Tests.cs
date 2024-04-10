using TaxCalc.BusinessLogic;
namespace UnitTests
{
    [TestClass]
    public class TaxCalculatorBL_Tests
    {
        [TestMethod]
        public void CalculateAnnualNetSalary_DoesMathCorrectly()
        {
            // Arrange
            double grossIncome_1 = 4000;
            double grossIncome_2 = 19000;
            double grossIncome_3 = 40000;

            // Act
            TaxCalculatorBL calculatorBL = new TaxCalculatorBL();
            double actual = calculatorBL.CalculateAnnualNetSalary(grossIncome_1);
            double actual2 = calculatorBL.CalculateAnnualNetSalary(grossIncome_2);
            double actual3 = calculatorBL.CalculateAnnualNetSalary(grossIncome_3);

            // Assert
            Assert.AreEqual(actual, 4000);
            Assert.AreEqual(actual2, 16200);
            Assert.AreEqual(actual3, 29000);
        }

        [TestMethod]
        public void CalculateAnnualTaxPaid_DoesMathCorrectly()
        {
            // Arrange
            double grossIncome_1 = 4000;
            double grossIncome_2 = 19000;
            double grossIncome_3 = 40000;

            // Act
            TaxCalculatorBL calculatorBL = new TaxCalculatorBL();
            double actual = calculatorBL.CalculateAnnualTaxPaid(grossIncome_1);
            double actual2 = calculatorBL.CalculateAnnualTaxPaid(grossIncome_2);
            double actual3 = calculatorBL.CalculateAnnualTaxPaid(grossIncome_3);

            // Assert
            Assert.AreEqual(actual, 0);
            Assert.AreEqual(actual2, 2800);
            Assert.AreEqual(actual3, 11000);
        }

        [TestMethod]
        public void CalculateMonthlyGrossSalary_DoesMathCorrectly()
        {
            // Arrange
            double grossIncome_1 = 4000;
            double grossIncome_2 = 19000;
            double grossIncome_3 = 40000;

            // Act
            TaxCalculatorBL calculatorBL = new TaxCalculatorBL();
            double actual = calculatorBL.CalculateMonthlyGrossSalary(grossIncome_1);
            double actual2 = calculatorBL.CalculateMonthlyGrossSalary(grossIncome_2);
            double actual3 = calculatorBL.CalculateMonthlyGrossSalary(grossIncome_3);

            // Assert
            Assert.AreEqual(actual, 333.33);
            Assert.AreEqual(actual2, 1583.33);
            Assert.AreEqual(actual3, 3333.33);
        }

        [TestMethod]
        public void CalculateMonthlyNetSalary_DoesMathCorrectly()
        {
            // Arrange
            double grossIncome_1 = 4000;
            double grossIncome_2 = 19000;
            double grossIncome_3 = 80000;

            // Act
            TaxCalculatorBL calculatorBL = new TaxCalculatorBL();
            double actual = calculatorBL.CalculateMonthlyNetSalary(grossIncome_1);
            double actual2 = calculatorBL.CalculateMonthlyNetSalary(grossIncome_2);
            double actual3 = calculatorBL.CalculateMonthlyNetSalary(grossIncome_3);

            // Assert
            Assert.AreEqual(actual, 333.33);
            Assert.AreEqual(actual2, 1350);
            Assert.AreEqual(actual3, 4416.67);
        }

        [TestMethod]
        public void CalculateMonthlyTaxPaid_DoesMathCorrectly()
        {
            // Arrange
            double grossIncome_1 = 4000;
            double grossIncome_2 = 19000;
            double grossIncome_3 = 40000;

            // Act
            TaxCalculatorBL calculatorBL = new TaxCalculatorBL();
            double actual = calculatorBL.CalculateMonthlyTaxPaid(grossIncome_1);
            double actual2 = calculatorBL.CalculateMonthlyTaxPaid(grossIncome_2);
            double actual3 = calculatorBL.CalculateMonthlyTaxPaid(grossIncome_3);

            // Assert
            Assert.AreEqual(actual, 0);
            Assert.AreEqual(actual2, 233.33);
            Assert.AreEqual(actual3, 916.67);
        }
    }
}