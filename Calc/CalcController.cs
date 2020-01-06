namespace Calc
{
    class CalcController : ICalcController
    {
        ICalculator model;

        public CalcController(ICalculator model)
        {
            this.model = model;
        }

        public MainWindow MainView { get; set; }

        public void PlusAction(string x)
        {
            var dx = double.Parse(x);
            model.Plus(dx);
            MainView.UpdateView();
        }
    }
}
