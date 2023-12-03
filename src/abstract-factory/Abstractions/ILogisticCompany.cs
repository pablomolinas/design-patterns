namespace abstract_factory.Abstractions
{
    public interface ILogisticCompany
    {
        ITransport CreateTransport(TransportTypes type);
    }
}
