using Calc.Controllers;
using System.Windows;

namespace Calc.Views
{
    public class WpfViewHandler : IViewHandler
    {
        public void ExitApp() => Application.Current.Shutdown();
        public void Hide(IView view) => ((Window)view).Hide();
        public bool IsReady(IView view) =>
            view != null && ((Window)view).IsVisible;
        public void Show(IView view) => ((Window)view).Show();
        public void ShowModal(IView view) => ((Window)view).ShowDialog();
    }
}
