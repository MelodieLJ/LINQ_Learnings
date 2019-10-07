using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Delegate_Declarations
{
    class Program
    {
        // A delegate is simply a reference to a method
        //The Greetings type below is a reference to a method that tales a string and returns a string
        public delegate string Greetings(string result);

        static void Main(string[] args)
        {
            string entry = Console.ReadLine();
            //Console.WriteLine("First Example: " + greetingsFunc1(entry));
            //Console.WriteLine("Second Example: " + greetingsFunc2(entry));
            //Console.WriteLine("Third Example: " + greetingsFunc3(entry));
            //Console.WriteLine("Fourth Example: " + greetingsFunc4(entry));

            NewGreeting((result) => result + entry);
        }
        //The Greetings type can be used to declare variables in several ways:

        //
        public static string Greet(string result)
        {
            return "Hello, " + result + "!";
        }
        public static Greetings greetingsFunc1 = Greet;

        public static Greetings greetingsFunc2 = delegate (string result)
        {
            return "Hello, " + result + "!";
        };

        //Lamba expressions are a more efficient way of defining a delegate
        public static Greetings greetingsFunc3 = (result) =>
        {
            return "Hello, " + result + "!";
        };

        //If the only statement in the lamba expression is the return statement, the shortened form below can be used
        public static Greetings greetingsFunc4 = (result) => "Hello, " + result + "!";

        //Passing a delegate to a method
        //NewGreetings takes a delegate as an argument - the passed in delegate must match the Greetings typr, it must accept a string parameter and return a string
        public static void NewGreeting(Greetings func)
        {
            string result = func("Hello, ");
            Console.WriteLine(result);
        }

    }
}