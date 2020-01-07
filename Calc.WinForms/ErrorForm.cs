using Calc.Controllers;
using Calc.Models;
using System.Windows.Forms;

namespace Calc.WinForms
{
    public partial class ErrorForm<T> : Form, IView
        where T: IController
    {
        IModelFacade model;
        T controller;

        public ErrorForm(IModelFacade model, T controller)
        {
            this.model = model;
            this.controller = controller;
            controller.ErrorView = this;
            InitializeComponent();
        }

        public void UpdateView()
        {
            errorLabel.Text = controller.Error;
        }
    }
}
