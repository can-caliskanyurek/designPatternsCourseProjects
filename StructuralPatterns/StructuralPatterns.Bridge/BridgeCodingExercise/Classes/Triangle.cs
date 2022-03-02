using BridgeCodingExercise.Interfaces;

namespace BridgeCodingExercise.Classes
{
    public class Triangle : Shape
    {
        public Triangle(IRenderer renderer) : base(renderer)
        {
            Name = "Triangle";
        }

        public override string ToString()
        {
            return base.ToString();
        }
    }
}
