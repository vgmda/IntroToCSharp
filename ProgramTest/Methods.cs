using System;
namespace ProgramTest
{
    class Methods
    {

        private static void Main(string[] args)
        {
            Prompt("Mike", 33);
            Prompt("John", 22);
            Prompt("Alice", 26);

        }

        static void Prompt(string name, int age)
        {
            Console.WriteLine("Hello " + name + " you are " + age + " years old.");
        }

    }
}

