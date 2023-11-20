using chain_of_responsability;

namespace Application
{
    public class App
    {
        static void Main()
        {
            var handlerA = new HandlerA();
            var handlerB = new HandlerB();
            var handlerC = new HandlerC();

            handlerA.SetHandler(handlerB);
            handlerB.SetHandler(handlerC);

            handlerA.Handle();
            //handlerA.Handle();
            //handlerA.Handle();
        }
    }
}