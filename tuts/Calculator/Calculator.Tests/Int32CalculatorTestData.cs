using System.Collections.Generic;

namespace Calculator.Tests
{
    public class Int32CalculatorTestData : ClassTestData
    {
        protected override List<object[]> TestData => new List<object[]>
        {
            new object[] {1, 7, 8 },
            new object[] {2, 2, 4 },
            new object[] {-33, -77, -110 },
            new object[] {256, -512, -256 },
            new object[] {0, 0, 0 }
        };
    }
}
