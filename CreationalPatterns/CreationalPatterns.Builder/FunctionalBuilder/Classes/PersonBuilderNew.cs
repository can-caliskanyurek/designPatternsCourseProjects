using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FunctionalBuilder.Classes
{
    // WITH INHERITENCE
    public sealed class PersonBuilderNew : PersonFunctionalBuilder<Person, PersonBuilderNew>
    {
        public PersonBuilderNew Called(string name) => Do(person => person.Name = name);
        public PersonBuilderNew WorksAsA(string position) => Do(person => person.Position = position);
    }
}
