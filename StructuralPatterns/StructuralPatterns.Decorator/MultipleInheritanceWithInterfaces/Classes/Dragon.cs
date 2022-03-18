using MultipleInheritanceWithInterfaces.Interfaces;

namespace MultipleInheritanceWithInterfaces.Classes
{
    public class Dragon : IBird, ILizard
    {
        private Bird bird = new Bird();
        private Lizard lizard = new Lizard();
        private int weight;

        public int Weight
        {
            get { return weight; }
            set
            {
                weight = value;
                bird.Weight = value;
                lizard.Weight = value;
            }
        }

        public void Fly()
        {
            bird.Fly();
        }

        public void Crawl()
        {
            lizard.Crawl();
        }
    }
}
