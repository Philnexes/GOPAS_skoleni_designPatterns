using Calc.Models;
using Ninject;
using System;
using System.Windows;

namespace Calc.Controllers
{
    class CalcController : ICalcController
    {
        IKernel container;
        IModelFacade model;

        public CalcController(IKernel container)
        {
            this.container = container;
            model = container.Get<IModelFacade>();
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
                    ErrorView = this.container.Get<IView>("ErrCalc");
                ErrorView.UpdateView();
                ((Window)ErrorView).ShowDialog();
            }
        }

        public void MinusAction(string x) => calculate(model.Minus, x);
        public void PlusAction(string x) => calculate(model.Plus, x);

        public void ShowLogAction()
        {
            if (LogView == null || !((Window)LogView).IsVisible)
                LogView = this.container.Get<IView>("CalcError");
            ((Window)LogView).Show();
            LogView.UpdateView();
        }

        public void ExitAppAction()
        {
            App.Current.Shutdown();
        }
    }
}
