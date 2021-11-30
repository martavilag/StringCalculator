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
        
        [Theory]
        [InlineData("1,0",1)]
        [InlineData("2,0",2)]
        [InlineData("3,0",3)]
        public void ReturnANumberWhenStringIsZeroAndTheSameNumber(string number, int expected)
        {
            var result = StringCalculator.Sum(number);
            result.Should().Be(expected);
        }
        
        [Theory]
        [InlineData("1,1", 2)]
        [InlineData("1,2", 3)]
        [InlineData("1,3", 4)]
        public void ReturnTheSumOfTheTwoNumbersOnTheString(string number, int expected)
        {
            var result = StringCalculator.Sum(number);
            result.Should().Be(expected);
        }
        
        [Theory]
        [InlineData("10,1", 11)]
        [InlineData("10,2", 12)]
        [InlineData("10,3", 13)]
        public void ReturnTheSumOfTenAndTheOtherNumberAfterTheComma(string number, int expected)
        {
            var result = StringCalculator.Sum(number);
            result.Should().Be(expected);
        }
        
        [Theory]
        [InlineData("10,13", 23)]
        [InlineData("10,20", 30)]
        [InlineData("10,300", 310)]
        public void ReturnTheSumOfAnyNumberBeforeAndAfterTheComma(string number, int expected)
        {
            var result = StringCalculator.Sum(number);
            result.Should().Be(expected);
        }
        
    }
}