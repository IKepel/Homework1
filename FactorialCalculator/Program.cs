namespace FactorialCalculator
{
    internal class Program
    {
        static long CalculateFactorial(long n)
        {
            if (n == 0) return 1;
            else return n * CalculateFactorial(n - 1);
        }

        static void Main(string[] args)
        {
            int number;
            bool isValidInput;

            do
            {
                Console.Clear();
                Console.Write("Enter a number to factorial calculation: ");

                isValidInput = int.TryParse(Console.ReadLine(), out number);

                if (!isValidInput || number < 0)
                {
                    Console.WriteLine("Undefined.");
                    Console.WriteLine("Press any key to continue...");
                    Console.ReadKey();
                }
            } while (!isValidInput || number < 0);

            Console.WriteLine($"Your result {number}! = {CalculateFactorial(number)}");
        }
    }
}
