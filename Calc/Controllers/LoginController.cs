using Calc.Models;
using Ninject;
using System.Windows;

namespace Calc.Controllers
{
    public class LoginController : ILoginController
    {
        IKernel container;
        IModelFacade model;
        
        public LoginController(IKernel container)
        {
            this.container = container;
            model = container.Get<IModelFacade>();
        }

        public IView LoginView { get; set; }
        public IView MainView { get; set; }
        public IView ErrorView { get; set; }

        public string Error { get; private set; }

        public void LogInAction(string user, string pwd)
        {
            if(model.Login(user, pwd))
            {
                ((Window)LoginView).Hide();
                if (MainView == null) MainView = container.Get<IView>("Main");
                ((Window)MainView).Show();
                Error = "";
            }
            else
            {
                if (ErrorView == null || !((Window)ErrorView).IsVisible)
                    ErrorView = container.Get<IView>("LoginError");
                Error = "Invalid login";
                ErrorView.UpdateView();
                ((Window)ErrorView).ShowDialog();
            }
        }
    }
}
