using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Timmy_Files
{
    class Program
    {
        public static void Main(string[] args)
        {
            Int32 a = 5;
            Int32 b = 18;

            Int32 result = a + b;

            Int32 resultb = b - a;

            Console.WriteLine("This is a simple addition of varaible a + variable b" + result);
            Console.WriteLine(resultb);
            Console.ReadLine();
        }
    }
}
