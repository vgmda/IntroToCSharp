using System;
namespace ProgramTest
{
    class Arrays
    {

        private static void Main5(string[] args)
        {
            int[] luckyNumbers = { 1, 2, 3, 4 };


            Console.WriteLine(luckyNumbers[0] + " " + luckyNumbers[1] + " " + luckyNumbers[2] + " " + luckyNumbers[3]);

            // Assigning values based on the index of the array
            luckyNumbers[0] = 100;
            luckyNumbers[1] = 200;
            luckyNumbers[2] = 300;
            luckyNumbers[3] = 400;

            Console.WriteLine(luckyNumbers[0] + " " + luckyNumbers[1] + " " + luckyNumbers[2] + " " + luckyNumbers[3]);

            string[] people = new string[5];

            people[0] = "Jim";
            people[1] = "John";
            people[2] = "Mike";
            people[3] = "Alice";
            people[4] = "Lucy";

        }

    }
}

