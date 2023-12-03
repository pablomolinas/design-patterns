namespace abstract_factory.models.companyB
{
    public class MotorcycleB : MotorCycle
    {
        public override void Deliver()
        {
            Console.Write("Deliver Company B: ");
            base.Deliver();
        }
    }
}
