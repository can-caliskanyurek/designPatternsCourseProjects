using System;

namespace AdapterDecorator
{
    public class Program
    {
        static void Main(string[] args)
        {
            MyStringBuilder s = "hello ";
            s += "world!";
            Console.WriteLine(s);
        }
    }
}
