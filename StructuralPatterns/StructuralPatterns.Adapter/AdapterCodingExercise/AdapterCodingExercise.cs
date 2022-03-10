using AdapterCodingExercise.Classes;
using System;

/*
 * You are given an "IRectangle" interface and an extension method on it. 
 * Try to define a "SquareToRectangleAdapter" that adapts the Square to the IRectangle interface.
 */

namespace AdapterCodingExercise
{
    public class AdapterCodingExercise
    {
        static void Main(string[] args)
        {
            Square square = new Square();
            square.Side = 15;

            SquareToRectangleAdapter adapter = new SquareToRectangleAdapter(square);

            Console.WriteLine(adapter.Area());
        }
    }
}
