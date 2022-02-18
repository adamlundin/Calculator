using Xunit;
using Calculator_Classes;

namespace Calculator_Tests
{
    public class CalculateTest
    {
        [Fact]
        public void CalculatingTest()
        {
            Calculate calculate = new Calculate();
            Assert.Equal(("45 + 9 = 54,000", 54), calculate.Calculating("+", 45, 9));
            Assert.Equal(("233 - -544 = 777,000", 777), calculate.Calculating("-", 233, -544));
            Assert.Equal(("31 * 7 = 217,000", 217), calculate.Calculating("*", 31, 7));
            Assert.Equal(("768 / 32 = 24,000", 24), calculate.Calculating("/", 768, 32));
        }
    }
}