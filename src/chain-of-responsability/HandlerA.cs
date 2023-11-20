using chain_of_responsability.Abstractions;

namespace chain_of_responsability
{
    public class HandlerA : BaseHandler
    {
        public override void Handle()
        {
            Console.WriteLine("Handle request A");

            if (_sucessor != null)
                _sucessor.Handle();
        }
    }
}
