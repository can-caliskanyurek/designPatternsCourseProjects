using DependencyInversionPrinciple.Classes;
using DependencyInversionPrinciple.Interfaces;
using System;
using System.Linq;

namespace DependencyInversionPrinciple
{
    public enum Relationship
    {
        Parent, Child, Sibling
    }
    public class Research
    {
        //public Research(Relationships relationships)
        //{
        //    var relations = relationships.Relations;

        //    foreach (var relation in relations.Where(r => r.Item1.Name == "John" && r.Item2 == Relationship.Parent))
        //    {
        //        Console.WriteLine($"John has a child called { relation.Item3.Name }");
        //    }
        //}

        public Research(IRelationshipBrowser browser)
        {
            foreach (var person in browser.FindAllChildrenOf("John"))
            {
                Console.WriteLine($"John has a child called { person.Name }");
            }
        }

        public static void Main(string[] args)
        {
            Person parent = new Person() { Name = "John" };
            Person child1 = new Person() { Name = "Chris" };
            Person child2 = new Person() { Name = "Mary" };

            Relationships relationships = new Relationships();

            relationships.AddParentAndChild(parent, child1);
            relationships.AddParentAndChild(parent, child2);

            new Research(relationships);
        }
    }
}
