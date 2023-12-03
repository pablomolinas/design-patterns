namespace abstract_factory.models.companyA
{
    public class CarA : Car
    {
        public override void Deliver()
        {
            Console.Write("Deliver Company A: ");
            base.Deliver();
        }
    }
}
