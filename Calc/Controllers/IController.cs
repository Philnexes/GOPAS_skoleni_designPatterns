using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calc.Controllers
{
    public interface IController
    {
        IView ErrorView { get; set; }
        string Error { get; }
    }
}
