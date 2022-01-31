using PrototypeInheritance.Interfaces;
using System.Collections.Generic;

namespace PrototypeInheritance.Classes
{
    public class Person : IDeepCopyable<Person>
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

        public void CopyTo(Person target)
        {
            target.Names = new List<string>(Names);
            target.Address = Address.DeepCopy();
        }

        public override string ToString()
        {
            return $"{nameof(Names)}: {string.Join(" ", Names)}\n{nameof(Address)}:\n\t{Address}";
        }
    }
}
