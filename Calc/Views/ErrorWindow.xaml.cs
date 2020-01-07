using Calc.Controllers;
using Calc.Models;
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
using System.Windows.Shapes;

namespace Calc.Views
{
    /// <summary>
    /// Interaction logic for ErrorWindow.xaml
    /// </summary>
    public partial class ErrorWindow : Window, IView
    {
        IModelFacade model;
        ICalcController controller;
        
        public ErrorWindow(IModelFacade model, ICalcController controller)
        {
            InitializeComponent();
            this.model = model;
            this.controller = controller;
            controller.ErrorView = this;
        }

        public void UpdateView()
        {
            errorLabel.Content = controller.Error;
        }
    }
}
