using System;
namespace ProgramTest
{
    class IfStatements
    {

        private static void Main3(string[] args)
        {
            /*  Declare bools
             *  Check if the corresponding bools are true or false
             *  Output the result based on the condition
             
            bool isFirst = true;
            bool isWinner = false
            
            if (isFirst && isWinner)
            {
                Console.WriteLine("This statement is true");
            }
            else
            {
                Console.WriteLine("This statement is false");
            }

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
            */


            // Return the biggest number out of two
            Console.WriteLine(GetMax(2, 10, 999));

            static int GetMax(int num1, int num2, int num3)
            {

                int result;


                if (num1 >= num2 && num1 >= num3)
                {
                    result = num1;
                }
                else if (num2 >= num1 && num2 >= num3)
                {
                    result = num2;
                }
                else
                {
                    result = num3;
                }
                return result;
            }




        }

    }
}

