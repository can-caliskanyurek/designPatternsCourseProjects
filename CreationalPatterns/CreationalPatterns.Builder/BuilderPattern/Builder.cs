using BuilderPattern.Classes;
using System;

namespace BuilderPattern
{
    public class Builder
    {
        static void Main(string[] args)
        {
            HtmlBuilder htmlBuilder = new HtmlBuilder("ul");
            htmlBuilder.AddChild("li", "hello");
            htmlBuilder.AddChild("li", "world");

            Console.WriteLine(htmlBuilder.ToString());
        }
    }
}
