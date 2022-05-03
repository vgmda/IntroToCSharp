using System;
namespace ProgramTest
{
    class Methods
    {

        private static void Main32(string[] args)
        {
            // Prompt("Mike", 33);
            // Prompt("John", 22);
            //Prompt("Alice", 26);


            // int cubedNumber = cube(5);
            // Console.WriteLine(cubedNumber);

            Console.WriteLine(GetPow(3, 2));
        }

        static void Prompt(string name, int age)
        {
            Console.WriteLine("Hello " + name + " you are " + age + " years old.");
        }


        static int cube(int num)
        {
            int result = num * num * num;
            return result;
        }

        // Exponent Method
        static int GetPow(int baseNum, int powNum)
        {
            int result = 1;

            for (int i = 0; i < powNum; i++)
            {
                result = result * baseNum;
            }

            return result;
        }
    }
}

