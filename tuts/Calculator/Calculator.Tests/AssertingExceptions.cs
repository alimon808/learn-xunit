using System;
using Xunit;

namespace Calculator.Tests
{
    public class AssertingExceptions
    {
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
    }
}
