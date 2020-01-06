using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryMethodDemo
{
    class A
    {
        protected virtual B CreateB() => new B();
        public void UseB()
        {
            var b = CreateB();
            b.Use();
        }
    }
}
