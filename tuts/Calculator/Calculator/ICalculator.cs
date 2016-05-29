using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator
{
    public interface ICalculator<T>
    {
        T Add(T leftOperand, T rightOperand);
        T Substract(T leftOperand, T rightOperand);
        T Multiply(T leftOperand, T righOperand);
        T Divide(T leftOperand, T rightOperand);
    }
}
