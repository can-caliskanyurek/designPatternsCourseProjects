using DependencyInversionPrinciple.Interfaces;
using System.Collections.Generic;
using System.Linq;

namespace DependencyInversionPrinciple.Classes
{
    // low-level
    public class Relationships : IRelationshipBrowser
    {
        private List<(Person, Relationship, Person)> relations
            = new List<(Person, Relationship, Person)>();

        public void AddParentAndChild(Person parent, Person child)
        {
            relations.Add((parent, Relationship.Parent, child));
            relations.Add((child, Relationship.Child, parent));
        }

        public IEnumerable<Person> FindAllChildrenOf(string name)
        {
            return relations.Where(r => r.Item1.Name == name && r.Item2 == Relationship.Parent).Select(r => r.Item3);
        }

        //public List<(Person, Relationship, Person)> Relations => relations;
    }
}
