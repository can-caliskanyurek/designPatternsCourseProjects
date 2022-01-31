using SingleResponsibilityPrinciple.Classes;
using System;

namespace SingleResponsibilityPrinciple
{
    public class SingleResponsibilityPrinciple
    {
        static void Main(string[] args)
        {
            var j = new Journal();
            j.AddEntry("Coding is fun.");
            j.AddEntry("I love reading thriller novels.");
            Console.WriteLine(j);

            var p = new Persistence();
            var filename = @"C:\Users\LENOVO\source\repos\DesignPatterns.SOLID\SingleResponsibilityPrinciple\journal.txt";
            p.SaveToFile(j, filename, false);
        }
    }
}
