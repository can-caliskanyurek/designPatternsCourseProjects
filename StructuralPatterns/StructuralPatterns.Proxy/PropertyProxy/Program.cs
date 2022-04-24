using PropertyProxy.Classes;

namespace PropertyProxy
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Creature c = new Creature();
            c.Agility = 10;
            c.Agility = 10;
        }
    }
}
