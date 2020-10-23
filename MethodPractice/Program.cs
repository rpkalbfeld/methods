using System;

namespace MethodPractice
{
    class Program
    {
        public static object NewCustomer { get; private set; }

        static void Main(string[] args)
        {

            // Ask the user for things Make up a story and be creative  newcustmer data input
            
            Console.WriteLine("What is your Last Name?");
            string lastname = Console.ReadLine();

            Console.WriteLine("What is Your First Name?");
            string firstname = Console.ReadLine();

            Console.WriteLine("What is your date of birth?");
            string dateofbirth = Console.ReadLine();

            Console.WriteLine("How Old are you?");
            string howoldareyou = Console.ReadLine();

            Console.WriteLine("What is your favorite animal?");
            string animal = Console.ReadLine();

            Console.WriteLine("What kind of work do you do?");
            string occupation = Console.ReadLine();


            Console.WriteLine($"NewCustomer! {lastname}, {firstname}, {howoldareyou}, {animal}, { occupation}");

        }
    }
}
