using decorator.Abstractions;

namespace decorator
{
    public class ConcreteDecorator : AbstractDecorator
    {
        public ConcreteDecorator(IOperation operation) : base(operation) { }

        public override void Exec()
        {
            Console.WriteLine("Task before Exec");

            base.Exec();

            Console.WriteLine("Task After Exec");
        }
    }
}
