using mediator.Abstractions;

namespace mediator
{
    public class ConcreteUser : User
    {
        public ConcreteUser(IMediator mediator, string name) : base(mediator, name) { }

        public override void Receive(string message) =>
            Console.WriteLine($"\t{Name} (Received Message) > {message}");

        public override void Send(string message)
        {
            Console.WriteLine($"{Name} (Sending Message) > {message}\n");
            _mediator.SendMessage(this, message);
        }
    }
}
