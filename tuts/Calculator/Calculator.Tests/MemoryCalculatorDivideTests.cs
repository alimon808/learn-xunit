using Xunit;

namespace Calculator.Tests
{
    public class MemoryCalculatorDivideTests
    {
        
        [Fact]
        public void ShouldDividePositiveNumbers()
        {
            var sut = new MemoryCalculator();

            sut.Add(10);
            sut.Divide(5);

            Assert.Equal(2, sut.CurrentValue);
        }

        //[Fact]
        //public void ShouldDivideNegativeNumbers()
        //{
        //    var sut = new MemoryCalculator();

        //    sut.Add(-15);
        //    sut.Divide(-5);

        //    Assert.Equal(3, sut.CurrentValue);
        //}
    }
}
