using Calc.Controllers;
using System.Windows.Forms;

namespace Calc.WinForms
{
    internal class WinFormsViewHandler : IViewHandler
    {
        public void ExitApp() => Application.Exit();
        public void Hide(IView view) => ((Form)view).Hide();
        public bool IsReady(IView view)
            => view != null && !((Form)view).IsDisposed;

        public void Show(IView view) => ((Form)view).Show();
        public void ShowModal(IView view) => ((Form)view).ShowDialog();
    }
}