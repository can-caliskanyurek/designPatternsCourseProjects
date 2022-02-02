using System;

/*
 * Since implementing a singleton is easy, you have a different challenge: 
 * Write a method called IsSingleton().
 * This method takes a factory method that returns an object 
 * and it's up to you to determine whether or not that object is a singleton instance.
 */

namespace SingletonCodingExercise
{
    public class SingletonTester
    {
        public static bool IsSingleton(Func<object> func)
        {
            var object1 = func.Invoke();
            var object2 = func.Invoke();

            if (object1 == object2)
            {
                return true;
            }

            return false;
        }
    }
    public class SingletonCodingExercise
    {
        static void Main(string[] args)
        {
            // ...
        }
    }
}
