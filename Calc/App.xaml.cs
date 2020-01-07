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
            container.Bind<IModelFacade>().To<ModelFacade>().InSingletonScope();
            
            //controllers
            container.Bind<ICalcController>().To<CalcController>().InSingletonScope();
            
            //views
            MainWindow = container.Get<MainWindow>();
            MainWindow.Show();
        }
    }
}
