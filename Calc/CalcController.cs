using System;

namespace Calc
{
    class CalcController : ICalcController
    {
        ICalculator model;

        public CalcController(ICalculator model)
        {
            this.model = model;
        }

        public MainWindow MainView { get; set; }

        private void Calculate(Action<double> operation, string x)
        {
            var dx = double.Parse(x);
            operation(dx);
            MainView.UpdateView();
        }

        public void PlusAction(string x) => Calculate(model.Plus, x);

        public void MinusAction(string x) => Calculate(model.Minus, x);
    }
}
