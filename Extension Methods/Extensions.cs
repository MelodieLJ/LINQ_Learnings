using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Extension_Methods
{
    public static class Extensions
    {
        //write an extension method where if the number passed in is anything other than 1, append an 's' to the string. Otherwise, return the string unmodified
        public static string MakePlural(this string s, int i)
        {
            if (i == 1)
            {
                return s;
            }
            else
                return s + "s";
        }
        
    }
}
