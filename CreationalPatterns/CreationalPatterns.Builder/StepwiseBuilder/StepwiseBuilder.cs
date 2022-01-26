using StepwiseBuilder.Classes;
using System;

namespace StepwiseBuilder
{
    public enum CarType
    {
        Sedan, Crossover
    }
    public class StepwiseBuilder
    {
        public static void Main(string[] args)
        {
            Car car = CarBuilder.Create().OfType(CarType.Crossover).WithWheels(18).Build();

            Console.WriteLine(car);
        }
    }
}
