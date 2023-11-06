using System.Text.Json;

namespace prototype_deep
{
    public class Program
    {
        public static void Main()
        {
            var person = new Person()
            {
                Name = "Person1",
                Age = 10,
                Address = new Address()
                {
                    Street = "Street 1",
                    Number = 222
                }
            };

            var person2 = (Person)person.Clone();
            person2.Name = "Person2";
            person2.Age = 55;
            person2.Address.Street = "Street 2";

            Console.WriteLine(JsonSerializer.Serialize(person));
            Console.WriteLine(JsonSerializer.Serialize(person2));
        }
    }
}