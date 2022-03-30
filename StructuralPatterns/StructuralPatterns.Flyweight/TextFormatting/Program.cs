using System;
using BenchmarkDotNet.Running;
using TextFormatting.Classes;

namespace TextFormatting
{
    public class Program
    {
        static void Main(string[] args)
        {
            // Compile on release mode to compare memory usage.
            // BenchmarkRunner.Run<Benchmarker>();

            FormattedText ft = new FormattedText("This is a brave new world");
            ft.Capitalize(10, 15);
            Console.WriteLine(ft);

            BetterFormattedText bft = new BetterFormattedText("This is a brave new world");
            bft.GetRange(10, 15).Capitalize = true;
            Console.WriteLine(bft);
        }
    }
}
