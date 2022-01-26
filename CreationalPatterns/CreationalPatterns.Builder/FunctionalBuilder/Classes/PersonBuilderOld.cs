using System;
using System.Collections.Generic;
using System.Linq;

namespace FunctionalBuilder.Classes
{
    // WITHOUT INHERITENCE
    public sealed class PersonBuilderOld
    {
        private readonly List<Func<Person, Person>> actions = new List<Func<Person, Person>>();

        // not suitable for open-closed principle
        //public PersonBuilderOld Called(string name) => Do(person => person.Name = name);
        //public PersonBuilderOld WorksAsA(string position) => Do(person => person.Position = position);

        public PersonBuilderOld Do(Action<Person> action) => AddAction(action);

        public Person Build() => actions.Aggregate(new Person(), (p, f) => f(p));

        private PersonBuilderOld AddAction(Action<Person> action)
        {
            actions.Add(p =>
            {
                action(p);
                return p;
            });

            return this;
        }
    }
}
