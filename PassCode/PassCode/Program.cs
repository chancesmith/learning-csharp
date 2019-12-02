using System;

namespace PassCode
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please, enter you passcode:");
            var passcode = Console.ReadLine();

            if (passcode == "secret")
            {
                Console.WriteLine("You are authenticated.");
            }
            else
            {
                Console.WriteLine("You are dead to me.");
            }
        }
    }
}
