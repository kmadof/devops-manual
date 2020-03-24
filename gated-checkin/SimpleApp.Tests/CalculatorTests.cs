using FluentAssertions;
using Xunit;

namespace SimpleApp.Tests
{
    public class CalculatorTests
    {
        [Theory]
        [InlineData(2, 4)]
        [InlineData(3, 5)]
        [InlineData(1, 1)]
        public void ShouldAddTwoReturnCorrectResult(int value, int result)
        {
            Calculator.AddTwo(value).Should().Be(result);
        }
    }
}
