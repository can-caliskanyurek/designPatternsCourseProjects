using BridgeCodingExercise.Classes;
using BridgeCodingExercise.Interfaces;
using System;

/*
 * You are given an example of an inheritance hierarchy
 * which results in Cartesian-product duplication.
 * 
 * Please refactor this hierarchy, giving the base class "Shape"
 * a constructor that takes an interface "IRenderer" defined as
 * 
 *      public interface IRenderer
 *      {
 *          string WhatToRenderAs { get; }
 *      }
 * 
 * as well as "VectorRenderer" and "RasterRenderer" classes.
 * 
 * Each implementer of the Shape abstract class should have a constructor
 * that takes IRenderer such that, subsequently, each constructed object's ToString()
 * operates correctly.
 */

namespace BridgeCodingExercise
{
    public class BridgeCodingExercise
    {
        static void Main(string[] args)
        {
            IRenderer rasterRenderer = new RasterRenderer();
            IRenderer vectorRenderer = new VectorRenderer();
            Square square = new Square(rasterRenderer);
            Triangle triangle = new Triangle(vectorRenderer);

            Console.WriteLine(square.ToString());
            Console.WriteLine(triangle.ToString());
        }
    }
}
