namespace AbstractFactoryDemo
{
    class RedFactory : IShapeFactory
    {
        public ICircle CreateCircle() => new RedCircle();

        public ISquare CreateSquare() => new RedSquare();
    }
}