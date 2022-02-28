using System.Collections.Generic;
using System.Text;

namespace BuilderCodingExercise.Classes
{
    public class CodeElement
    {
        private const int indentSize = 2;
        string indentation = new string(' ', indentSize);

        public string Name, Type;
        public List<CodeElement> Elements = new List<CodeElement>();

        public CodeElement() { }

        public CodeElement(string name, string type)
        {
            Name = name;
            Type = type;
        }

        private string ToStringImpl()
        {
            StringBuilder sb = new StringBuilder();

            if (string.IsNullOrWhiteSpace(Type))
            {
                sb.AppendLine($"public class {Name}");
                sb.AppendLine("{");
            }

            foreach (CodeElement element in Elements)
            {
                sb.Append($"{indentation}");
                sb.AppendLine($"public {element.Type} {element.Name};");
            }

            sb.AppendLine("}");

            return sb.ToString();
        }

        public override string ToString()
        {
            return ToStringImpl();
        }
    }
}
