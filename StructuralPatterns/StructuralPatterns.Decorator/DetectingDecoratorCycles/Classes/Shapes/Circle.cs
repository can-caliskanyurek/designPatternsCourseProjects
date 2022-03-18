namespace DetectingDecoratorCycles.Classes.Shapes
{
    public class Circle : Shape
    {
        private float radius;

        public Circle(float radius)
        {
            this.radius = radius;
        }

        public void Resize(float factor)
        {
            radius *= factor;
        }

        public override string AsString() => $"A circle with radius {radius}";
    }
}
