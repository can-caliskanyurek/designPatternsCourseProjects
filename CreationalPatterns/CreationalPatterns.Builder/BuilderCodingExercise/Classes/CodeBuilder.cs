namespace BuilderCodingExercise.Classes
{
    public class CodeBuilder
    {
        private readonly string rootName;
        CodeElement root = new CodeElement();

        public CodeBuilder(string rootName)
        {
            this.rootName = rootName;
            root.Name = rootName;
        }

        public CodeBuilder AddField(string childName, string childText)
        {
            CodeElement element = new CodeElement(childName, childText);
            root.Elements.Add(element);

            return this;
        }

        public override string ToString()
        {
            return root.ToString();
        }

        public void Clear()
        {
            root = new CodeElement() { Name = rootName };
        }
    }
}
