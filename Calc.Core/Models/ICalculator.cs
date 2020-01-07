namespace Calc.Models
{
    public interface ICalculator
    {
        double Result { get; }
        void Plus(double x);
        void Minus(double x);
    }
}