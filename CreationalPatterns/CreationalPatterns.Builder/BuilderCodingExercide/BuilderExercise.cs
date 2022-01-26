using BuilderCodingExercise.Classes;
using System;

namespace BuilderCodingExercise
{
    public class BuilderExercise
    {
        public static void Main(string[] args)
        {
            CodeBuilder codeBuilder = new CodeBuilder("Person").AddField("Name", "string").AddField("Age", "int");

            Console.WriteLine(codeBuilder);
        }
    }
}
