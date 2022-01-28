using AbstractFactory.Interfaces;
using System;

namespace AbstractFactory.Classes
{
    internal class Coffee : IHotDrink
    {
        public void Consume()
        {
            Console.WriteLine("This coffee is sensational!");
        }
    }
}
