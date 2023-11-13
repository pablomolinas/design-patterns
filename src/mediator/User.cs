using mediator.Abstractions;

namespace mediator
{
    public abstract class User
    {
        protected IMediator _mediator;
        protected string Name;

        public User(IMediator mediator, string name)
        {
            _mediator = mediator;
            Name = name;
        }

        public abstract void Send(string message);
        public abstract void Receive(string message);

        public string GetUserName() => Name;
    }
}
