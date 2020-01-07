namespace Calc.Models
{
    public class Calculator : ICalculator
    {
        public double Result { get; private set; }

        public void Minus(double x) => Result -= x;

        public void Plus(double x) => Result += x;
    }
}
