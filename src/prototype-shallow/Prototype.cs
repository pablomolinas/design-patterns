namespace prototype_shallow
{
    public class Prototype : ICloneable
    {
        public object Clone()
        {
            return this.MemberwiseClone();
        }
    }
}
