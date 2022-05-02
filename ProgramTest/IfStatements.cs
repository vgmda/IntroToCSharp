using System;
namespace ProgramTest
{
    class IfStatements
    {

        private static void Main(string[] args)
        {
            bool isFirst = true;
            bool isWinner = false;

            //if (isFirst && isWinner)
            //{
            //    Console.WriteLine("This statement is true");
            //}
            //else
            //{
            //    Console.WriteLine("This statement is false");
            //}

            if (isFirst && isWinner)
            {
                Console.WriteLine("This statement is true");
            }
            else if (isFirst && !isWinner)
            {
                Console.WriteLine("This statement is true/false");
            }

            else
            {
                Console.WriteLine("This statement is false");
            }




        }

    }
}

