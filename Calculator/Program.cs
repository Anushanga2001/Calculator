using System;

namespace Test_001
{
    internal class Program
    {
        // inside this I want to call for the calculator and star_pattern classes and their main methods
        private static void Main(string[] args)
        {
            // call for that calculator class
            Calculator.Calculator.Main(args);

            // call for that star_pattern class
            StarPattern.star_pattern.Main(args);

        }


    }
}