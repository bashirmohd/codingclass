using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LoanCalculator
{
    class Program
    {
        static void Main(string[] args)
        {
            double value1;
            double value2;
            double results;
            string operations;

            //Title
            Console.WriteLine("\t\t\tBasic Console Loan Calculator\n");
            //Initiate a line separator
            Console.WriteLine("\t\t\t........................\n");

            //Input first variable
            Console.WriteLine("\t\t\tEnter your first value between 0 and 100\n");
            value1 = Double.Parse(Console.ReadLine());
            if (value1 <= 100)
            {
                //Select operator
                Console.WriteLine("\t\t\tEnter this Operator: (+,-,*,%)\n");
                operations = Console.ReadLine();

                //Input second variable
                Console.WriteLine("\t\t\tEnter your second between 0 and 100\n");
                value2 = Double.Parse(Console.ReadLine());
                if (value2 <= 100)
                {
                    //Initiating our conditional statement
                    switch (operations)
                    {
                        case "+":
                            results = value1 + value2;
                            Console.WriteLine("\n" + "======" + "\n" + results + "\n" + "======");
                            if (results >= 2000)
                            {
                                Console.WriteLine("Remark: " + " you're qualified for our credit card and loan");
                            }
                            else
                            {
                                Console.WriteLine("Remark: " + " You have failed credit check, please refer to other lenders");
                            }
                            break;
                        case "-":
                            results = value2 - value1;
                            Console.WriteLine("\n" + "======" + "\n" + results + "\n" + "======");
                            if (results >= 2000)
                            {
                                Console.WriteLine("Remark: " + " you're qualified for our credit card and loan");
                            }
                            else
                            {
                                Console.WriteLine("Remark: " + " You have failed credit check, please refer to other lenders");
                            }
                            break;
                        case "*":
                            results = value1 * value2;
                            Console.WriteLine("\n" + "======" + "\n" + results + "\n" + "======");
                            if (results >= 2000)
                            {
                                Console.WriteLine("Remark: " + " you're qualified for our credit card and loan");
                            }
                            else
                            {
                                Console.WriteLine("Remark: " + " You have failed credit check, please refer to other lenders");
                            }
                            break;
                        case "%":
                            results = value2 % value1;
                            Console.WriteLine("\n" + "======" + "\n" + results + "\n" + "======");
                            if (results >= 2000)
                            {
                                Console.WriteLine("Remark: " + " you're qualified for our credit card and loan");
                            }
                            else
                            {
                                Console.WriteLine("Remark: " + " You have failed credit check, please refer to other lenders");
                            }
                            break;
                        default:
                            Console.WriteLine("There is no such operations");
                            break;
                    }


                    //instantiate press key
                    Console.WriteLine("\n" + "\nPress key to exit...");
                    Console.ReadKey();
                }
                else
                {
                    Console.WriteLine("\n" + "ERROR!" + "\n" + "Out of range exception: refer to line 29");
                    Console.ReadKey();
                }


            }
            else
            {
                Console.WriteLine("\n" + "ERROR!" + "\n" + "Out of range exception: refer to line 38");
                Console.ReadKey();
            }
        }
    }
}
