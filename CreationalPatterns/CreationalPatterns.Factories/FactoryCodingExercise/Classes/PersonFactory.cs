using System;
using System.Collections.Generic;
using System.Text;

namespace FactoryCodingExercise.Classes
{
    public class PersonFactory
    {
        private readonly List<WeakReference<Person>> persons = new List<WeakReference<Person>>();

        public Person CreatePerson(string name)
        {
            Person person = new Person()
            {
                Id = persons.Count,
                Name = name
            };

            persons.Add(new WeakReference<Person>(person));
            return person;
        }

        public string Info
        {
            get
            {
                StringBuilder sb = new StringBuilder();

                foreach (WeakReference<Person> reference in persons)
                {
                    if (reference.TryGetTarget(out Person person))
                    {
                        sb.AppendLine($"{person.Id}: {person.Name}");
                    }
                }

                return sb.ToString();
            }
        }
    }
}
