using System;
namespace ProgramTest
{
    class Program
    {
        private static void Main1(string[] args)
        {
            string characterName;
            int characterAge;
            string temp;

            //Get user input
            Console.WriteLine("Enter the name: ");
            characterName = Console.ReadLine();
            Console.WriteLine("Enter the age: ");
            temp = Console.ReadLine();
            // Convert to integer
            characterAge = Convert.ToInt32(temp);




            Console.WriteLine("There once was a man named " + characterName);
            Console.WriteLine("He was " + characterAge + " years old");
            Console.WriteLine("He really like the name " + characterName);
            Console.WriteLine("But didn't like being " + characterAge);




        }

    }

}