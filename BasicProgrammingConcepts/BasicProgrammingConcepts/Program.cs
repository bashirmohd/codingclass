using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;

namespace BasicProgrammingConcepts
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Please enter your fcgpa for interpretation");
            string ans = Console.ReadLine();
            double fcgpa = double.Parse(ans);

            if (fcgpa >= 4.5 && fcgpa <= 5.00)
            {
                Console.WriteLine("You have made a first class!");
            }
            else if (fcgpa >= 3.5 && fcgpa < 4.49)
            {
                Console.WriteLine("You have made 2.1 grade");
            }
            else if (fcgpa >= 2.49 && fcgpa < 3.49)
            {
                Console.WriteLine("You have made 2.2 grade");
            }
        }
    }
}
