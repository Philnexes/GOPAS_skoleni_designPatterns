using Calc.Models;
using Calc.Views;
using System;
using System.Windows;

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
        public IView LogView { get; set; }

        private void calculate(Action<double> operation, string x)
        {
            var dx = double.Parse(x);
            operation(dx);
            MainView.UpdateView();
            if ((LogView != null || !((Window)LogView).IsVisible) && ((Window)LogView).IsVisible)
                LogView.UpdateView();
        }

        public void MinusAction(string x)=>calculate(model.Minus, x);
        public void PlusAction(string x)=>calculate(model.Plus, x);

        public void ShowWindowAction()
        {
            if (LogView == null)
                LogView = new LogWindow(model, this);
            ((Window)LogView).Show();
            LogView.UpdateView();
        }
    }
}
