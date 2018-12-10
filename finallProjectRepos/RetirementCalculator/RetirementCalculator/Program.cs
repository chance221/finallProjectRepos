using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        // comment

        static void Main(string[] args)
        {

        }

        /*static void DisplayMenu()

        {


            string menuChoice;

            bool done = false;



            while (!done)

            {

                DisplayHeader("Main Menu");



                Console.WriteLine("\tA) Calculate Retirement savings");

                Console.WriteLine("\tB) Calculate Retirement Age");

                Console.WriteLine("\tC) Calculate Dream Home Payment");

                Console.WriteLine("\tD) Calculate retirement living expenses");

                Console.WriteLine("\tE) Exit");



                Console.Write("Enter Choice:");

                menuChoice = Console.ReadLine();



                switch (menuChoice)

                {

                    case "A":
                    case "a":

                        break;

                    case "B":
                    case "b":
                        break;


                    case "C":
                    case "c":

                        break;

                    case "D":
                    case "d":
                        break;

                    case "E":
                    case "e":
                        done = true;
                        break;



                    default:
                        Console.WriteLine("You did not select a correct option. Pleae try again.");

                        break;

                }

            }

        }*/

        static void DisplayHeader(string headerTitle)

        {

            Console.Clear();

            Console.WriteLine();

            Console.WriteLine("\t\t" + headerTitle);

            Console.WriteLine();

        }

        static void DisplayContinuePrompt()

        {

            Console.WriteLine();

            Console.WriteLine("Press any key to continue.");

            Console.ReadKey();

        }
    }
}

