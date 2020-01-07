using Calc.Controllers;
using Calc.Models;
using Calc.Views;
using Ninject;
using System.Windows;

namespace Calc
{
    /// <summary>
    /// Interaction logic for App.xaml
    /// </summary>
    public partial class App : Application
    {
        protected override void OnStartup(StartupEventArgs e)
        {
            //var model = new Calculator();
            //var calcController = new CalcController(model);
            //var mainView = new MainWindow(model, calcController);
            //MainWindow = mainView;
            //mainView.Show();
            
            var container = new StandardKernel();

            //models
            container.Bind<ICalculator>().To<Calculator>().InSingletonScope();
            container.Bind<ILogger>().To<Logger>().InSingletonScope();
            container.Bind<IAuth>().To<Auth>().InSingletonScope();
            container.Bind<IModelFacade>().To<ModelFacade>().InSingletonScope();
            
            //controllers
            container.Bind<ICalcController>().To<CalcController>().InSingletonScope();
            container.Bind<ILoginController>().To<LoginController>().InSingletonScope();
            container.Bind<IViewHandler>().To<WpfViewHandler>().InSingletonScope();

            //views
            container.Bind<IView>().To<ErrorWindow<ILoginController>>().Named("LoginError");
            container.Bind<IView>().To<ErrorWindow<ICalcController>>().Named("CalcError");
            container.Bind<IView>().To<LoginWindow>().Named("Login");
            container.Bind<IView>().To<LogWindow>().Named("Log");
            container.Bind<IView>().To<MainWindow>().Named("Main");

            MainWindow = (Window)container.Get<IView>("Login");
            MainWindow.Show();
        }
    }
}
