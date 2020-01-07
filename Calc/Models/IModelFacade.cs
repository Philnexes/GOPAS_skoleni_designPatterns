using System.Collections.Generic;

namespace Calc.Models
{
    public interface IModelFacade
    {
        double Result { get; }
        IEnumerable<string> LogItems { get; }
        void Minus(double x);
        void Plus(double x);
    }
}