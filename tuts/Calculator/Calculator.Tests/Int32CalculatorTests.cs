using Xunit;

namespace Calculator.Tests
{
    public class Int32CalculatorTests
    {
        [Fact]
        public void ShouldSubtract()
        {
            var sut = new Int32Calculator();

            var result = sut.Substract(77, 100);

            Assert.Equal(-23, result);
        }

        [Theory]
        [InlineData(3, 3, 9)]
        [InlineData(2, 9, 18)]
        public void ShouldMultipy(int leftOperand, int rightOperand, int expected)
        {
            var sut = new Int32Calculator();

            var result = sut.Multiply(leftOperand, rightOperand);

            Assert.Equal(expected, result);
        }

        [Theory]
        [ClassData(typeof(Int32CalculatorTestData))]
        public void ShouldAdd(int leftOperand, int rightOperand, int expected)
        {
            var sut = new Int32Calculator();

            var result = sut.Add(leftOperand, rightOperand);

            Assert.Equal(expected, result);
        }
    }
}
