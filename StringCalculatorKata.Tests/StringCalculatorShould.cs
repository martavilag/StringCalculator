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

        [Theory]
        [InlineData("1",1)]
        [InlineData("2",2)]
        [InlineData("3",3)]
        public void ReturnANumberWhenStringIsTheSameNumber(string number, int expected)
        {
            var result = StringCalculator.Sum(number);
            result.Should().Be(expected);
        }
        
    }
}