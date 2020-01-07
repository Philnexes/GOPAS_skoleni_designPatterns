using Calc.Controllers;
using Calc.Models;
using System.Windows;

namespace Calc.Views
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window, IView
    {
        IModelFacade model;
        ICalcController controller;
        public MainWindow(IModelFacade model, ICalcController controller)
        {
            this.model = model;
            this.controller = controller;
            controller.MainView = this;
            InitializeComponent();
        }

        public void UpdateView()
        {
            resultLabel.Content = model.Result;
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
