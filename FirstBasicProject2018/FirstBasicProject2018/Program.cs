using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace FirstBasicProject2018
{
    class Program
    {
        static void Main(string[] args)
        {
            //This is how to output stuff on the console
            Console.WriteLine("Are you using Talktalk?");
            Console.WriteLine("Are you there, can you hear me?");
            
            //This is how to input stuff into the program
            string answer = Console.ReadLine();
            Console.WriteLine("He responded with "+ answer );

            //This is a code holding the termination of execution 
            Console.ReadKey();
        }
      
    }
}
