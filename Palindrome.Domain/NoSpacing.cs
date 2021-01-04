namespace Palindrome.Domain
{
    public class Whitespace
    {
        public string NoWhiteSpace(string input)
        {
            return new string(input.ToCharArray()
                .Where(c => !char.IsWhiteSpace(c))
                .ToArray());
        }
    }
}