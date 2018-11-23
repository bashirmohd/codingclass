using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConditionalStatementsPrac
{
    class Program
    {
        static void Main(string[] args)

     //   Conditional Statement in C#
     /* If, If else, nested if, nested if else, else if, switch case statement 
      * 
      */



        {
            int testscore;
            int examscore;
            int result;


            Console.WriteLine("\t\t\tEnter your test from 0 to 30");
            testscore = Int32.Parse(Console.ReadLine());
            if (testscore < 30)
            {

            Console.WriteLine("Please enter the + sign");
                string sign = Console.ReadLine();
                if (sign == "+")
                {
                    Console.WriteLine("Enter exam score from 0 to 70");
                    examscore = Int32.Parse(Console.ReadLine());
                    if (examscore < 70)
                    {
                        result = testscore + examscore;
                        Console.WriteLine(result);
                        if (result >= 50)
                        {
                            Console.WriteLine("Congratulations!! you passed");
                        }
                        else
                        {
                            Console.WriteLine("Sorry!! you failed");
                        }
                    }
                    else
                    {
                        Console.WriteLine("Error!!!!");
                    }
                    
                }
                else
                {
                    Console.WriteLine("wrong operator selected!!");
                }

            
            }
            else
            {
                Console.WriteLine("The value you entered is invalid!");
            }
            Console.ReadKey();


        }
    }
}
