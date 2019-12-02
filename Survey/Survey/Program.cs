using System;

namespace Survey
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("What is your name?");
            var name = Console.ReadLine();


            Console.WriteLine("What is your age?");
            var age = Console.ReadLine();


            Console.WriteLine("What is your birth month?");
            var month = Console.ReadLine();

            Console.WriteLine("Your name is {0}", name);
            Console.WriteLine("Your age is {0}", age);
            Console.WriteLine("Your birth month is {0}", month);

            if (month == "march") {
                Console.WriteLine("You are Aries.");
            } else if (month == "april") {
                Console.WriteLine("You are Taurus.");
            } else if (month == "may") {
                Console.WriteLine("You are Gemini.");
            }
        }
    }
}
