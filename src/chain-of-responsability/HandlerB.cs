using chain_of_responsability.Abstractions;

namespace chain_of_responsability
{
    public class HandlerB : BaseHandler
    {
        public override void Handle()
        {
            Console.WriteLine("Handle request B");

            if (_sucessor != null)
                _sucessor.Handle();
        }
    }
}
