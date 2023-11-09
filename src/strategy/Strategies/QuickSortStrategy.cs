using Models;
using strategy.Abstractions;

namespace strategy.Strategies
{
    public class QuickSortStrategy : ISortStrategy
    {
        public void Sort(List<Person> persons)
        {
            persons.Sort((p1, p2) => p1.Age.CompareTo(p2.Age));
        }
    }
}
