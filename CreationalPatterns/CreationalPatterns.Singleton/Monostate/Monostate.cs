using System;

namespace Monostate
{
    public class Monostate
    {
        static void Main(string[] args)
        {
            CEO ceo = new CEO();

            ceo.Name = "Adam Smith";
            ceo.Age = 55;

            CEO ceo2 = new CEO();

            Console.WriteLine(ceo2);
        }
    }
}
