using PrototypeCodingExercise.Classes;
using System;

namespace PrototypeCodingExercise
{
    public class PrototypeCodingExercise
    {
        static void Main(string[] args)
        {
            Point start = new Point(5, 5);
            Point end = new Point(6, 6);
            Line line1 = new Line(start, end);

            Line line2 = line1.DeepCopy();
            line2.Start.X = 9;
            line2.Start.Y = 9;

            Console.WriteLine(line1);
            Console.WriteLine(line2);
        }
    }
}
