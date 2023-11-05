namespace Singleton
{
    public static class Application
    {
        public static void Main(string[] args)
        {
            var instance1 = Singleton.Instance();
            var instance2 = Singleton.Instance();
            var instance3 = Singleton.Instance();
        }
    }
}