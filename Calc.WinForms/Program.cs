using Calc.Controllers;
using Calc.Models;
using Ninject;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calc.WinForms
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            
            var container = new StandardKernel();
            
            //models
            container.Bind<ICalculator>().To<Calculator>().InSingletonScope();
            container.Bind<ILogger>().To<Logger>().InSingletonScope();
            container.Bind<IAuth>().To<Auth>().InSingletonScope();
            container.Bind<IModelFacade>().To<ModelFacade>().InSingletonScope();

            //controllers
            container.Bind<ICalcController>().To<CalcController>().InSingletonScope();
            container.Bind<ILoginController>().To<LoginController>().InSingletonScope();
            container.Bind<IViewHandler>().To<WinFormsViewHandler>().InSingletonScope();

            //views
            container.Bind<IView>().To<ErrorForm<ILoginController>>().Named("LoginError");
            //container.Bind<IView>().To<ErrorWindow<ICalcController>>().Named("CalcError");
            container.Bind<IView>().To<LoginForm>().Named("Login");
            //container.Bind<IView>().To<LogWindow>().Named("Log");
            container.Bind<IView>().To<MainForm>().Named("Main");

            Application.Run((Form)container.Get<IView>("Login"));
        }
    }
}
