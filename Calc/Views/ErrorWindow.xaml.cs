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
    public partial class ErrorWindow<T> : Window, IView
        where T: IController
    {
        IModelFacade model;
        T controller;
        Label errorLabel = new Label();
        public ErrorWindow(IModelFacade model, T controller)
        {
            Content = errorLabel;
            Width = 200;
            Height = 100;
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
