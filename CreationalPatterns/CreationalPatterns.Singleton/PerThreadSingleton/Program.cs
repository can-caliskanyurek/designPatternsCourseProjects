using System;
using System.Threading.Tasks;

namespace PerThreadSingleton
{
    public class Program
    {
        static void Main(string[] args)
        {
            Task t1 = Task.Factory.StartNew(() =>
            {
                Console.WriteLine("t1: " + PerThreadSingleton.Instance.Id);
            });

            Task t2 = Task.Factory.StartNew(() =>
            {
                Console.WriteLine("t2: " + PerThreadSingleton.Instance.Id);
                Console.WriteLine("t2: " + PerThreadSingleton.Instance.Id);
            });

            Task.WaitAll(t1, t2);
        }
    }
}
