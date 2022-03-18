namespace DecoratorCodingExercise.Classes
{
    public class Dragon
    {
        private Bird bird = new Bird();
        private Lizard lizard = new Lizard();
        private int age;

        public int Age
        {
            get => age;
            set
            {
                age = value;
                bird.Age = value;
                lizard.Age = value;
            }
        }

        public string Fly()
        {
            return bird.Fly();
        }

        public string Crawl()
        {
            return lizard.Crawl();
        }
    }
}
