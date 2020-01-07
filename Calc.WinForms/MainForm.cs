using Calc.Controllers;
using System.Windows.Forms;

namespace Calc.WinForms
{
    public partial class MainForm : Form, IView
    {
        public MainForm()
        {
            InitializeComponent();
        }

        public void UpdateView()
        {
            //throw new System.NotImplementedException();
        }
    }
}
