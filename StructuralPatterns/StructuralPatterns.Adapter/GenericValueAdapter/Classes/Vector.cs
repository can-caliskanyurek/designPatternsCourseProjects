using GenericValueAdapter.Interfaces;
using System;

namespace GenericValueAdapter.Classes
{
    public class Vector<TSelf, T, D> 
        where D : IInteger, new()
        where TSelf : Vector<TSelf, T, D>, new()
    {
        protected T[] data;

        public Vector()
        {
            data = new T[new D().Value];
        }

        public Vector(params T[] values)
        {
            int requiredSize = new D().Value;
            data = new T[requiredSize];

            int providedSize = values.Length;

            for (int i = 0; i < Math.Min(requiredSize, providedSize); ++i)
            {
                data[i] = values[i];
            }
        }

        public static TSelf Create(params T[] values)
        {
            TSelf result = new TSelf();

            int requiredSize = new D().Value;
            result.data = new T[requiredSize];

            int providedSize = values.Length;

            for (int i = 0; i < Math.Min(requiredSize, providedSize); ++i)
            {
                result.data[i] = values[i];
            }

            return result;
        }

        public T this[int index]
        {
            get => data[index];
            set => data[index] = value;
        }
    }
}
