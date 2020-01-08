using Calc.Controllers;
using Calc.Models;
using Ninject;
using System;

namespace Calc
{
    class NinjectContainer : IContainer
    {
        IKernel kernel;
        
        public NinjectContainer(IKernel kernel)
        {
            this.kernel = kernel;
        }

        public IView GetCalcErrorView() => kernel.Get<IView>("CalcError");
        public IView GetLoginErrorView() => kernel.Get<IView>("LoginError");
        public IView GetLogView() => kernel.Get<IView>("Log");
        public IView GetMainView() => kernel.Get<IView>("Main");
        public IModelFacade GetModelFacade() => kernel.Get<IModelFacade>();
        public IViewHandler GetViewHandler() => kernel.Get<IViewHandler>();
        
    }
}
