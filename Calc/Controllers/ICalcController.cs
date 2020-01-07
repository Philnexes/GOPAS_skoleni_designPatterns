namespace Calc.Controllers
{
    public interface ICalcController
    {
        IView MainView { get; set; }
        IView LogView { get; set; }

        void PlusAction(string x);
        void MinusAction(string x);
        void ShowWindowAction();
    }
}