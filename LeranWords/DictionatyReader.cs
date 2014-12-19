using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;

namespace LeranWords
{
    class DictionatyReader
    {
        private const char WORD_SEPARATER = '=';
        private const string ROWS_SEPARATER = "\n";

        internal static Dictionary<string, string> GetWords(string selectedDict)
        {
            Dictionary<string, string> words = new Dictionary<string, string>();
            foreach (var line in File.ReadLines(selectedDict))
            {
                string polishWord = line.Split(WORD_SEPARATER)[0];
                string russianWord = line.Split(WORD_SEPARATER)[1];
                words.Add(polishWord, russianWord);
            }
            return words;
        }
    }
}
