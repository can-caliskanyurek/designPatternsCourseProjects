using BridgeCodingExercise.Interfaces;

namespace BridgeCodingExercise.Classes
{
    public class Square : Shape
    {
        public Square(IRenderer renderer) : base(renderer)
        {
            Name = "Square";
        }

        public override string ToString()
        {
            return base.ToString();
        }
    }
}
