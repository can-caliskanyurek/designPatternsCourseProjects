using System;

namespace FlyweightCodingExercise
{
    public class Program
    {
        static void Main(string[] args)
        {
            Sentence sentence = new Sentence("hello world");
            sentence[1].Capitalize = true;
            Console.WriteLine(sentence);
        }
    }
}
