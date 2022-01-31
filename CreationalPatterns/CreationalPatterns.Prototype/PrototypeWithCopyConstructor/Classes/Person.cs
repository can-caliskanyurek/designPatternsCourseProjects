using CopyThroughSerialization.Interfaces;
using System.Collections.Generic;

namespace CopyThroughSerialization.Classes
{
    public class Person : IPrototype<Person>
    {
        public List<string> Names;
        public Address Address;

        public Person(List<string> names, Address address)
        {
            Names = names;
            Address = address;
        }

        public Person DeepCopy()
        {
            return new Person(new List<string>(Names), Address.DeepCopy());
        }

        public override string ToString()
        {
            return $"{nameof(Names)}: {string.Join(" ", Names)}\n{nameof(Address)}:\n\t{Address}";
        }
    }
}
