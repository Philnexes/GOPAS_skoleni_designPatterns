namespace AbstractFactoryDemo
{
    interface IShapeFactory
    {
        ISquare CreateSquare();
        ICircle CreateCircle();
    }
}