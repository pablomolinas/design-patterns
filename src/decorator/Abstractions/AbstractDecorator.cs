namespace decorator.Abstractions
{
    public abstract class AbstractDecorator : IOperation
    {
        private readonly IOperation _operation;

        public AbstractDecorator(IOperation operation) =>
            _operation = operation;

        public virtual void Exec() =>
            _operation.Exec();
    }
}
