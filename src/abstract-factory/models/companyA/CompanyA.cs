using abstract_factory.Abstractions;

namespace abstract_factory.models.companyA
{
    public class CompanyA : ILogisticCompany
    {
        public ITransport CreateTransport(TransportTypes type)
        {
            return type switch
            {
                TransportTypes.Car => new CarA(),
                TransportTypes.Motorcycle => new MotorcycleA(),
                _ => throw new NotImplementedException()
            };
        }
    }
}
