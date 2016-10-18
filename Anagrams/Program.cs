using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Anagrams
{
    class Program
    {
        static void Main(string[] args)
        {
            FindAnagrams findAnagrams = new FindAnagrams();
            findAnagrams.ExecuteAnagramCheck();

            Console.WriteLine("END OF PROGRAM");
            Console.ReadKey();
        }
    }
}
