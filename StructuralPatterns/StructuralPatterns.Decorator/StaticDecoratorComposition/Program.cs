using StaticDecoratorComposition.Classes;
using System;

namespace StaticDecoratorComposition
{
    public class Program
    {
        static void Main(string[] args)
        {
            ColoredShape<Square> redSquare = new ColoredShape<Square>();
            Console.WriteLine(redSquare.AsString());

            TransparentShape<ColoredShape<Circle>> circle = new TransparentShape<ColoredShape<Circle>>(0.4f);
            Console.WriteLine(circle.AsString());

            // we cannot access or assign a value for Radius
            // thus C# is not suitable for static decorator composition
                // circle.Radius;
        }
    }
}
