using FunctionalBuilder.Classes;
using System;

namespace FunctionalBuilder
{
    public static class FunctionalBuilder
    {
        static void Main(string[] args)
        {
            Person person1 = new PersonBuilderOld().Called("Can").WorksAsA("Software Engineer").Build(); // without inheritence
            Person person2 = new PersonBuilderNew().Called("Resul").WorksAsA("Software Engineer").Build(); // with inheritence

            Console.WriteLine(person1);
            Console.WriteLine(person2);
        }
    }
}
