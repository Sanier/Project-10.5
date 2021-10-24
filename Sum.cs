using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static Project_10._5.Program;

namespace Project_10._5
{
    class Sum : ICalculate
    {
        ICalculate sum { get; }

        public int Div(int a, int b)
        {
            return a / b;
        }

        public int Mult(int a, int b)
        {
            return a * b;
        }

        public int Sub(int a, int b)
        {
            return a - b;
        }

        int ICalculate.Sum(int a, int b)
        {
            return a + b;
        }
    }
}
