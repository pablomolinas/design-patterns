
using abstract_factory;
using abstract_factory.Abstractions;
using abstract_factory.models.companyA;
using abstract_factory.models.companyB;

namespace Program
{
    public class Program
    {
        public static void Main()
        {
            ILogisticCompany companyA = new CompanyA();
            ILogisticCompany companyB = new CompanyB();

            TestTransports(companyA);
            TestTransports(companyB);
        }

        public static void TestTransports(ILogisticCompany logisticCompany)
        {
            logisticCompany
                .CreateTransport(TransportTypes.Car)
                .Deliver();

            logisticCompany
                .CreateTransport(TransportTypes.Motorcycle)
                .Deliver();
        }
    }
}