using System;
namespace ProgramTest
{
    class Methods
    {

        private static void Main6(string[] args)
        {
            Prompt("Mike", 33);
            Prompt("John", 22);
            Prompt("Alice", 26);


            int cubedNumber = cube(5);
            Console.WriteLine(cubedNumber);
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
    }
}

