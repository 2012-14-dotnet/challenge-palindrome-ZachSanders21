﻿using System;

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
        static void StringInput()
        {
            var input = Console.ReadLine();
            NoSpacing(input);
        }
    }
}
