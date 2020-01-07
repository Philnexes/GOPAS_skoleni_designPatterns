using System.Windows;

namespace Calc
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        ICalculator calc;
        ICalcController controller;
        public MainWindow(ICalculator calc, ICalcController controller)
        {
            this.calc = calc;
            this.controller = controller;
            controller.MainView = this;
            InitializeComponent();
        }

        public void UpdateView()
        {
            resultLabel.Content = calc.Result;
        }

        private void plusButton_Click(object sender, RoutedEventArgs e)
        {
            //var x = double.Parse(inputTextBox.Text);
            //calc.Plus(x);
            //resultLabel.Content = calc.Result;
            controller.PlusAction(inputTextBox.Text);
        }

        private void minusButton_Click(object sender, RoutedEventArgs e)
        {
            controller.MinusAction(inputTextBox.Text);
        }
    }
}
