namespace StaticDecoratorComposition.Classes
{
    public class Circle : Shape
    {
        private float radius;

        // cannot be implemented
        public float Radius
        {
            get => radius;
            set => radius = value;
        }

        public Circle() : this(0.0f)
        {
            
        }

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
