using TaxCalc.BusinessLogic;
namespace UnitTests
{
    [TestClass]
    public class TaxCalculatorBL_Tests
    {

        ITaxCalculatorBL _taxCalculatorBL;
        [TestInitialize]
        public void TestInitialize()
        {
            _taxCalculatorBL = new TaxCalculatorBL();
        }

        [TestMethod]
        public void CalculateAnnualNetSalary_DoesMathCorrectly()
        {
            // Arrange
            double grossIncome_1 = 4000;
            double grossIncome_2 = 19000;
            double grossIncome_3 = 40000;

            // Act
            double actual = _taxCalculatorBL.CalculateAnnualNetSalary(grossIncome_1);
            double actual2 = _taxCalculatorBL.CalculateAnnualNetSalary(grossIncome_2);
            double actual3 = _taxCalculatorBL.CalculateAnnualNetSalary(grossIncome_3);

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
            double actual = _taxCalculatorBL.CalculateAnnualTaxPaid(grossIncome_1);
            double actual2 = _taxCalculatorBL.CalculateAnnualTaxPaid(grossIncome_2);
            double actual3 = _taxCalculatorBL.CalculateAnnualTaxPaid(grossIncome_3);

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
            double actual = _taxCalculatorBL.CalculateMonthlyGrossSalary(grossIncome_1);
            double actual2 = _taxCalculatorBL.CalculateMonthlyGrossSalary(grossIncome_2);
            double actual3 = _taxCalculatorBL.CalculateMonthlyGrossSalary(grossIncome_3);

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
            double actual = _taxCalculatorBL.CalculateMonthlyNetSalary(grossIncome_1);
            double actual2 = _taxCalculatorBL.CalculateMonthlyNetSalary(grossIncome_2);
            double actual3 = _taxCalculatorBL.CalculateMonthlyNetSalary(grossIncome_3);

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
            double actual = _taxCalculatorBL.CalculateMonthlyTaxPaid(grossIncome_1);
            double actual2 = _taxCalculatorBL.CalculateMonthlyTaxPaid(grossIncome_2);
            double actual3 = _taxCalculatorBL.CalculateMonthlyTaxPaid(grossIncome_3);

            // Assert
            Assert.AreEqual(actual, 0);
            Assert.AreEqual(actual2, 233.33);
            Assert.AreEqual(actual3, 916.67);
        }
    }
}