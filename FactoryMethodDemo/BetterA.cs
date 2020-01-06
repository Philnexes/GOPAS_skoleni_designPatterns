using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryMethodDemo
{
    class BetterA : A
    {
        protected override B CreateB()
        {
            return new BetterB();
        }
    }
}
