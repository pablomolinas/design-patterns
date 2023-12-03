using strategy.Abstractions;

namespace strategy.Strategies
{
    public class BubbleSortStrategy : ISortStrategy
    {
        public void Sort(List<Person> persons)
        {
            for (int i = 0; i < persons.Count - 1; i++)
            {
                for (int j = 0; j < persons.Count - i - 1; j++)
                {
                    if (persons[j].Age > persons[j + 1].Age)
                    {
                        Person temp = persons[j];
                        persons[j] = persons[j + 1];
                        persons[j + 1] = temp;
                    }
                }
            }
        }
    }
}
