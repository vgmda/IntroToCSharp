using System;
namespace ProgramTest
{
    //Inherit the methods/functionality of a Chef class
    public class ItalianChef : Chef
    {
        public void MakePasta()
        {
            Console.WriteLine("The Chef makes pasta");
        }

        // override - means override the method from the Super Class
        public override void MakeSpecialDish()
        {
            Console.WriteLine("The Chef makes pizza");
        }

    }
}

