using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SavingCalculator
{
    class Program
    {
        static void Main(string[] args)
        {

            int earnings;
            int expenses;
            int saving;

            Console.WriteLine("\t\t\tEnter your earnings from 500 2500");
            earnings = Int32.Parse(Console.ReadLine());
            if (earnings > 2500)
            {
                Console.WriteLine("Error");
            }else
           
            {
                Console.WriteLine("Please enter the - sign");
                string sign = Console.ReadLine();

                if (sign != "-")

                {
                    Console.WriteLine("Wrong operator selected");
                }
                else
                {
                    Console.WriteLine("\t\t\tPlease enter expenses form 0 to 2300");
                    expenses = Int32.Parse(Console.ReadLine());
                    if (expenses > 2400)
                    {
                        Console.WriteLine("You are at high risk of going into bankrupt");

                    }
                    else
                    {
                        saving = earnings - expenses;
                        Console.WriteLine("saving");
                        if (saving >= 1500)
                        {
                            Console.WriteLine("You are on high income earners list");

                        }

                        else
                        {
                                Console.WriteLine("You are on low income earners list");
                           
                          
                              Console.ReadLine();


                            
                        }
                        
                    }
                    
                }
                
            }
            Console.ReadKey();

        }
        
    }

    
}
            