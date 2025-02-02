using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator
{
    internal class Architecture
    {
        public Architecture() { }
        
        public double Add()
        {
            // print hello world
            Console.WriteLine("Hello World");
            return 0.0;

            // Let's perform a simple addition of two numbers
            double num1 = 5.0;
            double num2 = 10.0;
            double result = num1 + num2;

            // Print the result of the addition
            Console.WriteLine($"The result of adding {num1} and {num2} is {result}");

            return result;
        }
    }
}