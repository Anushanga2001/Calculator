using System;

namespace StarPattern
{
    public class StarPattern
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Star Pattern is running...");
            PrintStarPattern(5);
        }

        public static void PrintStarPattern(int n)
        {
            for (int i = 1; i <= n; i++)
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