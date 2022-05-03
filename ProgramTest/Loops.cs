using System;
namespace ProgramTest
{
    class Loops
    {
        private static void Main(string[] args)
        {
            // While loop
            int index = 1;

            while (index <= 5)
            {
                Console.WriteLine(index);
                index++;
            }

            //Do While loop
            int i = 6;
            do
            {
                Console.WriteLine("\n" + i);
                i++;
            } while (i <= 5);

            //For loop
            int[] luckyNumbers = { 4, 8, 15, 16, 23, 45 };

            for (int j = 0; j < luckyNumbers.Length; j++)
            {
                Console.WriteLine(luckyNumbers[j]);
            }
        }

    }

}