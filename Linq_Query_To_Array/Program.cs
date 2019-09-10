using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Linq_Query_To_Array
{
    class Program
    {
        static void Main(string[] args)
        {
            //Data Source
            string[] subjects = { "Art", "Programming", "Music", "Chemistry" };
            //Linq Query
            var query = from subject in subjects
                        where subject.Contains('m')
                        select subject;

            //Query execution
            foreach (var subject in query)
            {
                Console.WriteLine(subject + " ");
            }
        }
    }
}
