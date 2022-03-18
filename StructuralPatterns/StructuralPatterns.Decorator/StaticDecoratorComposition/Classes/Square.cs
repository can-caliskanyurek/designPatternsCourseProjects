namespace StaticDecoratorComposition.Classes
{
    public class Square : Shape
    {
        private float side;

        public Square() : this(0.0f)
        {

        }

        public Square(float side)
        {
            this.side = side;
        }

        public override string AsString() => $"A square with side {side}";
    }
}
