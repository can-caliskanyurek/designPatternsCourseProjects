using System.IO;

namespace SingleResponsibilityPrinciple.Classes
{
    // handles the responsibility of persisting the objects
    public class Persistence
    {
        public void SaveToFile(Journal journal, string filename, bool overwrite = false)
        {
            if (overwrite || !File.Exists(filename))
                File.WriteAllText(filename, journal.ToString());
        }
    }
}
