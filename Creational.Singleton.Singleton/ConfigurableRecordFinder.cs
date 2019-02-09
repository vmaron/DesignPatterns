using System.Collections.Generic;

namespace Creational.Singleton.Singleton
{
    public class ConfigurableRecordFinder
    {
        private readonly IDatabase _database;

        public ConfigurableRecordFinder(IDatabase database)
        {
            this._database = database;
        }

        public int GetTotalPopulation(IEnumerable<string> names)
        {
            var result = 0;

            foreach (var name in names)
                result += _database.GetPopulation(name);

            return result;
        }
    }
}