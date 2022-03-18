using System;
using DynamicDecoratorComposition.Classes;

namespace DynamicDecoratorComposition
{
    public class Program
    {
        static void Main(string[] args)
        {
            Square square = new Square(1.23f);
            Console.WriteLine(square.AsString());

            ColoredShape redSquare = new ColoredShape(square, "red");
            Console.WriteLine(redSquare.AsString());

            TransparentShape redHalfTransparentShape = new TransparentShape(redSquare, 0.5f);
            Console.WriteLine(redHalfTransparentShape.AsString());
        }
    }
}
