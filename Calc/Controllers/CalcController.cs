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
        public IView ErrorView { get; set; }
        public string Error { get; private set; }


        private void calculate(Action<double> operation, string x)
        {
            var dx = 0d;
            try
            {
                dx = double.Parse(x);
                Error = "";
            }
            catch (FormatException)
            {
                Error = "Use numbers!";
            }
            catch (Exception ex)
            {
                Error = $"Unexpeced error: {ex.Message}";
            }
            if (Error == "")
            {
                operation(dx);
                MainView.UpdateView();
                if (LogView != null && ((Window)LogView).IsVisible)
                    LogView.UpdateView();

            }
            else
            {
                if (ErrorView == null || !((Window)ErrorView).IsVisible)
                    ErrorView = new ErrorWindow(model, this);
                ErrorView.UpdateView();
                ((Window)ErrorView).ShowDialog();
            }
        }

        public void MinusAction(string x) => calculate(model.Minus, x);
        public void PlusAction(string x) => calculate(model.Plus, x);

        public void ShowWindowAction()
        {
            if (LogView == null || !((Window)LogView).IsVisible)
                LogView = new LogWindow(model, this);
            ((Window)LogView).Show();
            LogView.UpdateView();
        }
    }
}
