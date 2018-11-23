using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConditionalStatements
{
    class Program
    {
        static void Main(string[] args)
        {

            //conditional Statement in C#
            /* 
             * If, if else, nested if, nested if else, else if, switch case statement
             * 
             */

            Console.WriteLine("Please enter your browser name");
            string browser = Console.ReadLine();

            switch (browser)
            {
                case "chrome":
                    double port = 6;
                    Console.WriteLine("The test is executing on Chrome browser ...");
                    switch (port)
                    {
                        case 1:
                        case 6:
                        case 7:
                        case 8:
                            Console.WriteLine("Port number is "+ port);
                            if (port == 1111)
                            {
                                
                            }
                            break;
                        case 2:
                            Console.WriteLine("Whatever");
                            break;
                        case 3:
                            Console.WriteLine("Whatever");
                            break;
                        case 4:
                            Console.WriteLine("Whatever");
                            break;
                        case 5:
                            Console.WriteLine("Whatever");
                            break;
                        default:
                            Console.WriteLine("This number is out of range");
                            break;
                     
                    }
                    break;
                case "firefox":
                    Console.WriteLine("The test is executing on firefox browser ...");
                    break;
                case "safari":
                    Console.WriteLine("The test is executing on safari browser ...");
                    break;
                case "edge":
                    Console.WriteLine("The test is executing on edge browser ...");
                    break;
                case "ie":
                    Console.WriteLine("The test is executing on ie browser ...");
                    break;
                case "opera":
                    Console.WriteLine("The test is executing on opera browser ...");
                    break;
                default:
                    Console.WriteLine("There is no support for this kind of a browser on our system");
                    break;

            }






            int age = 92;
            string stateOfOrigin = "Anambra";
            //Nested if or else if, if else, etc
            if (age >= 90)
            {
                Console.WriteLine("You made an Alpha");
                if (age >= 95)
                {
                    Console.WriteLine("You also have Fed. Scholarship");
                }
                else if (stateOfOrigin.Equals("Eboyi") && age > 92)
                {
                    Console.WriteLine("You also have Fed. Scholarship - based of state of origin");
                }
                else if (stateOfOrigin.Equals("Anambra") && age > 92)
                {
                    Console.WriteLine("Unfortunately, you haven't secured scholarship");
                }
                else if (stateOfOrigin.Equals("Imo") || age < 92)
                {
                    Console.WriteLine("Unfortunately, you haven't secured scholarship");
                }
                else
                {
                    Console.WriteLine("Unfortunately, you haven't secured scholarship");
                }
            }
            else
            {
                Console.WriteLine("This is wrong voting age");
            }

            //Nicknamed as -- else if

            if (age == 32)
            {
                Console.WriteLine("This is my actual age!");
            } else if (age == 33)
            {
                Console.WriteLine("This is not driving age in Nigeria");  
            }
            else if (age == 34)
            {
                Console.WriteLine("This is voting age");
            }
            else if (age == 35)
            {
                Console.WriteLine("This is rigging age");
            }
            else
            {
                Console.WriteLine("This is age to be president");
            }

            //If else statement
            if (age == 32)
            {
                Console.WriteLine("This is my actual age!");
            }
            else
            {
                Console.WriteLine("This is wrong voting age");
            }

            //if statement
            if (age == 32)
            {
                Console.WriteLine("This is my actual age!");
            }

        }
    }
}
