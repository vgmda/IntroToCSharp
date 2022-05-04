using System;
namespace ProgramTest
{
    public class Chef
    {
        public void MakeChicken()
        {
            Console.WriteLine("The Chef makes chicken");
        }

        public void MakeSalad()
        {
            Console.WriteLine("The Chef makes salad");
        }


        // virtual - this method can be overwritten in a Sub Class
        public virtual void MakeSpecialDish()
        {
            Console.WriteLine("The Chef makes bbq ribs");
        }
    }
}

