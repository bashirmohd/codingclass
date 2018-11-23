using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MathematicalOperations
{
    class Program
    {
        static void Main(string[] args)
        {
            //Mathematical Operations
            //Addition, Subtraction, Multiplication, Division and Modulus
            
            //Addition
            double result1 = 12.20d + 2.32d;
            Console.WriteLine(result1);
            //Console.ReadKey();

            //Minus
            double result2 = 12 - 2.32d;
            Console.WriteLine(result2);
//            Console.ReadKey();

            //Multiplication
            double result3 = 12f  * 2.32d;
            Console.WriteLine(result3);
            //            Console.ReadKey();

            //            Division
            double result4 = 12f / 2d;
            Console.WriteLine(result4); 
//            Console.ReadKey();

//           Modulus
            double result5 = 117f % 5f;
            Console.WriteLine(result5);
            
        }
    }
}
