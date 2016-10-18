using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Anagrams
{
    class FindAnagrams
    {
        string[] textFile;
        
        public void ExecuteAnagramCheck()
        {
            ReadFromTextFile();
            

            foreach (string textFile in textFile)
            {
                Console.WriteLine("\t" + textFile);
            }
        }
        public void ReadFromTextFile()
        {
            textFile = File.ReadAllLines(@"C:\scrabbleDictionary.txt");
        }
        public string AlphabetizeString(string textFile)
        {
            char[] a = textFile.ToCharArray();
            Array.Sort(a);
            return new string(a);
        }
    }
}
