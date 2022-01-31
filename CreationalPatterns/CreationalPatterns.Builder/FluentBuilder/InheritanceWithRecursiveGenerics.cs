using FluentBuilder.Classes;
using System;

namespace FluentBuilder
{
    public class InheritanceWithRecursiveGenerics
    {
        static void Main(string[] args)
        {
            Person person = Person.New.Called("Can")
                                      .WorkAsA("Software Engineer")
                                      .Build();

            Console.WriteLine(person);
        }
    }
}
