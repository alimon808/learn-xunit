using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Calculator
{
    public class MemoryCalculator : IDisposable
    {
        public int CurrentValue { get; private set; }

        public MemoryCalculator()
        {
            // simulate expensive object creation
            //Thread.Sleep(TimeSpan.FromSeconds(5));
        }

        public void Add(int number)
        {
            CurrentValue += number;
        }

        public void Subtract(int number)
        {
            CurrentValue -= number;
        }

        public void Divide(int number)
        {
            CurrentValue = CurrentValue / number;
        }

        public void Clear()
        {
            CurrentValue = 0;
        }

        public void Dispose()
        {
            // clean up resources
        }
    }
}
