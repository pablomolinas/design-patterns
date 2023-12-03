using factory_method.models;

namespace factory_method
{
    public static class TransportFactory
    {
        public static ITransport GetTransport(TransportTypes type)
        {
            switch (type)
            {
                case TransportTypes.Truck:
                    return new Truck();
                case TransportTypes.Ship:
                    return new Ship();
                default:
                    throw new NotImplementedException("Transport not implemented");
            }
        }
    }
}
