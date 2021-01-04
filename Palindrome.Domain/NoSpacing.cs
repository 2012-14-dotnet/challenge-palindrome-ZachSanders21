using System.Linq;
namespace Palindrome.Domain
{
    public class Whitespace
    {
        public string NoWhiteSpace(string input)
        {
            string nospace = string.Concat(input.Where(c => !char.IsWhiteSpace(c)));
            return nospace;
            
            // return new string(input.ToCharArray()
            //     .Where(c => !char.IsWhiteSpace(c))
            //     .ToArray());
        }
    }
}