using Models;
using strategy.Abstractions;
using strategy.Strategies;

namespace strategy
{
    class Program
    {
        static void Main(string[] args)
        {
            var persons = GetPersons();

            //ISortStrategy strategy = new BubbleSortStrategy();
            ISortStrategy strategy = new QuickSortStrategy();

            strategy.Sort(persons);

            foreach (var person in persons)
                Console.WriteLine($"Name: {person.Name}, Age: {person.Age}");

        }

        private static List<Person> GetPersons()
        {
            var persons = new List<Person>();
            var random = new Random();

            for (var i = 0; i < 100; i++)
            {
                persons.Add(new Person
                {
                    Name = $"Person{i}",
                    Age = random.Next(5, 99)
            });
            }

            return persons;
        }
    }
}