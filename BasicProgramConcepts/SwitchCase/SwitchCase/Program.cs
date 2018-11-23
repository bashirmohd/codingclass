using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SwitchCase
{
    class Program
    {
        static void Main(string[] args)


        {
            Console.WriteLine("Please enter your browser name");
            string browser = Console.ReadLine();
            switch (browser)
            {
                case "chrome":
                    Console.WriteLine("the test is executing on chrome broser ......");
                    break;

                case "firefox":
                    Console.WriteLine("the test is executing on firefox broser ......");
                    break;

                case "safari":
                    Console.WriteLine("the test is executing on safari broser ......");
                    break;

                case "edge":
                    Console.WriteLine("the test is executing on edge broser ......");
                    break;

                case "ie":
                    Console.WriteLine("the test is executing on ie broser ......");
                    break;

                case "opera":
                    Console.WriteLine("the test is executing on opera broser ......");
                    break;

                default:
                    Console.WriteLine("There is no support for this browser ......");
                    break;







            }
        

        }
    }
}
