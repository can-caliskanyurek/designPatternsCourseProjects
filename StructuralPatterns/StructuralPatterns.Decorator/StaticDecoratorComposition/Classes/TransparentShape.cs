namespace StaticDecoratorComposition.Classes
{
    public class TransparentShape<T> : Shape where T : Shape, new() 
    {
        private float transparency;
        private T shape = new T();

        public TransparentShape() : this(0.0f)
        {
            
        }

        public TransparentShape(float transparency)
        {
            this.transparency = transparency;
        }

        public override string AsString() => $"{shape.AsString()} has {transparency * 100.0f}% transparency";
    }
}
