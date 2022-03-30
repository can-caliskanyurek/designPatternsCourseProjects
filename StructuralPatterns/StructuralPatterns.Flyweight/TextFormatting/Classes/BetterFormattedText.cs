using System.Collections.Generic;
using System.Text;

namespace TextFormatting.Classes
{
    public class BetterFormattedText
    {
        private string plainText;
        private List<TextRange> formatting = new List<TextRange>();

        public BetterFormattedText(string plainText)
        {
            this.plainText = plainText;
        }

        public class TextRange
        {
            public int Start, End;
            public bool Capitalize, Bold, Italic;

            public bool Covers(int position)
            {
                return position >= Start && position <= End;
            }
        }

        public TextRange GetRange(int start, int end)
        {
            TextRange range = new TextRange { Start = start, End = end };
            formatting.Add(range);
            return range;
        }

        public override string ToString()
        {
            var sb = new StringBuilder();

            for (var i = 0; i < plainText.Length; i++)
            {
                char character = plainText[i];

                foreach (var range in formatting)
                {
                    if (range.Covers(i) && range.Capitalize)
                        character = char.ToUpper(character);

                    sb.Append(character);
                }
            }

            return sb.ToString();
        }
    }
}