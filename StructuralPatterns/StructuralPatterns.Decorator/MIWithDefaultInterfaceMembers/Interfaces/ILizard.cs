using System;

namespace MIWithDefaultInterfaceMembers.Interfaces
{
    public interface ILizard : ICreature
    {
        void Crawl()
        {
            if (Age < 10)
            {
                Console.WriteLine("I am crawling");
            }
        }
    }
}
