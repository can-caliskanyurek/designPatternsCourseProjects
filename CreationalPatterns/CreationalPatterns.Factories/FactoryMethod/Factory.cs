using Factory.Classes;
using System;

namespace FactoryMethod
{
    public class Factory
    {
        static void Main(string[] args)
        {
            Point point = Point.Factory.NewPolarPoint(1.0, Math.PI / 2);

            Console.WriteLine(point);
        }
    }
}
