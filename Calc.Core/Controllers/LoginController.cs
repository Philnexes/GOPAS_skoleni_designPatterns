using Calc.Models;

namespace Calc.Controllers
{
    public class LoginController : ILoginController
    {
        IContainer container;
        IModelFacade model;
        IViewHandler viewHandler;

        public LoginController(IContainer container)
        {
            this.container = container;
            model = container.GetModelFacade();
            viewHandler = container.GetViewHandler();
        }

        public IView LoginView { get; set; }
        public IView MainView { get; set; }
        public IView ErrorView { get; set; }

        public string Error { get; private set; }

        public void LogInAction(string user, string pwd)
        {
            if (model.Login(user, pwd))
            {
                //((Window)LoginView).Hide();
                viewHandler.Hide(LoginView);
                if (MainView == null) MainView = container.GetMainView();
                //((Window)MainView).Show();
                viewHandler.Show(MainView);
                Error = "";
            }
            else
            {
                if (!viewHandler.IsReady(ErrorView)) //ErrorView == null || !((Window)ErrorView).IsVisible)
                    ErrorView = container.GetLoginErrorView();
                Error = "Invalid login";
                ErrorView.UpdateView();
                //((Window)ErrorView).ShowDialog();
                viewHandler.ShowModal(ErrorView);
            }
        }
    }
}
