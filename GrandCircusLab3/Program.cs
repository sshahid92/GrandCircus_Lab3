using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GrandCircusLab3
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("What is your name?");
            var userName = Console.ReadLine();

            while (true)
            {
                Console.WriteLine(userName + ", enter a number between '1' and '100'.");
                var userNumber = int.Parse(Console.ReadLine());
                if (userNumber <= 0 || userNumber > 100)
                {
                    Console.WriteLine("Invalid number!");
                    continue;
                }
                if (userNumber % 2 == 0)
                {
                    if (userNumber >= 2 && userNumber < 25)
                    {
                        Console.WriteLine(userName + ", " + userNumber + " is an even and less than 25.");
                    }
                    else if (userNumber >= 26 && userNumber <= 60)
                    {
                        Console.WriteLine(userName + ", " + userNumber + " is even.");
                    }
                    else if (userNumber > 60)
                    {
                        Console.WriteLine(userName + ", " + userNumber + " is even.");
                    }
                }
                else
                {

                    Console.WriteLine(userName + ", " + userNumber + " is odd.");
                }

                Console.WriteLine("Type 'quit' to leave the program or anter anything to continue.");

                if (Console.ReadLine().ToLower() == "quit")
                {
                    Console.WriteLine("Goodbye " + userName + "!");
                    break;
                }
                else
                {
                    continue;
                }
            }
        }
    }
}
