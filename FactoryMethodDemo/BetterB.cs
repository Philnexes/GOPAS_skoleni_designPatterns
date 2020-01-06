using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryMethodDemo
{
    class BetterB : B
    {
        public override void Use()
        {
            Console.WriteLine("BetterB used");
        }
    }
}
