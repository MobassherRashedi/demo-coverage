using CoverX.Api.Services;
using Xunit;
namespace CoverX.Api.Tests
{
    public class CalculatorServiceTests
    {
        private CalculatorService _calculator;

        public CalculatorServiceTests()
        {
            _calculator = new CalculatorService();
        }

        [Fact]
        public void Add_ShouldReturnCorrectSum()
        {
            // Arrange 
            int a = 10;
            int b = 2;

            // Act
            var result = _calculator.Add(a, b);

            // Assert
            Assert.Equal(12, result);
        }

        [Fact]
        public void Substract_ShouldReturnCorrectSum()
        {
            // Arrange 
            int a = 10;
            int b = 2;

            // Act
            var result = _calculator.Substract(a, b);

            // Assert
            Assert.Equal(8, result);
        }
    }
}
