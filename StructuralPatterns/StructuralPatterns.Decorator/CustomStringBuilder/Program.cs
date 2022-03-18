using System;

namespace CustomStringBuilder
{
    public class Program
    {
        static void Main(string[] args)
        {
            CodeBuilder cb = new CodeBuilder();
            cb.AppendLine("class Foo");
            cb.AppendLine("{");
            cb.AppendLine("}");

            Console.WriteLine(cb);
        }
    }
}
