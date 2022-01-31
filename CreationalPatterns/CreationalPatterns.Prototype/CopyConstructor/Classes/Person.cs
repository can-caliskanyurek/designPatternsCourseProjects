using System.Collections.Generic;

namespace CopyThroughSerialization.Classes
{
    public class Person
    {
        public List<string> Names;
        public Address Address;

        public Person(List<string> names, Address address)
        {
            Names = names;
            Address = address;
        }

        public Person(Person person)
        {
            Names = new List<string>(person.Names);
            Address = new Address(person.Address);
        }

        public override string ToString()
        {
            return $"{nameof(Names)}: {string.Join(" ", Names)}\n{nameof(Address)}:\n\t{Address}";
        }
    }
}
