using chain_of_responsability.Abstractions;

namespace chain_of_responsability
{
    public class HandlerC : BaseHandler
    {
        public override void Handle()
        {
            Console.WriteLine("Handle request C");

            if (_sucessor != null)
                _sucessor.Handle();
        }
    }
}
