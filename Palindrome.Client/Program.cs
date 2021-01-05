using System;
using Palindrome.Domain;

namespace Palindrome.Client
{
    class Program
    {
        static void Main(string[] args)
        {
            User();
        }
        static void User()
        {
            Console.WriteLine("Please enter word/sentence for palindrom check");
            StringInput();
        }
        static string StringInput()
        {
            var input = Console.ReadLine();
            var output = Whitespace.NoWhiteSpace(input);
            Stringsplit.stringsplit(output);
            return output;
        }
        static void StringTest()
        {
            // check if string is same forwards and backwards
        }
    }
}
