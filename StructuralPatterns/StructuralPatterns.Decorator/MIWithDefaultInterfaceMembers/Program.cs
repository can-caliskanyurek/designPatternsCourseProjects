using MIWithDefaultInterfaceMembers.Classes;
using MIWithDefaultInterfaceMembers.Interfaces;

namespace MIWithDefaultInterfaceMembers
{
    public class Program
    {
        static void Main(string[] args)
        {
            Dragon dragon = new Dragon {Age = 15};

            // C#8 default interface methods
            if (dragon is IBird bird)
                bird.Fly();

            if (dragon is ILizard lizard)
                lizard.Crawl();
        }
    }
}
