namespace ExceptionHandlingApp
{
    internal class Program
    {
        static List<int> ReadNumbersFromUser()
        {
            List<int> numbers = new List<int>();

            Console.WriteLine("Enter integers and break if you're done:");

            while (true)
            {
                string input = Console.ReadLine();
                if (input.ToLower() == "break")
                {
                    break;
                }

                if (int.TryParse(input, out int number))
                {
                    
                    if (numbers.Contains(number))
                    {
                        throw new InvalidOperationException($"Duplicate number detected: {number}");
                    }
                    numbers.Add(number);
                }
                else
                {
                    Console.WriteLine("Invalid input. Please enter an integer.");
                }
            }

            return numbers;
        }
        static void Main(string[] args)
         {
            try
            {
                List<int> nums = ReadNumbersFromUser();
                Console.WriteLine("Numbers:");
                foreach (var num in nums)
                {
                    Console.WriteLine(num);
                }
            }
            catch (InvalidOperationException ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
    }
}