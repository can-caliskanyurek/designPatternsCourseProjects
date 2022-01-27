using FactoryCodingExercise.Classes;
using System;

// You are given a class called Person. The person has two fileds: Id and Name.
// Please implement a non-static PersonFactory that has a CreatePerson() method that takes a person's name.
// The Id of the person should be set as a 0-based index of the object created.
// So, the first person the factory makes should have Id = 0, second Id = 1, and so on.

namespace FactoryCodingExercise
{
    public class FactoryCodingExercise
    {
        public static void Main(string[] args)
        {
            PersonFactory factory = new PersonFactory();
            factory.CreatePerson("Can");
            factory.CreatePerson("Metin");
            Console.WriteLine(factory.Info);
        }
    }
}
