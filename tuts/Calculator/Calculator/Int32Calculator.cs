using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator
{
    public class Int32Calculator : ICalculator<int>
    {
        public int Add(int leftOperand, int rightOperand) => leftOperand + rightOperand;

        public int Divide(int leftOperand, int rightOperand) => leftOperand / rightOperand;

        public int Multiply(int leftOperand, int righOperand) => leftOperand * righOperand;

        public int Substract(int leftOperand, int rightOperand) => leftOperand - rightOperand;
    }
}
