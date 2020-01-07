using Calc.Models;
using Ninject;
using System;

namespace Calc.Controllers
{
    public class CalcController : ICalcController
    {
        IKernel container;
        IModelFacade model;
        IViewHandler viewHandler;

        public CalcController(IKernel container)
        {
            this.container = container;
            model = container.Get<IModelFacade>();
            viewHandler = container.Get<IViewHandler>();
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
                if (viewHandler.IsReady(LogView))
                    LogView.UpdateView();

            }
            else
            {
                if (!viewHandler.IsReady(ErrorView))
                    ErrorView = this.container.Get<IView>("ErrCalc");

                ErrorView.UpdateView();
                viewHandler.ShowModal(ErrorView);
            }
        }

        public void MinusAction(string x) => calculate(model.Minus, x);
        public void PlusAction(string x) => calculate(model.Plus, x);

        public void ShowLogAction()
        {
            if (!viewHandler.IsReady(LogView))
                LogView = this.container.Get<IView>("CalcError");
            viewHandler.Show(LogView);
            LogView.UpdateView();
        }

        public void ExitAppAction()
        {
            //App.Current.Shutdown();
            viewHandler.ExitApp();
        }
    }
}