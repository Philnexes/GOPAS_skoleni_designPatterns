using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calc
{
    public class Calculator : ICalculator
    {
        public double Result { get; private set; }
        public void Plus(double x) => Result += x;
    }
}
