namespace factory_method.models
{
    public class Ship : ITransport
    {
        public void Deliver()
        {
            Console.WriteLine("Transporting by Ship");
        }
    }
}
