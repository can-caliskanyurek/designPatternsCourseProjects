namespace GenericValueAdapter.Classes
{
    public class Vector2i : VectorOfInt<Vector2i, Dimensions.Two>
    {
        public Vector2i()
        {

        }

        public Vector2i(params int[] values) : base(values)
        {

        }

        public override string ToString()
        {
            return $"{string.Join(", ", data)}";
        }
    }
}
