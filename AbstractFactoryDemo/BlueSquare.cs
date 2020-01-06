using System;

namespace AbstractFactoryDemo
{
    class BlueSquare : ISquare
    {
        public void UseSquare()
        {
            Console.WriteLine("Blue square used");
        }
    }
}