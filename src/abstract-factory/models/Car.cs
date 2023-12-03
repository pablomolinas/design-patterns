using abstract_factory.Abstractions;

namespace abstract_factory.models
{
    public class Car : ITransport
    {
        public virtual void Deliver()
        {
            Console.WriteLine("Transport by Car");
        }
    }
}
