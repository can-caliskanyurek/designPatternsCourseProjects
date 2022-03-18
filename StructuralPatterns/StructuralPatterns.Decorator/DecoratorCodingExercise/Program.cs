using System;
using DecoratorCodingExercise.Classes;

/*
 * The following code scenario shows a "Dragon" which is both a "Bird" and a "Lizard"
 * Complete the Dragon's interface (no need to extract IBird or ILizard).
 * Take special care when implementing the "Age" property.
 */

namespace DecoratorCodingExercise
{
    public class Program
    {
        static void Main(string[] args)
        {
            Dragon dragon = new Dragon();
            dragon.Age = 8;
            
            Console.WriteLine(dragon.Fly());
            Console.WriteLine(dragon.Crawl());
        }
    }
}
