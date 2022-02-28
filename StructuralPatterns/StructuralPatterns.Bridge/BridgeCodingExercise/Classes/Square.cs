using BridgeCodingExercise.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
