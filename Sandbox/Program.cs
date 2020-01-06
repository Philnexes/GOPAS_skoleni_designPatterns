using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sandbox
{
    class Program
    {
        static void Main(string[] args)
        {
            var b = new BetterB();
            var a = new A(b);
            a.UseB();
        }
    }
}
