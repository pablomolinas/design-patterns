using abstract_factory.Abstractions;

namespace abstract_factory.models
{
    public class MotorCycle : ITransport
    {
        public virtual void Deliver()
        {
            Console.WriteLine("Transport by MotorCycle");
        }
    }
}
