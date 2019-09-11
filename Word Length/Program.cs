using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Word_Length
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] words = { "Learning", "how", "to", "create", "linq", "queries" };

            var query = from word in words
                        where word.Length == 2
                        select word;

            var query2 = words.Where(x => x.Length == 3);

            foreach (var word in query)
            {
                Console.WriteLine(word + " ");
            }

            foreach (var word in query2)
            {
                Console.WriteLine(word + " ");
            }
        }
    }
}
