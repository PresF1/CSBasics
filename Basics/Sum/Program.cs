namespace Sum
{
    class Program
    {
        static void Main()
        {
            float firstNumber = 0;
            float secondNumber = 0;

            Console.WriteLine("Welcome to Sum console application!");
            Console.WriteLine("Enter a number from keyboard: ");

            string firstInput = Console.ReadLine();
            firstNumber = ParseNumber(firstInput);
            

            Console.WriteLine("Enter a number from keyboard: ");

            string secondInput = Console.ReadLine();
            secondNumber = ParseNumber(secondInput);

            var sum = firstNumber + secondNumber;
            Console.WriteLine($"The resulting sum is: {sum}");
        }

        static float ParseNumber(string input)
        {
            float number = 0;
            
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