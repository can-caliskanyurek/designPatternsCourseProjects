using System;
using System.Collections.Generic;
using VectorRasterDemo.Classes;

namespace VectorRasterDemo
{
    public class VectorRasterDemo
    {
        private static readonly List<VectorObject> vectorObjects = new List<VectorObject>
        {
            new VectorRectangle(1, 1, 10, 10),
            new VectorRectangle(3, 3, 6, 6)
        };

        public static void DrawPoint(Point p)
        {
            Console.Write(".");
        }

        private static void Draw()
        {
            foreach (VectorObject vectorObject in vectorObjects)
            {
                foreach (Line line in vectorObject)
                {
                    LineToPointAdapter adapter = new LineToPointAdapter(line);

                    foreach (Point point in adapter)
                    {
                        DrawPoint(point);
                    }

                    Console.WriteLine();
                }
            }
        }

        static void Main(string[] args)
        {
            Draw();

            Console.WriteLine();

            Draw();
        }
    }
}
