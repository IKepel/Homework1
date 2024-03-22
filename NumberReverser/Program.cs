namespace NumberReverser
{
    internal static class Program
    {
        static int ReverseNumber(this int number)
        {
            int reversedNumber = 0;
            while(number != 0)
            {
                reversedNumber = reversedNumber * 10 + number % 10;
                number /= 10;
            }

            return reversedNumber;
        }

        static void Main(string[] args)
        {
            int number;
            bool isValidInput;

            do
            {
                Console.Clear();
                Console.Write("Enter a number: ");
                isValidInput = int.TryParse(Console.ReadLine(), out number);

                if (!isValidInput)
                {
                    Console.WriteLine("Invalid input. Please enter an integer.");
                    Console.WriteLine("Press any key to continue...");
                    Console.ReadKey();
                }
            } while (!isValidInput);

            Console.WriteLine($"Reversed number: {number.ReverseNumber()}");
        }
    }
}
