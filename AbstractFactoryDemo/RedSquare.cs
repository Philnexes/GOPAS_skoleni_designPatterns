using System;

namespace AbstractFactoryDemo
{
    class RedSquare : ISquare
    {
        public void UseSquare()
        {
            Console.WriteLine("Red square used");
        }
    }
}