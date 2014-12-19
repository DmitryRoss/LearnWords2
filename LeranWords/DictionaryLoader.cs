using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;

namespace LeranWords
{    
    class DictionaryLoader
    {
        private const string FOLDER_WITH_DICTIONARIES_NAME = "Dictionaries";

        internal static Dictionary<string, int> GetDictionaries()
        {
            String[] allfiles = System.IO.Directory.GetFiles(FOLDER_WITH_DICTIONARIES_NAME, "*.*", System.IO.SearchOption.AllDirectories);
            int count = 0;
            Dictionary<string, int> dictionaries = new Dictionary<string, int>();
            foreach (string file in allfiles)
            {
                count++;
                dictionaries.Add(file, count);
            }
            return dictionaries;
        }
    }
}
