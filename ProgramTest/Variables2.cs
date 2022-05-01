using System;
namespace ProgramTest
{
    class EmptyClass
    {

        static void Main(string[] args)
        {
            string phrase = "Test String";

            char grade = 'C';
            int age = 30;
            double gpa = 3.2;
            bool isMale = true;


            Console.WriteLine(phrase.Length);
            Console.WriteLine(phrase.ToUpper());
            Console.WriteLine(phrase.ToLower());
            Console.WriteLine(phrase.Contains("3"));

            // Working with indexes
            Console.WriteLine(phrase[2]);
            Console.WriteLine(phrase.IndexOf("s"));
            Console.WriteLine(phrase.Substring(5));
            Console.WriteLine(phrase.Substring(phrase.IndexOf("String")));

        }

    }
}

