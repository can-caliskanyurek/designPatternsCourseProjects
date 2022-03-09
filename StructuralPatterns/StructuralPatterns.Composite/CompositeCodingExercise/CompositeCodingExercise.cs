using CompositeCodingExercise.Classes;
using CompositeCodingExercise.Interfaces;
using System.Collections.Generic;

/*
 * The Sum() extension method adds up all the values in a list of IValueContainer elements it gets passed.
 * We can have a single value or a set of values.
 * Complete the implementation of the interfaces so that Sum() begins to work correctly.
 */

namespace CompositeCodingExercise
{
    public class CompositeCodingExercise
    {
        static void Main(string[] args)
        {
            List<IValueContainer> values = new List<IValueContainer>();

            SingleValue singleValue = new SingleValue();
            ManyValues manyValues = new ManyValues();

            values.Add(singleValue);
            values.Add(manyValues);

            values.Sum();
        }
    }
}
