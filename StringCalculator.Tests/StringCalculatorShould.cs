using Xunit;
using FluentAssertions;

namespace StringCalculatorKata.Tests
{
    public class StringCalculatorShould
    {
        [Fact]
        public void ReturnZeroWhenStringIsEmpty()
        {
            var result = StringCalculator.Sum("");
            result.Should().Be(0);
        }
    }
}