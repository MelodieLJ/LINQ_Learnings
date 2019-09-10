using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Short_words
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] words = { "Hello", "World", "Queries", "Lambdas", "Programming"};

            //Query syntax
            var shortWords = from word in words
                             where word.Length <= 5
                             select word;
            //Method syntax
            var longWords = words.Where(w => w.Length >= 6);

            foreach (var word in shortWords)
            {
                Console.WriteLine(word);
            }

            //foreach (var word in longWords)
            //{
            //    Console.WriteLine(word);
            //}
        }
    }
}
