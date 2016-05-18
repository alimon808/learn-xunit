using Xunit;

namespace Calculator.Tests
{
    public class MemoryCalculatorSubtractTests
    {
        [Fact]
        public void ShouldSubtractPositiveNumbers()
        {
            var sut = new MemoryCalculator();

            sut.Subtract(5);

            Assert.Equal(-5, sut.CurrentValue);
        }

        [Fact]
        public void ShouldSubtractNegativeNumbers()
        {
            var sut = new MemoryCalculator();

            sut.Subtract(-5);

            Assert.Equal(5, sut.CurrentValue);
        }
    }
}
