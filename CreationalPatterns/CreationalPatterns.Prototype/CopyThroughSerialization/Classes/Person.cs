using System;
using System.Collections.Generic;

namespace CopyThroughSerialization.Classes
{
    //[Serializable]
    public class Person
    {
        public List<string> Names;
        public Address Address;

        public Person()
        {
               
        }

        public Person(List<string> names, Address address)
        {
            Names = names;
            Address = address;
        }

        public override string ToString()
        {
            return $"{nameof(Names)}: {string.Join(" ", Names)}\n{nameof(Address)}:\n\t{Address}";
        }
    }
}
