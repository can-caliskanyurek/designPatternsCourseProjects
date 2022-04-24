using ProxyCodingExercise.Interfaces;

namespace ProxyCodingExercise.Classes
{
    public class Person : IPerson
    {
        public int Age { get; set; }

        public string Drink()
        {
            return "drinking";
        }

        public string Drive()
        {
            return "driving";
        }

        public string DrinkAndDrive()
        {
            return "dead";
        }
    }
}