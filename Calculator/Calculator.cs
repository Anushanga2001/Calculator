using System;

namespace CalculatorApp // Changed namespace to avoid conflict
{
    public class Calculator
    {
        public static double Add(double a, double b)
        {
            return a + b;
        }

        public static double Subtract(double a, double b)
        {
            return a - b;
        }

        public static double Multiply(double a, double b)
        {
            return a * b;
        }

        public static double Divide(double a, double b)
        {
            if (b == 0)
            {
                Console.WriteLine("Cannot divide by zero.");
                return double.NaN;
            }
            return a / b;
        }
    }
}

public class Program
{
    public static void Main(string[] args)
    {
        Console.WriteLine("Calculator is running...");

        // Perform some basic operations
        double num1 = 10.0;
        double num2 = 5.0;

        Console.WriteLine($"Addition: {num1} + {num2} = {CalculatorApp.Calculator.Add(num1, num2)}");
        Console.WriteLine($"Subtraction: {num1} - {num2} = {CalculatorApp.Calculator.Subtract(num1, num2)}");
        Console.WriteLine($"Multiplication: {num1} * {num2} = {CalculatorApp.Calculator.Multiply(num1, num2)}");
        Console.WriteLine($"Division: {num1} / {num2} = {CalculatorApp.Calculator.Divide(num1, num2)}");
    }
}