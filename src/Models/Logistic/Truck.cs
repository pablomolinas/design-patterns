using Models.Abstractions;

namespace Models.Logistic
{
    public class Truck : ITransport
    {
        public void Deliver()
        {
            Console.WriteLine("Transporting by Truck");
        }
    }
}
