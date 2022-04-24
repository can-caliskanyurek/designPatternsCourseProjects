using System;
using ProxyCodingExercise.Classes;
using ProxyCodingExercise.Interfaces;

namespace ProxyCodingExercise
{
    /* 
     * You are given the "Person" class and asked to write a "ResponsiblePerson" proxy that does the following:
     *      - Allows person to drink unless they are younger than 18 (in that case, return "too young")
     *      - Allows person to drive unless they are younger than 16 (otherwise, "too young")
     *      - In case of driving while drinking, returns "dead"
     */

    public class Program
    {
        static void Main(string[] args)
        {
            IPerson person = new ResponsiblePerson(new Person { Age = 17 });

            Console.WriteLine(person.Drink());
            Console.WriteLine(person.Drive());
            Console.WriteLine(person.DrinkAndDrive());
        }
    }
}
