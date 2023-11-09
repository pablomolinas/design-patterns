using decorator.Abstractions;

namespace decorator
{
    public class Operation : IOperation
    {
        public void Exec()
        {
            Console.WriteLine("Executing origin operation");
        }
    }
}
