using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactoryDemo
{
    class Client
    {
        IShapeFactory factory;

        public Client(IShapeFactory factory)
        {
            this.factory = factory ?? throw new ArgumentNullException(nameof(factory));
        }

        public void UseShapes()
        {
            factory.CreateCircle().UseCircle();
            factory.CreateSquare().UseSquare();
        }
    }
}