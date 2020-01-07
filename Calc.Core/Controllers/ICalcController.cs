namespace Calc.Controllers
{
    public interface ICalcController: IController
    {
        IView MainView { get; set; }
        IView LogView { get; set; }
        
        void PlusAction(string x);
        void MinusAction(string x);
        void ShowLogAction();
        void ExitAppAction();
    }
}