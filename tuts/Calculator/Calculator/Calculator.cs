using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator
{
    public class Calculator
    {
        public int Add(int a, int b)
        {
            return a + b;
        }

        public int AddInts(int a, int b)
        {
            return a + b;
        }

        public double AddDoubles(double a, double b)
        {
            return a + b;
        }

        public double Divide(int value, int by)
        {
            if (value > 200) // for demo purpose
            {
                throw new ArgumentOutOfRangeException("value");
            }
            return value / by;
        }
    }


}
