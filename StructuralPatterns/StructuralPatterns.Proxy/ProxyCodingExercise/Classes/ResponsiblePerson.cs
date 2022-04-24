using ProxyCodingExercise.Interfaces;

namespace ProxyCodingExercise.Classes
{
    public class ResponsiblePerson : IPerson
    {
        private readonly Person person;

        public ResponsiblePerson(Person person)
        {
            this.person = person;
        }

        public int Age
        {
            get => person.Age;
            set => person.Age = value;
        }


        public string Drink()
        {
            if (Age >= 18)
            {
                return person.Drink();
            } else
            {
                return "too young";
            }
        }

        public string Drive()
        {
            if (Age >= 16)
            {
                return person.Drive();
            }
            else
            {
                return "too young";
            }
        }

        public string DrinkAndDrive()
        {
            return person.DrinkAndDrive();
        }
    }
}