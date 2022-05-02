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

        }

    }

}