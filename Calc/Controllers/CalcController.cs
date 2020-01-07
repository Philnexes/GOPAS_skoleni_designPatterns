using Calc.Models;
using System;

namespace Calc.Controllers
{
    class CalcController : ICalcController
    {
        IModelFacade model;

        public CalcController(IModelFacade model)
        {
            this.model = model;
        }

        public IView MainView { get; set; }

        private void calculate(Action<double> operation, string x)
        {
            var dx = double.Parse(x);
            operation(dx);
            MainView.UpdateView();
        }

        public void MinusAction(string x)=>calculate(model.Minus, x);
        public void PlusAction(string x)=>calculate(model.Plus, x);
        
    }
}
