using Xunit;

namespace Calculator.Tests
{
    public class MemoryCalculatorAddTests
    {
        
        [Fact]
        public void ShouldAddPositiveNumbers()
        {
            var sut = new MemoryCalculator();

            sut.Add(10);
            sut.Add(5);

            Assert.Equal(15, sut.CurrentValue);
        }

        [Fact]
        public void ShouldAddNegativeNumbers()
        {
            var sut = new MemoryCalculator();

            sut.Add(-5);
            sut.Add(-5);

            Assert.Equal(-10, sut.CurrentValue);
        }
    }
}
