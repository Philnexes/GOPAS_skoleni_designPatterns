using Calc.Controllers;
using Calc.Models;
using System.Windows.Forms;

namespace Calc.WinForms
{
    public partial class LoginForm : Form, IView
    {
        IModelFacade model;
        ILoginController controller;
        public LoginForm(IModelFacade model, ILoginController controller)
        {
            this.model = model;
            this.controller = controller;
            controller.LoginView = this;
            InitializeComponent();
        }

        public void UpdateView()
        {
            
        }

        private void loginButton_Click(object sender, System.EventArgs e)
        {
            controller.LogInAction(userTextBox.Text, pwdTextBox.Text);
        }
    }
}
