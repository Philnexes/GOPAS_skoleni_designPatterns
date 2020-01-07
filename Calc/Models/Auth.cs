using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calc.Models
{
    public class Auth : IAuth
    {
        public bool Login(string user, string pwd)
            => user == "gopas" && pwd == "gopas";
    }
}
