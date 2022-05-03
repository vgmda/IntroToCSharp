using System;
namespace ProgramTest
{
    class GuessingGame
    {

        private static void Main3(string[] args)
        {
            string secretWord = "giraffe";
            string guess = "";
            // Guess Count
            int i = 3;

            Console.WriteLine("Numer of guesses left " + i);
            while (guess != secretWord && i != 0)
            {

                Console.Write("Enter guess: ");
                guess = Console.ReadLine();
                i--;

                if (guess == secretWord)
                {
                    Console.WriteLine("You guessed the secret word!");
                }
                else if (i == 0)
                {
                    Console.WriteLine("You ran out of lives!");
                }
                else
                {
                    Console.WriteLine("Numer of guesses left " + i);
                }

            }


            /*
            do
            {
                Console.Write("Enter guess: ");
                guess = Console.ReadLine();

            } while (secretWord != guess);
            Console.WriteLine("You guessed the secret word!");
            */
        }
    }
}
