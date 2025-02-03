using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
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

            // create the start pattern
            Console.WriteLine("Start pattern");

            // Let's perform a simple addition of two numbers
            double num1 = 5.0;
            double num2 = 10.0;
            double result = num1 + num2;

            // Print the result of the addition
            Console.WriteLine($"The result of adding {num1} and {num2} is {result}");

            return result;
        }

        public double Subtract()
        {
            // Let's perform a simple subtraction of two numbers
            double num1 = 10.0;
            double num2 = 5.0;
            double result = num1 - num2;

            // Print the result of the subtraction
            Console.WriteLine($"The result of subtracting {num2} from {num1} is {result}");
            return result;
        }
    }
    }
}