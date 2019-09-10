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
            string[] subjects = { "art", "programming", "music", "chemistry" };
            //Linq Mthod Query
            var query = from subject in subjects
                        where subject.Contains('m')
                        select subject;
            //Query Syntax
            var linqQuery = subjects.Where(x => x.Contains('c'));

            //Query execution
            foreach (var subject in linqQuery)
            {
                Console.WriteLine(subject + " ");
            }
        }
    }
}
