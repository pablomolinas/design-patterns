using abstract_factory.Abstractions;

namespace abstract_factory.models.companyB
{
    public class CompanyB : ILogisticCompany
    {
        public ITransport CreateTransport(TransportTypes type)
        {
            return type switch
            {
                TransportTypes.Car => new CarB(),
                TransportTypes.Motorcycle => new MotorcycleB(),
                _ => throw new NotImplementedException()
            };
        }
    }
}
