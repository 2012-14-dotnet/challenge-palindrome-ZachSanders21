using System;

namespace Palindrome.Domain
{
    public class Stringsplit
    {
        public static void stringsplit(string input)
        {
            var firsthalf = input.Substring(0, (int)(input.Length / 2));
            var lasthalf = input.Substring((int)(input.Length / 2), (int)(input.Length/ 2));

            char[] cArray = lasthalf.ToCharArray();
            Array.Reverse(cArray);
            
        }

    }
}