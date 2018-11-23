using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Channels;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;

namespace ControlStatements
{
    class Program
    {

        static void Main(string[] args)
        {
            /*
             * Control statement is a statement that iterate over a certain event until condition is true
             */
            // While Loop

            double ans = 2 + 2; // code
            Console.WriteLine(ans); // Test
            Assert.AreEqual(ans, 1);

            double roomTemp = Double.Parse(Console.ReadLine());  //3

            do
            {
                Console.WriteLine("Watching room temp. " + roomTemp);
                //                roomTemp = roomTemp + 1;  
                roomTemp++;
                //                roomTemp--;
            } while (roomTemp != 25);



            string[] nameOfStudents = {"Ben", "Ken", "Hen", "shen", "Pen"};

            foreach (var nameOfStudent in nameOfStudents)
            {
                Console.WriteLine(nameOfStudent);
            }



            for (int abuja = 0; abuja < roomTemp; abuja++)
            {
                if (abuja > 2)
                {
                    Console.WriteLine("This is Garki"); 
                }
                else
                {
                    Console.WriteLine("The value of the town is " + abuja);
                }
            }

            
            while (roomTemp != 25) //This loop keeps happening if the condition is true
            {
                Console.WriteLine("Watching room temp. " + roomTemp);
//                roomTemp = roomTemp + 1;  
                roomTemp++;
//                roomTemp--;
            }
        }
    }
}
