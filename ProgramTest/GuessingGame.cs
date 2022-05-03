using System;
namespace ProgramTest
{
    class GuessingGame
    {

        private static void Main(string[] args)
        {
            string secretWord = "giraffe";
            string guess = "";

            /*
            while (guess != secretWord)
            {
                Console.Write("Enter guess: ");
                guess = Console.ReadLine();

            }

            Console.WriteLine("You guessed the secret word!");
            
            */

            do
            {
                Console.Write("Enter guess: ");
                guess = Console.ReadLine();

            } while (secretWord != guess);
            Console.WriteLine("You guessed the secret word!");
        }
    }
}
