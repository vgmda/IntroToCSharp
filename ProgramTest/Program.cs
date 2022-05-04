using System;
namespace ProgramTest
{
    class Program
    {
        private static void Main(string[] args)
        {
            // AgeName();

            // Declare Book object (an instance of a Book Class)
            Book book1 = new Book("Harry Potter", "JK Rowling", 400);

            // book1.title = "Harry Potter";
            // book1.author = "JK Rowling";
            // book1.pages = 400;

            Book book2 = new Book("Lord Of the Rings", "Tolkein", 700);
            // book2.title = "Lord Of the Rings";
            // book2.author = "Tolkein";
            // book2.pages = 700;

            Student student1 = new Student("Jim", "Business", 2.8);
            Student student2 = new Student("Pam", "Art", 3.6);


            // Console.WriteLine(student1.HasHonors());
            // Console.WriteLine(student2.HasHonors());

            Movie avengers = new Movie("The Avengers", "Joss Whedon", "PG");
            Movie shrek = new Movie("Shrek", "Adam Adamson", "PG");

            // Console.WriteLine(avengers.Rating);

            Song holiday = new Song("Holiday", "Green Day", 200);
            //Console.WriteLine(Song.songCount);
            Song kashmir = new Song("Kashmir", "Led Zeppelin", 150);
            //Console.WriteLine(Song.songCount);
            //Console.WriteLine(kashmir.getSongCount());



            //Calling the static method without the need to create a object
            UsefulTools.SayHi("John");

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