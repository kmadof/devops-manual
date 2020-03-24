using FluentAssertions;
using Xunit;

namespace SimpleApp.Tests
{
    public class CalculatorTests
    {
        [Fact]
        public void ShouldAddTwoReturnCorrectResult()
        {
            Calculator.AddTwo(2).Should().Be(4);
        }
    }
}
