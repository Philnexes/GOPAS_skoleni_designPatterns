namespace Calc
{
    public interface ICalcController
    {
        void PlusAction(string x);
        void MinusAction(string x);

        MainWindow MainView { get; set; }
    }
}