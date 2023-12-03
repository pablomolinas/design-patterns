namespace factory_method.models
{
    public class Truck : ITransport
    {
        public void Deliver()
        {
            Console.WriteLine("Transporting by Truck");
        }
    }
}
