using AdapterCodingExercise.Interfaces;

namespace AdapterCodingExercise.Classes
{
    public class SquareToRectangleAdapter : IRectangle
    {
        private readonly Square _square;
        public SquareToRectangleAdapter(Square square)
        {
            _square = square;
        }

        public int Width => _square.Side;

        public int Height => _square.Side;
    }
}
