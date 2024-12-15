using System;

namespace Test_001
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            while (true)
            {
                Console.WriteLine("Simple Calculator");
                Console.WriteLine("1. Addition");
                Console.WriteLine("2. Subtraction");
                Console.WriteLine("3. Multiplication");
                Console.WriteLine("4. Division");
                Console.WriteLine("5. Exit");
                Console.Write("Choose an option (1-5): ");

                string choice = Console.ReadLine();

                if (choice == "5")
                {
                    Console.WriteLine("Exiting... Goodbye!");
                    break;
                }

                Console.Write("Enter the first number: ");
                double num1;
                while (!double.TryParse(Console.ReadLine(), out num1))
                {
                    Console.Write("Invalid input. Please enter a valid number: ");
                }

                Console.Write("Enter the second number: ");
                double num2;
                while (!double.TryParse(Console.ReadLine(), out num2))
                {
                    Console.Write("Invalid input. Please enter a valid number: ");
                }

                switch (choice)
                {
                    case "1":
                        Console.WriteLine($"Result: {num1} + {num2} = {num1 + num2}");
                        break;

                    case "2":
                        Console.WriteLine($"Result: {num1} - {num2} = {num1 - num2}");
                        break;

                    case "3":
                        Console.WriteLine($"Result: {num1} * {num2} = {num1 * num2}");
                        break;

                    case "4":
                        if (num2 != 0)
                        {
                            Console.WriteLine($"Result: {num1} / {num2} = {num1 / num2}");
                        }
                        else
                        {
                            Console.WriteLine("Division by zero is not allowed.");
                        }
                        break;

                    default:
                        Console.WriteLine("Invalid option. Please choose between 1 and 5.");
                        break;
                }

                Console.WriteLine();
            }
        }
    }
}