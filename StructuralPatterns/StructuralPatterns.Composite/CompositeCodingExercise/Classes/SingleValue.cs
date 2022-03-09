using CompositeCodingExercise.Interfaces;
using System.Collections;
using System.Collections.Generic;

namespace CompositeCodingExercise.Classes
{
    public class SingleValue : IValueContainer
    {
        public int Value;

        public IEnumerator<int> GetEnumerator()
        {
            yield return Value;
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }
    }
}
