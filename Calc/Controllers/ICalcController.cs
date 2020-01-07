namespace Calc.Controllers
{
    public interface ICalcController
    {
        void PlusAction(string x);
        void MinusAction(string x);

        IView MainView { get; set; }
    }
}