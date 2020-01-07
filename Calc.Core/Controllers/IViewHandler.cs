namespace Calc.Controllers
{
    public interface IViewHandler
    {
        void Hide(IView View);
        void Show(IView View);
        bool IsReady(IView View);
        void ShowModal(IView View);
        void ExitApp();
    }
}