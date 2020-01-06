using System;

namespace AbstractFactoryDemo
{
    class BlueCircle : ICircle
    {
        public void UseCircle()
        {
            Console.WriteLine("Blue circle used");
        }
    }
}