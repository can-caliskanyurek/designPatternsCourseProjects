namespace DecoratorCodingExercise.Classes
{
    public class Lizard
    {
        public int Age { get; set; }

        public string Crawl()
        {
            if (Age < 5)
            {
                return "It can crawl";
            }
            else if (Age >= 5 && Age <= 10)
            {
                return "It can walk on its wings";
            }
            else
            {
                return "Too old to crawl";
            }
        }
    }
}
