using Autofac;
using Calc.Controllers;
using Calc.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calc.WinForms
{
    static class Program
    {
        private static Autofac.IContainer autofacContainer;

        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            
            var containerBuilder = new ContainerBuilder();

            //models
            containerBuilder.RegisterType<Calculator>().As<ICalculator>().SingleInstance();
            containerBuilder.RegisterType<Logger>().As<ILogger>().SingleInstance();
            containerBuilder.RegisterType<Auth>().As<IAuth>().SingleInstance();
            containerBuilder.RegisterType<ModelFacade>().As<IModelFacade>().SingleInstance();

            //controllers
            containerBuilder.RegisterType<CalcController>().As<ICalcController>().SingleInstance();
            containerBuilder.RegisterType<LoginController>().As<ILoginController>().SingleInstance();
            containerBuilder.RegisterType<WinFormsViewHandler>().As<IViewHandler>().SingleInstance();

            //views
            containerBuilder.RegisterType<ErrorForm<ILoginController>>().As<IView>().Named<IView>("LoginError");
            containerBuilder.RegisterType<LoginForm>().As<IView>().Named<IView>("Login");
            containerBuilder.RegisterType<MainForm>().As<IView>().Named<IView>("Main");

            //infrastructure
            containerBuilder.RegisterType<AutofacContainer>().As<Controllers.IContainer>().SingleInstance();
            containerBuilder.Register(context => autofacContainer).As<Autofac.IContainer>();

            autofacContainer = containerBuilder.Build();

            Application.Run((Form)autofacContainer.ResolveNamed<IView>("Login"));
        }
    }
}
