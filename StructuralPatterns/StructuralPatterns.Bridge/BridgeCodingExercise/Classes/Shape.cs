using BridgeCodingExercise.Interfaces;

namespace BridgeCodingExercise.Classes
{
    public abstract class Shape
    {
        protected IRenderer renderer;
        protected string Name { get; set; }

        protected Shape(IRenderer renderer)
        {
            this.renderer = renderer;
        }

        public override string ToString()
        {
            return $"Drawing {Name} as {renderer.WhatToRenderAs}";
        }
    }
}
