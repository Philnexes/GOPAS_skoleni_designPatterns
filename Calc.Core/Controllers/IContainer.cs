using Calc.Models;

namespace Calc.Controllers
{
    public interface IContainer
    {
        IModelFacade GetModelFacade();
        IViewHandler GetViewHandler();
        IView GetCalcErrorView();
        IView GetLogView();
        IView GetMainView();
        IView GetLoginErrorView();
    }
}