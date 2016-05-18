using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator.Tests
{
    public class MemoryCalculatorFixture : IDisposable
    {
        public MemoryCalculator Sut { get; private set; }

        public MemoryCalculatorFixture()
        {
            Sut = new MemoryCalculator();
        }

        public void Dispose()
        {
            Sut.Dispose();
        }
    }
}
