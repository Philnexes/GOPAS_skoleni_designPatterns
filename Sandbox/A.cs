using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sandbox
{
    class A
    {
        IB b;

        public A(IB b)
        {
            this.b = b;
        }

        public void UseB()
        {
            b.UseB();
        }
    }
}
