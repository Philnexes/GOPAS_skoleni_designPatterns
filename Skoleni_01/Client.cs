namespace Skoleni_01
{
    public class Client
    {
        public void UseSingleton()
        {
            Singleton.Instance.DoStuff();
        }
        public Client() { }
    }
}