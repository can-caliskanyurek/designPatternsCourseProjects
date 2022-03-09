using System;
using System.Collections.Generic;
using System.Text;

namespace GeometricShapes.Classes
{
    public class GraphicObjects
    {
        public virtual string Name { get; set; } = "Group";
        public string Color;

        private Lazy<List<GraphicObjects>> children = new Lazy<List<GraphicObjects>>();
        public List<GraphicObjects> Children => children.Value;

        private void Print(StringBuilder stringBuilder, int depth)
        {
            stringBuilder.Append(new String('*', depth))
                         .Append(string.IsNullOrEmpty(Color) ? string.Empty : $"{Color} ")
                         .AppendLine(Name);

            foreach (GraphicObjects child in Children)
            {
                child.Print(stringBuilder, depth + 1);
            }
        }

        public override string ToString()
        {
            StringBuilder stringBuilder = new StringBuilder();
            Print(stringBuilder, 0);
            return stringBuilder.ToString();
        }
    }
}
