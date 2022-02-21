using Xunit;
using Calculator_Classes;

namespace Calculator_Tests
{
    public class InputHandlerTest
    {
        InputHandler inputHandler = new InputHandler();

        [Theory]
        [InlineData("")]
        [InlineData("xyzzy")]
        public void checkSpecialOperationTest(string input)
        {
            Assert.True(inputHandler.CheckSpecialOperation(input));
        }

        [Theory]
        [InlineData("+")]
        [InlineData("-")]
        [InlineData("*")]
        [InlineData("/")]
        [InlineData("c")]
        [InlineData("f")]
        public void ControlInputTest(string input)
        {
            Assert.True(inputHandler.ControlInput(input));
        }

        [Theory]
        [InlineData("?")]
        [InlineData("5")]
        [InlineData("d")]
        public void ControlInputTest2(string input)
        {
            Assert.False(inputHandler.ControlInput(input));
        }
    }
}
