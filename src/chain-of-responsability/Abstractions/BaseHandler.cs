namespace chain_of_responsability.Abstractions
{
    public abstract class BaseHandler
    {
        protected BaseHandler _sucessor;

        public void SetHandler(BaseHandler sucessor)
        {
            _sucessor = sucessor;
        }

        public virtual void Handle()
        {
            Console.WriteLine("Execute base handler.");
        }
    }
}
