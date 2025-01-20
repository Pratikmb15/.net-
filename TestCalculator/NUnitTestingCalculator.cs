using CalculatorProj;

namespace TestCalculator
{
    public class Tests
    {
        [SetUp]

        public void Setup()
        {
        }

        [Test]
        public void TestSum_ValidInputs_ReturnsCorrectSum()
        {
            // Arrange
            double a = 5;
            double b = 3;
            double expected = 8;

            // Act
            double result = Calculator.Sum(a, b);

            // Assert
            Assert.AreEqual(expected, result, "Sum method failed for valid inputs.");
        }
        [Test]
        public void TestDiff_ReturnCorrectDifference() 
        {
            //Arrange
            double a = 10;
            double b = 4;
            double expected = 6;

            //Act
            double result = Calculator.Diff(a, b);

            //Assert
            Assert.AreEqual(expected,result, "Diff method failed for valid inputs.");
        }
        
    }
}