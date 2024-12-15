using System;

namespace StarPattern
{
    internal class star_pattern
    {
        private static void Main(string[] args)
        {
            Console.Write("Enter the number of lines for the star pattern: ");
            int n;

            while (!int.TryParse(Console.ReadLine(), out n) || n <= 0)
            {
                Console.Write("Invalid input. Please enter a positive integer: ");
            }

            // Increasing pattern
            for (int i = 1; i <= n; i++)
            {
                for (int j = 1; j <= i; j++)
                {
                    Console.Write("*");
                }
                Console.WriteLine();
            }

            // Decreasing pattern
            for (int i = n - 1; i >= 1; i--)
            {
                for (int j = 1; j <= i; j++)
                {
                    Console.Write("*");
                }
                Console.WriteLine();
            }
        }
    }
}
