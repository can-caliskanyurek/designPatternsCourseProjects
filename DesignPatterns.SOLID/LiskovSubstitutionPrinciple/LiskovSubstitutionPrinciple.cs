using LiskovSubstitutionPrinciple.Classes;
using System;

namespace LiskovSubstitutionPrinciple
{
    public class LiskovSubstitutionPrinciple
    {
        static void Main(string[] args)
        {
            static int Area(Rectangle rect) => rect.Width * rect.Height;

            // it works fine
            Rectangle rectangle = new Rectangle();
            Console.WriteLine($"{rectangle} has area {Area(rectangle)}");

            // it works fine
            Square square = new Square();
            square.Width = 4;
            Console.WriteLine($"{square} has area {Area(square)}");

            // it should work fine too.
            Rectangle _square = new Square();
            _square.Width = 4;
            Console.WriteLine($"{_square} has area {Area(_square)}");
        }
    }
}
