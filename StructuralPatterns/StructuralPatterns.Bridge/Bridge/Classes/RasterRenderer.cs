using Bridge.Interfaces;
using System;

namespace Bridge.Classes
{
    public class RasterRenderer : IRenderer
    {
        public void RenderCircle(float radius)
        {
            Console.WriteLine($"Drawing pixels for circle width radius {radius}");
        }
    }
}
