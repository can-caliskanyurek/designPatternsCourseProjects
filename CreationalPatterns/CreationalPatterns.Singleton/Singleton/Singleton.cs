using Singleton.Classes;
using System;

namespace Singleton
{
    public class Singleton
    {
        static void Main(string[] args)
        {
            SingletonDatabase db = SingletonDatabase.Instance;

            string city = "Tokyo";

            Console.WriteLine($"{city} has population {db.GetPopulation(city)}");
        }
    }
}
