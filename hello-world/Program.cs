using System;

namespace helloworld
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

            Console.WriteLine("Your name is, " + name);
            Console.WriteLine("Your age is, " + age);
            Console.WriteLine("Your birth month is, " + month);
        }
    }
}
