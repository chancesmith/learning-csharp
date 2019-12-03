using System;

namespace PassCode
{
    class Program
    {
        static void Main(string[] args)
        {

            var passcode = "";

            while (passcode != "secret") {

                Console.WriteLine("Please, enter you passcode:");
                passcode = Console.ReadLine();

                if (passcode != "secret")
                {
                    Console.WriteLine("You are dead to me.");
                }
            }

            Console.WriteLine("You are authenticated.");
        }
    }
}
