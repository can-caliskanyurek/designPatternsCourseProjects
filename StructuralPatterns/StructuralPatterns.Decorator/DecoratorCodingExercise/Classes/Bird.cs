namespace DecoratorCodingExercise.Classes
{
    public class Bird
    {
        public int Age { get; set; }

        public string Fly()
        {
            if (Age < 5)
            {
                return "Too young to fly";
            } else if (Age >= 5 && Age <= 10)
            {
                return "It can fly";
            } else
            {
                return "Too old to fly";
            }
        }
    }
}
