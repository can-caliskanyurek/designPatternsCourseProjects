using System;
using MultipleInheritanceWithInterfaces.Classes;

namespace MultipleInheritanceWithInterfaces
{
    public class Program
    {
        static void Main(string[] args)
        {
            Dragon dragon = new Dragon();
            dragon.Weight = 123;
            dragon.Fly();
            dragon.Crawl();
        }
    }
}
