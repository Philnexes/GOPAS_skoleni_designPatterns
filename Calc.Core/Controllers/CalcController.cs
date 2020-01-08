using Calc.Models;
// using Calc.Views;
//using Ninject;
using System;
//using System.Windows;

namespace Calc.Controllers
{
    public class CalcController : ICalcController
    {
        IContainer container;
        IModelFacade model;
        IViewHandler viewHandler;

        public CalcController(IContainer container) //IModelFacade model)
        {
            this.container = container;
            model = container.GetModelFacade();
            viewHandler = container.GetViewHandler();
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
                if (viewHandler.IsReady(LogView)) //LogView != null && ((Window)LogView).IsVisible)
                    LogView.UpdateView();

            }
            else
            {
                if (!viewHandler.IsReady(ErrorView)) //ErrorView == null || !((Window)ErrorView).IsVisible)
                    ErrorView = container.GetCalcErrorView(); //new ErrorWindow<ICalcController>(model, this);
                ErrorView.UpdateView();
                //((Window)ErrorView).ShowDialog();
                viewHandler.ShowModal(ErrorView);
            }
        }

        public void MinusAction(string x) => calculate(model.Minus, x);
        public void PlusAction(string x) => calculate(model.Plus, x);

        public void ShowLogAction()
        {
            if (!viewHandler.IsReady(LogView)) //LogView == null || !((Window)LogView).IsVisible)
                LogView = container.GetLogView(); //new LogWindow(model, this);
            //((Window)LogView).Show();
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
