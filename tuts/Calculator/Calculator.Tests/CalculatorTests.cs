using System;
using System.Threading;
using Xunit;

namespace Calculator.Tests
{
    [Trait("Category", "Error Checking")]
    public class CalculatorTests
    {
        [Fact]
        public void ShouldAdd()
        {
            var sut = new Calculator();

            var result = sut.Add(1, 2);

            Assert.Equal(3, result);
        }

        [Fact]
        public void ShouldErrorWhenDivideByZero()
        {
            var sut = new Calculator();

            Assert.Throws<DivideByZeroException>(() => sut.Divide(10, 0));
        }

        [Fact]
        public void ShouldErrorWhenNumberTooBig()
        {
            var sut = new Calculator();

            ArgumentOutOfRangeException thrownExeption = Assert.Throws<ArgumentOutOfRangeException>(() => sut.Divide(201, 1));

            Assert.Equal("value", thrownExeption.ParamName);
        }

        [Fact]
        [Trait("Category", "Slow Running")]
        public void ShouldErrorWhenNumberTooBig_SLOW()
        {
            var sut = new Calculator();

            // simulate long running test
            Thread.Sleep(TimeSpan.FromSeconds(2));

            ArgumentOutOfRangeException thrownException = Assert.Throws<ArgumentOutOfRangeException>(() => sut.Divide(201, 1));
        }
    }
}
