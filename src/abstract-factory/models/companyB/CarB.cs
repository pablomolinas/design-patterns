namespace abstract_factory.models.companyB
{
    public class CarB : Car
    {
        public override void Deliver()
        {
            Console.Write("Deliver Company B: ");
            base.Deliver();
        }
    }
}
