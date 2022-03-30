using BenchmarkDotNet.Attributes;

namespace TextFormatting.Classes
{
    [MemoryDiagnoser]
    public class Benchmarker
    {
        [Benchmark]
        public void FormattedText() // 88 B
        {
            FormattedText ft = new FormattedText("This is a brave new world");
            ft.Capitalize(10, 15);
            ft.Capitalize(7, 12);
        }

        [Benchmark]
        public void BetterFormattedText() // 152 B
        {
            BetterFormattedText bft = new BetterFormattedText("This is a brave new world");
            bft.GetRange(10, 15).Capitalize = true;
            bft.GetRange(7, 12).Capitalize = true;
        }
    }
}
