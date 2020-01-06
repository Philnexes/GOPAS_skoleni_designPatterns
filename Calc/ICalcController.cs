namespace Calc
{
    public interface ICalcController
    {
        void PlusAction(string x);

        MainWindow MainView { get; set; }
    }
}