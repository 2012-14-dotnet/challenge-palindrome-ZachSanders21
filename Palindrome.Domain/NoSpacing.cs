using System.Linq;
using System;
namespace Palindrome.Domain
{
    public class Whitespace
    {
        public static string NoWhiteSpace(string input)
        {   
            // string nospace = String.Concat(input.Where(c => !char.IsWhiteSpace(c)));
            // return nospace;
            string output = new string(input.ToCharArray()
                            .Where(c => !char.IsWhiteSpace(c))
                            .ToArray());
            
            return output;
        }
    }
}