using Calc.Controllers;
using Calc.Models;
using System.Windows;

namespace Calc.Views
{
    /// <summary>
    /// Interaction logic for LogWindow.xaml
    /// </summary>
    public partial class LogWindow : Window, IView
    {
        IModelFacade model;
        ICalcController controller;
        public LogWindow(IModelFacade model, ICalcController controller)
        {
            this.model = model;
            this.controller = controller;
            InitializeComponent();
        }

        public void UpdateView()
        {
            itemsListBox.Items.Clear();
            foreach (var item in model.LogItems)
                itemsListBox.Items.Add(item);
        }
    }
}
