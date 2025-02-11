namespace CheckForVowels
{
    internal class Program
    {
         static bool ContainsVowels(string input)
    {
        foreach (char c in input.ToLower())
        {
            if ("aeiou".Contains(c))
            {
                return true;
            }
        }
        return false;
    }
        static void CheckForVowels(string input)
        {
            if (!ContainsVowels(input))
            {
                throw new InvalidOperationException("The string does not contain any vowels.");
            }
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Please enter a string:");

            string input = Console.ReadLine();
            try
            {
                CheckForVowels(input);
                Console.WriteLine("The string contains vowels.");
            }
            catch (InvalidOperationException ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
    }
}