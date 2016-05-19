using System.Collections.Generic;
using Xunit;

namespace Calculator.Tests
{
    public class MemoryCalculatorDataDrivenTests
    {
        [Theory]
        [MemberData("TestData", MemberType = typeof(MemoryCalculatorDataDrivenTestData))]
        public void ShouldSubtractTwoNumbers(int firstNumber, int secondNumber, int expectedResult)
        {
            var sut = new MemoryCalculator();

            sut.Subtract(firstNumber);
            sut.Subtract(secondNumber);

            Assert.Equal(expectedResult, sut.CurrentValue);
        }
    }
}
