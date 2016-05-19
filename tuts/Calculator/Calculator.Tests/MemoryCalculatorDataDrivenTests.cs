using System;
using Xunit;
using Xunit.Abstractions;

namespace Calculator.Tests
{
    public class MemoryCalculatorDataDrivenTests
    {
        [Theory]
        [InlineData(5, 10, -15)]
        [InlineData(-5,-10, 15)]
        [InlineData(10,0, -10)]
        public void ShouldSubtractTwoNumbers(int firstNumber, int secondNumber, int expectedResult)
        {

            var sut = new MemoryCalculator();

            sut.Subtract(firstNumber);
            sut.Subtract(secondNumber);

            Assert.Equal(expectedResult, sut.CurrentValue);
        }

        //[Fact]
        //public void ShouldSubtractTwoPositiveNumbers()
        //{
        //    var sut = new MemoryCalculator();

        //    sut.Subtract(5);
        //    sut.Subtract(10);

        //    Assert.Equal(-15, sut.CurrentValue);
        //}

        //[Fact]
        //public void ShouldSubtractTwoNegativeNumbers()
        //{
        //    var sut = new MemoryCalculator();

        //    sut.Subtract(-5);
        //    sut.Subtract(-10);

        //    Assert.Equal(15, sut.CurrentValue);
        //}
        
        //[Fact]
        //public void ShouldSubtractZero()
        //{
        //    var sut = new MemoryCalculator();

        //    sut.Subtract(10);
        //    sut.Subtract(0);

        //    Assert.Equal(-10, sut.CurrentValue);
        //}
    }
}
