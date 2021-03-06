namespace Builder.Classes
{
    public class HtmlBuilder
    {
        private readonly string rootName;
        HtmlElement root = new HtmlElement();

        public HtmlBuilder(string rootName)
        {
            this.rootName = rootName;
            root.Name = rootName;
        }

        public void AddChild(string childName, string childText)
        {
            HtmlElement element = new HtmlElement(childName, childText);
            root.Elements.Add(element);
        }

        // Fluent Builder
        //public HtmlBuilder AddChild(string childName, string childText)
        //{
        //    HtmlElement element = new HtmlElement(childName, childText);

        //    root.Elements.Add(element);

        //    return this;
        //}

        public override string ToString()
        {
            return root.ToString();
        }

        public void Clear()
        {
            root = new HtmlElement() { Name = rootName };
        }
    }
}
