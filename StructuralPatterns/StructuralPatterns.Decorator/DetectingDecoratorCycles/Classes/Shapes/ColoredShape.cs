﻿using DetectingDecoratorCycles.Classes.Policies;
using System.Linq;
using System.Text;

namespace DetectingDecoratorCycles.Classes.Shapes
{
    public class ColoredShape : ShapeDecorator<ColoredShape, AbsorbCyclePolicy>
    {
        private readonly string color;

        public ColoredShape(Shape shape, string color) : base(shape)
        {
            this.shape = shape;
            this.color = color; 
        }

        public override string AsString()
        {
            StringBuilder sb = new StringBuilder($"{shape.AsString()}");

            if (policy.ApplicationAllowed(types[0], types.Skip(1).ToList()))
                sb.Append($" has the color {color}");

            return sb.ToString();
        }
    }
}
