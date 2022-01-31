﻿using CopyThroughSerialization.Classes;
using System;
using System.Collections.Generic;

namespace CopyThroughSerialization
{
    public class CopyConstructor
    {
        static void Main(string[] args)
        {
            Person john = new Person(new List<string>() { "John", "Smith" }, new Address("London Road", 123));

            Person jane = new Person(john);
            jane.Names[0] = "Jane";
            jane.Address.HouseNumber = 321;

            Console.WriteLine(john);
            Console.WriteLine(jane);
        }
    }
}
