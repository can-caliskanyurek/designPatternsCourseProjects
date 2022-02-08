using GenericValueAdapter.Interfaces;

namespace GenericValueAdapter.Classes
{
    public class VectorOfInt<TSelf, D> : Vector<TSelf, int, D>
        where D : IInteger, new()
        where TSelf : Vector<TSelf, int, D>, new()
    {
        public VectorOfInt()
        {

        }

        public VectorOfInt(params int[] values) : base(values)
        {

        }

        public static TSelf operator +(VectorOfInt<TSelf, D> leftSide, VectorOfInt<TSelf, D> rightSide)
        {
            TSelf result = new TSelf();
            int dim = new D().Value;

            for (int i = 0; i < dim; i++)
            {
                result[i] = leftSide[i] + rightSide[i];
            }

            return result;
        }
    }
}
