using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryMethodDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            A a = new A();
            a.UseB();
        }
    }
}