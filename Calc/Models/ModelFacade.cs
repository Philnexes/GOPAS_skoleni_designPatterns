using System.Collections.Generic;

namespace Calc.Models
{
    public class ModelFacade : IModelFacade
    {
        ICalculator calc;
        ILogger logger;

        public ModelFacade(ICalculator calc, ILogger logger)
        {
            this.calc = calc;
            this.logger = logger;
        }

        public double Result => calc.Result;

        public IEnumerable<string> LogItems => logger.Items;

        public void Minus(double x)
        {
            var prevResult = calc.Result;
            calc.Minus(x);
            logger.Write($"{prevResult}-{x}={calc.Result}");
        }

        public void Plus(double x)
        {
            var prevResult = calc.Result;
            calc.Plus(x);
            logger.Write($"{prevResult}+{x}={calc.Result}");
        }
    }
}
