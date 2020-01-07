using Calc.Controllers;
using Calc.Models;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Media;

namespace Calc.Views
{
    /// <summary>
    /// Interaction logic for ErrorWindow.xaml
    /// </summary>
    public partial class ErrorWindow<T> : Window, IView
        where T : IController
    {
        IModelFacade model;
        T controller;
        Label errorLabel = new Label();
        public ErrorWindow(IModelFacade model, T controller)
        {
            errorLabel.Foreground = Brushes.Red;
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
