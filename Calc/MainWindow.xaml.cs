using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

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
    }
}
