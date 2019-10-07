using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Action_Delegate
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> names = new List<string>();
            names.Add("Mel");
            names.Add("Art");

            names.ForEach(Print);

            //foreach (var item in names)
            //{
            //    Print(item);
            //}

            names.ForEach(delegate (string name)
                {
                    Console.WriteLine(name);
                });

        }


        private static void Print(string s)
        {
            Console.WriteLine(s);
        }


        
    }
}
