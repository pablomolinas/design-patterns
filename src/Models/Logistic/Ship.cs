using Models.Abstractions;

namespace Models.Logistic
{
    public class Ship : ITransport
    {
        public void Deliver()
        {
            Console.WriteLine("Transporting by Ship");
        }
    }
}
