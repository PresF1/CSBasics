namespace Sum
{
    class Program
    {
        static int countNumbers = 0;

        static void Main()
        {
            float sum = default;

            Console.WriteLine("Welcome to Sum console application!");
            Console.WriteLine("Enter a count of numbers to sum:");

            while (!TryParseCountNumbers(Console.ReadLine()))
            {
                Console.WriteLine("Enter a count of numbers to sum:");
            }

            for (int i = 1; i <= countNumbers; i++)
            {
                Console.WriteLine("Enter a number from keyboard: ");

                string input = Console.ReadLine();
                sum += ParseFloatNumber(input);
            }

            Console.WriteLine($"The resulting sum is: {sum} and the arithmetic mean is: {Math.Round(sum / countNumbers)}");
        }

        static bool TryParseCountNumbers(string input)
        {
            if (input == null)
                return false;

            if (!int.TryParse(input, out int result))
                return false;

            countNumbers = result;
            return true;
        }
        
        static float ParseFloatNumber(string input)
        {
            float number = default;

            try
            {
                number = float.Parse(input);
                Console.WriteLine($"The number is: {input}");
            }
            catch (FormatException)
            {
                Console.WriteLine("Invalid format. Please enter a valid number.");
            }
            catch (OverflowException)
            {
                Console.WriteLine("The number is too large or too small for a float.");
            }

            return number;
        }
    }
}