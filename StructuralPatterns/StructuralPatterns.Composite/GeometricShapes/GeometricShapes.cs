using GeometricShapes.Classes;
using System;

namespace GeometricShapes
{
    public class GeometricShapes
    {
        static void Main(string[] args)
        {
            GraphicObjects drawing = new GraphicObjects { Name = "My Drawing" };
            drawing.Children.Add(new Square { Color = "Red" });
            drawing.Children.Add(new Circle { Color = "Yellow" });

            GraphicObjects group = new GraphicObjects();
            group.Children.Add(new Circle { Color = "Blue" });
            group.Children.Add(new Square { Color = "Blue" });

            drawing.Children.Add(group);

            Console.WriteLine(drawing);
        }
    }
}
