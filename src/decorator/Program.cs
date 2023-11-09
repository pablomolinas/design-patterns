using decorator;

namespace app
{
    public class Program
    {
        public static void Main() 
        {
            var operation = new ConcreteDecorator(new Operation());

            operation.Exec();
        }
    }
}