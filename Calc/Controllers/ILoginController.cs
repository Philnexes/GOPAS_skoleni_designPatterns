using Calc.Views;

namespace Calc.Controllers
{
    public interface ILoginController: IController
    {
        IView LoginView { get; set; }
        void LogInAction(string user, string pwd);
    }
}
