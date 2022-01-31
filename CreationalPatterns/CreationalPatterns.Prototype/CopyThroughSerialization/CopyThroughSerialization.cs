using CopyThroughSerialization.Classes;
using System;
using System.Collections.Generic;

namespace CopyThroughSerialization
{
    public class CopyThroughSerialization
    {
        static void Main(string[] args)
        {
            Person john = new Person(new List<string>() { "John", "Smith" }, new Address("London Road", 123));

            Person jane = john.DeepCopyXml();
            jane.Names[0] = "Jane";
            jane.Address.HouseNumber = 321;

            Console.WriteLine(john);
            Console.WriteLine(jane);
        }
    }
}
