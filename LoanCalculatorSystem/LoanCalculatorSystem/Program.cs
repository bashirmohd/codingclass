using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LoanCalculatorSystem
{
    class Program
    {
        static void Main(string[] args)
        {

            int LoanAmount;
            int InterestRate;
            int AmountPayable;
            int Azimo;
            
            Console.WriteLine("\t\t Please enter Amount from 0 to 10000");
            LoanAmount = Int32.Parse(Console.ReadLine());
            if (LoanAmount >= 10000) 

            {
                Console.WriteLine("The required loan is above our limit and should not be authorised");
            } 
            else

            {
                Console.WriteLine(LoanAmount);
                Azimo = InterestRate = 1 / 4 * LoanAmount;
                Console.ReadLine();
                Console.WriteLine(Azimo);
                AmountPayable = InterestRate + LoanAmount;
                Console.WriteLine(AmountPayable);
            }

            Console.ReadKey();


        }


    }
}


  