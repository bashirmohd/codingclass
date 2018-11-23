using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace ComplexCalculator
{
    class Circumference
    {
       public static void Main(string[] args)
       {

            /* Simple calculation to find
             the circumference of a circle
             assuming formular is 2*pie*r
             */

            double r = 32;
           double p = 3.143;
          Double areaOFCircum =2 * (r * p);
           
           Double d = r * (p * p);

           Double rd = (r / 2) * (r / 2) * 3.14;

          Console.WriteLine("This is the result ", + areaOFCircum );

           Console.WriteLine("This ia a new result " + d);

           Console.WriteLine(rd);

           string answer = Console.ReadLine();

           Console.WriteLine("The three answers were " + answer);
           Console.ReadKey();
            



       }
    }
}
