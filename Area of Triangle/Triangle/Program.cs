using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace Triangle
{
    class Program
    {
        static void Main(string[] args)
        {
            // Area of triangle
            int basenum;
            int height;
            int area;

            Console.WriteLine("\t\t\tEnter the basenum of the triangle");
            basenum = Int32.Parse(Console.ReadLine());

            Console.WriteLine("\t\t\tenter height of the triagle");
            height = Int32.Parse(Console.ReadLine());

            area = basenum * height * 1/2;
            Console.WriteLine(area);
            if (area > 30)
            {
                Console.WriteLine("Big Area");

            }

            else
            {
                Console.WriteLine("Low Area");
                Console.ReadLine();

            }

            Console.ReadKey();


        }

        }
    }
