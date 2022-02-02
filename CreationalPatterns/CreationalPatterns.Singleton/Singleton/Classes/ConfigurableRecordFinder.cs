using Singleton.Interfaces;
using System.Collections.Generic;

namespace Singleton.Classes
{
    public class ConfigurableRecordFinder
    {
        private readonly IDatabase _database;

        public ConfigurableRecordFinder(IDatabase database)
        {
            _database = database;
        }

        public int GetTotalPopulation(IEnumerable<string> names)
        {
            int result = 0;

            foreach (string name in names)
                result += _database.GetPopulation(name);

            return result;
        }
    }
}
