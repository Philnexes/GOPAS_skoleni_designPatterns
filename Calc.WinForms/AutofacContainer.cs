
using Autofac;
using Calc.Controllers;
using Calc.Models;

namespace Calc.WinForms
{
    internal class AutofacContainer : Controllers.IContainer
    {
        Autofac.IContainer container;

        public AutofacContainer(Autofac.IContainer container)
        {
            this.container = container;
        }

        public IView GetCalcErrorView() => container.ResolveNamed<IView>("CalcError");
        public IView GetLoginErrorView() => container.ResolveNamed<IView>("LoginError");
        public IView GetLogView() => container.ResolveNamed<IView>("Log");
        public IView GetMainView() => container.ResolveNamed<IView>("Main");
        public IModelFacade GetModelFacade() => container.Resolve<IModelFacade>();
        public IViewHandler GetViewHandler() => container.Resolve<IViewHandler>();
    }
}