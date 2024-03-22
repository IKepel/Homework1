namespace LeftShiftNumber
{
    internal class Program
    {
        static void Main()
        {
            int number;
            int shift;

            do
            {
                Console.Write("Enter a number: ");
            } while (!int.TryParse(Console.ReadLine(), out number));

            do
            {
                Console.Write("Enter the number of bits to shift left: ");
            } while (!int.TryParse(Console.ReadLine(), out shift));

            var shiftedNumber = ShiftLeft(number, shift);

            Console.WriteLine($"Shifted number: {shiftedNumber}");
        }

        static int ShiftLeft(int number, int shift)
        {
            var numberOfDigits = number.ToString().Length;
            shift %= numberOfDigits; // Обрізаємо зсув, щоб він був менше або рівний кількості розрядів числа

            var shiftedPart = number / (int)Math.Pow(10, numberOfDigits - shift);
            var remainingPart = number % (int)Math.Pow(10, numberOfDigits - shift);
            return remainingPart * (int)Math.Pow(10, shift) + shiftedPart;
        }

    }
}
