using DetectingDecoratorCycles.Classes.Shapes;
using System;

namespace DetectingDecoratorCycles
{
    public class Program
    {
        static void Main(string[] args)
        {
            Circle circle = new Circle(2);

            ColoredShape colored1 = new ColoredShape(circle, "red");
            ColoredShape colored2 = new ColoredShape(colored1, "blue");

            Console.WriteLine(colored2.AsString());
        }
    }
}
