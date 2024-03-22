namespace SumBetweenMinMaxInArray
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[,] array = new int[5, 5];
            Random random = new Random();

            for (int i = 0; i < 5; i++)
            {
                for (int j = 0; j < 5; j++)
                {
                    array[i, j] = random.Next(-100, 101);
                }
            }

            int min = array[0, 0], max = array[0, 0];
            int minIndexI = 0, minIndexJ = 0, maxIndexI = 0, maxIndexJ = 0;

            for (int i = 0; i < array.GetLength(0); i++)
            {
                for (int j = 0; j < array.GetLength(1); j++)
                {
                    if (array[i, j] < min)
                    {
                        min = array[i, j];
                        minIndexI = i;
                        minIndexJ = j;
                    }
                    if (array[i, j] > max)
                    {
                        max = array[i, j];
                        maxIndexI = i;
                        maxIndexJ = j;
                    }
                }
            }

            int sum = 0;
            if (minIndexI == maxIndexI)
            {
                for (int j = Math.Min(minIndexJ, maxIndexJ) + 1; j < Math.Max(minIndexJ, maxIndexJ); j++)
                {
                    sum += array[minIndexI, j];
                }
            }
            else
            {
                if (minIndexI > maxIndexI)
                {
                    int tempI = minIndexI, tempJ = minIndexJ;
                    minIndexI = maxIndexI;
                    minIndexJ = maxIndexJ;
                    maxIndexI = tempI;
                    maxIndexJ = tempJ;
                }
                for (int i = minIndexI + 1; i < maxIndexI; i++)
                {
                    for (int j = 0; j < array.GetLength(1); j++)
                    {
                        sum += array[i, j];
                    }
                }
                for (int j = minIndexJ + 1; j < array.GetLength(1); j++)
                {
                    sum += array[minIndexI, j];
                }
                for (int j = 0; j < maxIndexJ; j++)
                {
                    sum += array[maxIndexI, j];
                }
            }

            Console.WriteLine("Array:");
            for (int i = 0; i < 5; i++)
            {
                for (int j = 0; j < 5; j++)
                {
                    Console.Write(array[i, j] + "\t");
                }
                Console.WriteLine();
            }

            Console.WriteLine($"Minimum element: {min}");
            Console.WriteLine($"Maximum element: {max}");
            Console.WriteLine($"Sum of elements between the minimum and maximum: {sum}");
        }
    }
}
