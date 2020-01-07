using Calc.Views;

namespace Calc.Controllers
{
    public interface ICalcController
    {
        IView MainView { get; set; }
        IView LogView { get; set; }
        IView ErrorView { get; set; }
        string Error { get; }

        void PlusAction(string x);
        void MinusAction(string x);
        void ShowWindowAction();
    }
}