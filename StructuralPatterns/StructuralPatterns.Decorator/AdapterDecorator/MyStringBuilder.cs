using System.Text;

namespace AdapterDecorator
{
    public class MyStringBuilder
    {
        private StringBuilder sb = new StringBuilder();

        public static implicit operator MyStringBuilder(string s)
        {
            MyStringBuilder msb = new MyStringBuilder();
            msb.Append(s);
            return msb;
        }

        public static MyStringBuilder operator +(MyStringBuilder msb, string s)
        {
            msb.Append(s);
            return msb;
        }

        public override string ToString()
        {
            return sb.ToString();
        }


        // Reference
        public StringBuilder Append(string? value)
        {
            return sb.Append(value);
        }
    }
}
