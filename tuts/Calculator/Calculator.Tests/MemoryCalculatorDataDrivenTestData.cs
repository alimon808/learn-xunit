using System.Collections.Generic;
using Xunit;

namespace Calculator.Tests
{
    public class MemoryCalculatorDataDrivenTestData
    {
        public static IEnumerable<object[]> TestData
        {
            get
            {
                yield return new object[] { 5, 10, -15 };
                yield return new object[] { -5, -10, 15 };
                yield return new object[] { 10, 0, -10 };
                yield return new object[] { 0, 0, 0 };
                yield return new object[] { -99, 99, 0 };
            }
        }
    }
}
