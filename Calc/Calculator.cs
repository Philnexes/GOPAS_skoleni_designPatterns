namespace Calc
{
    public class Calculator : ICalculator
    {
        public double Result { get; private set; }
        public void Plus(double x) => Result += x;
        public void Minus(double x) => Result -= x;
    }
}
