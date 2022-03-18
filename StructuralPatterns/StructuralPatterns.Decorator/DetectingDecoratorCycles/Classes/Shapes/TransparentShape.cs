using DetectingDecoratorCycles.Classes.Policies;

namespace DetectingDecoratorCycles.Classes.Shapes
{
    public class TransparentShape : ShapeDecorator<TransparentShape, ThrowOnCyclePolicy>
    {
        private readonly float transparency;

        public TransparentShape(Shape shape, float transparency) : base(shape)
        {
            this.shape = shape;
            this.transparency = transparency;
        }

        public override string AsString() => $"{shape.AsString()} has {transparency * 100.0}% transparency";
    }
}
