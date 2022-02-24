using Xunit;
using Calculator_Classes;

namespace Calculator_Tests
{
    public class CalculateTest
    {
        Calculate calculate = new Calculate();
        // Decided to test all different operator here just once becuse
        // i test the different operators by them selfs bellow
        [Fact]
        public void CalculatingTest()
        {
            Assert.Equal(("45 + 9 = 54,000", 54), calculate.Calculating("+", 45, 9));
            Assert.Equal(("233 - -544 = 777,000", 777), calculate.Calculating("-", 233, -544));
            Assert.Equal(("31 * 7 = 217,000", 217), calculate.Calculating("*", 31, 7));
            Assert.Equal(("768 / 32 = 24,000", 24), calculate.Calculating("/", 768, 32));
            Assert.Equal(("32°F = 0,0°C", 0), calculate.Calculating("c", 32));
            Assert.Equal(("0°C = 32,0°F", 32), calculate.Calculating("f", 0));
            Assert.Equal(("HOW DID YOU GET HERE? (Sheck switch at row 16 at Calculate.cs)", 0), calculate.Calculating("ö", 235643));
        }

        [Theory]
        [InlineData(542, 35)]
        [InlineData(354, -23)]
        [InlineData(-44, -545)]
        [InlineData(-363, 34)]
        public void AdditionTest(decimal firstTerm, decimal secondTerm)
        {
            Assert.Equal(($"{firstTerm} + {secondTerm} = {(firstTerm + secondTerm).ToString("0.000")}", firstTerm + secondTerm), 
                calculate.Addition(firstTerm, secondTerm));
        }

        [Theory]
        [InlineData(542, 35)]
        [InlineData(354, -23)]
        [InlineData(-44, -545)]
        [InlineData(-363, 34)]
        public void SubtractionTest(decimal firstTerm, decimal secondTerm)
        {
            Assert.Equal(($"{firstTerm} - {secondTerm} = {(firstTerm - secondTerm).ToString("0.000")}", firstTerm - secondTerm),
                calculate.Subtraction(firstTerm, secondTerm));
        }

        [Theory]
        [InlineData(542, 35)]
        [InlineData(354, -23)]
        [InlineData(-44, -545)]
        [InlineData(-363, 34)]
        public void MultiplicationTest(decimal firstFactor, decimal secondFactor)
        {
            Assert.Equal(($"{firstFactor} * {secondFactor} = {(firstFactor * secondFactor).ToString("0.000")}", firstFactor * secondFactor),
                calculate.Multiplication(firstFactor, secondFactor));
        }

        [Theory]
        [InlineData(542, 35)]
        [InlineData(354, -23)]
        [InlineData(-44, -545)]
        [InlineData(-363, 34)]
        public void DivideTest(decimal firstFactor, decimal secondFactor)
        {
            Assert.Equal(($"{firstFactor} / {secondFactor} = {(firstFactor / secondFactor).ToString("0.000")}", firstFactor / secondFactor),
                calculate.Divide(firstFactor, secondFactor));
        }

        [Theory]
        [InlineData(-40)]
        [InlineData(32)]
        public void FarenheitToCelciusTest(decimal farenheit)
        {
            decimal celcius = (farenheit - 32) * (1 / 1.8M);
            Assert.Equal(($"{farenheit}°F = {celcius.ToString("0.0")}°C", celcius), 
                calculate.FarenheitToCelcius(farenheit));
        }

        [Theory]
        [InlineData(-40)]
        [InlineData(32)]
        public void CelciusToFarenheitTest(decimal celcius)
        {
            decimal farenheit = celcius * 1.8M + 32;
            Assert.Equal(($"{celcius}°C = {farenheit.ToString("0.0")}°F", farenheit),
                calculate.CelciusToFarenheit(celcius));
        }
    }
}