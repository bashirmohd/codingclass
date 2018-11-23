using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP
{
    class Program
    {
        public static void Main(string[] args)

        {
            Person person = new Person();
            person.FirstName = "Alice";
            person.LastName = "Okafor";
            person.Walk();
            person.Eat();

            Console.ReadKey();

        }
    }
}
