using state;

namespace Application
{
    public class App
    {
        public static void Main(string[] args)
        {
            var context = new Context();

            context.Request();
            context.Request();
            context.Request();
        }
    }
}