using PrototypeInheritance.Classes;
using System;
using System.Collections.Generic;

namespace PrototypeInheritance
{
    public class PrototypeInheritance
    {
        static void Main(string[] args)
        {
            Employee john = new Employee();
            john.Names = new List<string>() { "John", "Doe" };
            john.Address = new Address()
            {
                StreetName = "London Road",
                HouseNumber = 123
            };
            john.Salary = 144000;

            Employee copy = john.DeepCopy();
            copy.Names[1] = "Smith";
            copy.Address.HouseNumber = 321;
            copy.Salary = 300000;

            Console.WriteLine(john);
            Console.WriteLine(copy);
        }
    }
}
