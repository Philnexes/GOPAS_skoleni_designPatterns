using Autofac;
using Ninject;
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
            /*var container = new StandardKernel();
            container.Bind<IB>().To<B>();
            var a1 = container.Get<A>();
            var a2 = container.Get<A>();
            a1.UseB();
            a2.UseB();
            Console.WriteLine(a1.B == a2.B);*/
            var builder = new ContainerBuilder();
            builder.RegisterType<A>();
            builder.RegisterType<B>().As<IB>();
            var container = builder.Build();

            var a1 = container.Resolve<A>();
            var a2 = container.Resolve<A>();

            Console.WriteLine(a1.B == a2.B);
        }
    }
}