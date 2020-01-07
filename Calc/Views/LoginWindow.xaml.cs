using Calc.Controllers;
using Calc.Models;
using System.Windows;

namespace Calc.Views
{
    /// <summary>
    /// Interaction logic for LoginWindow.xaml
    /// </summary>
    public partial class LoginWindow : Window, IView
    {
        IModelFacade model;
        ILoginController controller;
        
        public LoginWindow(IModelFacade model, ILoginController controller)
        {
            this.model = model;
            this.controller = controller;
            controller.LoginView = this;
            InitializeComponent();
        }

        public void UpdateView() { }

        private void loginButton_Click(object sender, RoutedEventArgs e)
        {
            controller.LogInAction(userTextBox.Text, pwdTextBox.Text);
        }
    }
}
