namespace AbstractFactoryDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            var factoryBlue = new BlueFactory();
            var client1 = new Client(factoryBlue);           
            client1.UseShapes();

            var factoryRed = new RedFactory();
            var client2 = new Client(factoryRed);
            client2.UseShapes();
        }
    }
}