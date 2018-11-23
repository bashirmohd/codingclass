using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace ComplexCalcx2
{
   public class Calcxx
    {
        static void Main(string[] args)
        {
            Int32 a = 3;
            float b = 4.5F;
            double c = 5;

            var answer = a * b / c;

            Console.WriteLine("The result is {0}",answer);

            Type type = answer.GetType();
            Console.WriteLine("answer is of type {0}",type.ToString());

            Console.ReadLine();
        }
    }
}
