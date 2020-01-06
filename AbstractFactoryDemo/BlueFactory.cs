namespace AbstractFactoryDemo
{
    class BlueFactory : IShapeFactory
    {
        public ICircle CreateCircle() => new BlueCircle();

        public ISquare CreateSquare() => new BlueSquare();
    }
}