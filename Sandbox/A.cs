using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sandbox
{
    class A
    {
        protected virtual IB CreateB() => new B();

        public void UseB()
        {
            CreateB().UseB();
        }
    }
}
