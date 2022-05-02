using System;
namespace ProgramTest
{
    class Calculator
    {

        private static void Main3(string[] args)
        {
            Console.WriteLine("Enter a number: ");
            double num1 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Enter another number: ");
            double num2 = Convert.ToDouble(Console.ReadLine());

            // Output the sum of two numbers
            Console.WriteLine(Math.Abs(num1 + num2));

        }

    }
}

