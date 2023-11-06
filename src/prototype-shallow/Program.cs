namespace prototype_shallow
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var person = new Person() { Name = "Person1", Age = 32, Country = "Argentina" };
            var person2 = (Person)person.Clone();

            person2.Name = "Person2";
            person2.Age = 45;

            Console.WriteLine($"Name: {person.Name}, Age: {person.Age}, Country: {person.Country}");
            Console.WriteLine($"Name: {person2.Name}, Age: {person2.Age}, Country: {person.Country}");
        }
    }
}