using ProtectionProxy.Interfaces;
using System;

namespace ProtectionProxy.Classes
{
    public class Car : ICar
    {
        public void Drive()
        {
            Console.WriteLine("Car being driven");
        }
    }
}
