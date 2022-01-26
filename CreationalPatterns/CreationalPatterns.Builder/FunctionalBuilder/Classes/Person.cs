namespace FunctionalBuilder.Classes
{
    public class Person
    {
        public string Name, Position;

        public override string ToString()
        {
            return $"Person {Name} is working as a {Position}";
        }
    }
}
