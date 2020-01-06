using System;

namespace AbstractFactoryDemo
{
    class RedCircle : ICircle
    {
        public void UseCircle()
        {
            Console.WriteLine("Red circle used");
        }
    }
}