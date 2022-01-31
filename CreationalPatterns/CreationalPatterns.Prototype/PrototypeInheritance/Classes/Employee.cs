using PrototypeInheritance.Interfaces;
using System.Collections.Generic;

namespace PrototypeInheritance.Classes
{
    public class Employee : Person, IDeepCopyable<Employee>
    {
        public int Salary;

        public Employee()
        {

        }

        public Employee(List<string> names, Address address, int salary) : base(names, address)
        {
            Salary = salary;
        }

        public void CopyTo(Employee target)
        {
            base.CopyTo(target);
            target.Salary = Salary;
        }

        public override string ToString()
        {
            return $"{base.ToString()}\n{nameof(Salary)}: {Salary}";
        }
    }
}
