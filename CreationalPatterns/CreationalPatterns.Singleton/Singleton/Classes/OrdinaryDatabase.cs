using MoreLinq;
using Singleton.Interfaces;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace Singleton.Classes
{
    public class OrdinaryDatabase : IDatabase
    {
        private Dictionary<string, int> capitals;

        public OrdinaryDatabase()
        {
            Console.WriteLine("Initializing Database");

            capitals = File.ReadAllLines(
                    Path.Combine(new FileInfo(typeof(IDatabase).Assembly.Location).DirectoryName, "capitals.txt")
                )
                .Batch(2) // MoreLinq package
                .ToDictionary(
                    list => list.ElementAt(0).Trim(),
                    list => int.Parse(list.ElementAt(1))
                 );
        }

        public int GetPopulation(string name)
        {
            return capitals[name];
        }
    }
}
