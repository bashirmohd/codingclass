using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP
{
    class Person
    {
        public string FirstName;
        public string LastName;
        public DateTime DateOfBirth;

        public bool Gender;


        public void Walk()
        {
            Console.WriteLine(FirstName + " is walking.");
            Console.WriteLine(LastName + " is walking home from school");
          
          
        }

        public void Eat()
        {
            Console.WriteLine(FirstName + " is eating.");
            Console.WriteLine(LastName + " is going home to eat");

           
        }
    }
}
