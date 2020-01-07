using System.Collections.Generic;

namespace Calc.Models
{
    public class ModelFacade : IModelFacade
    {
        ICalculator calc;
        ILogger logger;
        IAuth auth;

        public ModelFacade(ICalculator calc, ILogger logger, IAuth auth)
        {
            this.calc = calc;
            this.logger = logger;
            this.auth = auth;
        }

        public double Result => calc.Result;

        public IEnumerable<string> LogItems => logger.Items;

        public bool Login(string user, string pwd)
            => auth.Login(user, pwd);

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
