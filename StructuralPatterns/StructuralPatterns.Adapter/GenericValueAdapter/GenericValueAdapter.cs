using GenericValueAdapter.Classes;
using System;

namespace GenericValueAdapter
{
    public class GenericValueAdapter
    {
        static void Main(string[] args)
        {
            Vector2i vector1 = new Vector2i(1, 2);

            vector1[0] = 0;

            Vector2i vector2 = new Vector2i(3, 2);

            Vector2i sum = vector1 + vector2;

            Console.WriteLine(sum);

            Vector3f vector = Vector3f.Create(3.5f, 2.3f, 1);

            Console.WriteLine(vector);
        }
    }
}
