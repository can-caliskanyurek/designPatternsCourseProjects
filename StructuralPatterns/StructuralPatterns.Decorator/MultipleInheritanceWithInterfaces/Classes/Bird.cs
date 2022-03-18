using MultipleInheritanceWithInterfaces.Interfaces;
using System;

namespace MultipleInheritanceWithInterfaces.Classes
{
    public class Bird : IBird
    {
        public int Weight { get; set; }

        public void Fly()
        {
            Console.WriteLine($"Soaring in the sky with weight {Weight}");
        }
    }
}
