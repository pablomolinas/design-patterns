namespace Singleton
{
    public class Singleton
    {
        private static Singleton _instance = null;
        protected Singleton()
        {
            Console.WriteLine("Instance created!");
        }

        public static Singleton Instance()
        {
            if (_instance is null)
                _instance = new Singleton();

            return _instance;
        }
    }
}
