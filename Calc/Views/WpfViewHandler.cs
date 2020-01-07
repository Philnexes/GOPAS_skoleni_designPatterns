using Calc.Controllers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace Calc.Views
{
    public class WpfViewHandler : IViewHandler
    {
        public void ExitApp() => Application.Current.Shutdown();
        public void Hide(IView View) => ((Window)View).Hide();
        public bool IsReady(IView View) => View != null && ((Window)View).IsVisible;
        public void Show(IView View) => ((Window)View).Show();
        public void ShowModal(IView View) => ((Window)View).ShowDialog();
    }
}
