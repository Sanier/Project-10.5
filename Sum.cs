using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static Project_10._5.Program;

namespace Project_10._5
{
    public class Sum : ICalculate
    {
        ICalculate sum { get; }

        int ICalculate.Div(int a, int b)
        {
            return a / b;
        }

        int ICalculate.Mult(int a, int b)
        {
            return a * b;
        }

        int ICalculate.Sub(int a, int b)
        {
            return a - b;
        }

        int ICalculate.Sum(int a, int b)
        {
            return a + b;
        }
    }
}
