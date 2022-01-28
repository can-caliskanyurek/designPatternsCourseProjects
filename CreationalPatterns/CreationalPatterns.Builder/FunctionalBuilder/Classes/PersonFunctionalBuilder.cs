using System;
using System.Collections.Generic;
using System.Linq;

namespace FunctionalBuilder.Classes
{
    public abstract class PersonFunctionalBuilder<TSubject, TSelf> 
        where TSelf : PersonFunctionalBuilder<TSubject, TSelf>
        where TSubject : new()
    {
        private readonly List<Func<Person, Person>> actions = new List<Func<Person, Person>>();

        public TSelf Do(Action<Person> action) => AddAction(action);

        public Person Build() => actions.Aggregate(new Person(), (t, f) => f(t));

        private TSelf AddAction(Action<Person> action)
        {
            actions.Add(t =>
            {
                action(t);
                return t;
            });

            return (TSelf)this;
        }
    }
}
