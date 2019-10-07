using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Action_and_Async
{
    class Program
    {
        //public delegate string Greeting(string result);

        static void Main(string[] args)
        {
            //string entry = Console.ReadLine();
            //string e

            string[] temp = Console.ReadLine().Split(' ');
            string first = temp[0];
            string second = temp[1];

            //Console.WriteLine(SayHello(entry));

            sayGreeting(first, second);

        }

        //public static Greeting SayHello = (result) => "Hello, " + result + "!";

        //public static Greeting SayHello2 = delegate (string result)
        //{
        //    return "Hello, " + result;
        //};

        //public static Greeting SayHello3 = (result) =>
        //{
        //    return "Hello, " + result + "!";
        //};

        //public static string Greet(string result)
        //{
        //    return "Hello, " + result;
        //}
        //public static Greeting SayHello4 = Greet;

        public static Action<string, string> sayGreeting = (result, result2) => Console.WriteLine("Hello, " + result  + " " + result2);


    }
}
