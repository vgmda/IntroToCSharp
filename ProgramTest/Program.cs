using System;
namespace ProgramTest
{
    class Program
    {
        private static void Main(string[] args)
        {
            // AgeName();

            // Declare Book object (an instance of a Book Class)
            Book book1 = new Book("Mike");
            book1.title = "Harry Potter";
            book1.author = "JK Rowling";
            book1.pages = 400;

            Book book2 = new Book("John");
            book2.title = "Lord Of the Rings";
            book2.author = "Tolkein";
            book2.pages = 700;



        }

        static void AgeName()
        {
            string characterName;
            int characterAge;
            string temp;

            // Get user input
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