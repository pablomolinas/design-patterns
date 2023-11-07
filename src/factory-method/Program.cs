using factory_method;
using Models;

namespace Program
{
    public class Program
    {
        public static void Main()
        {
            TransportFactory
                .GetTransport(TransportTypes.Truck)
                .Deliver();

            TransportFactory
                .GetTransport(TransportTypes.Ship)
                .Deliver();
        }
    }
}