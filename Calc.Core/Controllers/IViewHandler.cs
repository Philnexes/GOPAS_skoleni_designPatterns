namespace Calc.Controllers
{
    public interface IViewHandler
    {
        void Hide(IView view);
        void Show(IView view);
        bool IsReady(IView view);
        void ShowModal(IView view);
        void ExitApp();
    }
}