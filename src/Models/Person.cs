using Models.@enum;

namespace Models
{
    public class Person
    {
        public string Name { get; set; }
        public int Age { get; set; }
        public Countries Country { get; set; }
    }
}
