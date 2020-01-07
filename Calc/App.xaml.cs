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
            /*var model = new Calculator();
            var calcController = new CalcController(model);
            var mainView = new MainWindow(model, calcController);
            MainWindow = mainView;
            mainView.Show();*/

            var container = new StandardKernel();
            container.Bind <ICalculator>().To<Calculator>().InSingletonScope();
            container.Bind<ICalcController>().To<CalcController>();
            MainWindow = container.Get<MainWindow>();
            MainWindow.Show();
        }
    }
}