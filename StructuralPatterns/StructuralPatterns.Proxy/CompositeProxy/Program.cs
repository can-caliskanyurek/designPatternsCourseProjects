using CompositeProxy.Classes;

namespace CompositeProxy
{
    public class Program
    {
        static void Main(string[] args)
        {
            Creature[] creatures = new Creature[100];

            foreach (Creature c in creatures)
            {
                c.X++; // not memory-efficient
            }

            Creatures creatures2 = new Creatures(100);
            foreach (Creatures.CreatureProxy c in creatures2)
            {
                c.X++;
            }
        }
    }
}
