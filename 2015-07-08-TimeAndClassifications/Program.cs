using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2015_07_08_TimeAndClassifications
{
    class Program
    {
        //If the minute has just begun, or is 1/4, 1/2, or 3/4 through, a unique message is printed. Otherwise, "Working on it" is printed.

        static void Main(string[] args)
        {
            Console.WriteLine();
            Console.Write("Is your current minute at one of its four milestones? Press <Enter>... ");
            Console.ReadLine();
            Console.WriteLine();

            string userInput = "";

            while (userInput == "")
            {

                //equate an integer variable to the value of the seconds aspect of the time

                int secondsCount = DateTime.Now.Second;

                //print the time excluding the date

                Console.Write("The time is now: {0:T}. ", DateTime.Now);

                switch (secondsCount)
                {

                   //each case represents one of the four special values for seconds; default is all the other values

                    case 0:
                        Console.WriteLine("The new minute is just beginning.");
                        break;
                    case 15:
                        Console.WriteLine("We're one-quarter done.");
                        break;
                    case 30:
                        Console.WriteLine("Halfway there.");
                        break;
                    case 45:
                        Console.WriteLine("Getting close to done.");
                        break;
                    default:
                        Console.WriteLine("Working on it.");
                        break;
                }

                Console.WriteLine();
                Console.Write("To check again, press <Enter>... ");
                userInput = Console.ReadLine();
                Console.WriteLine();
            }


        }
    }
}
