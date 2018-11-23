using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

namespace DomesticAnimals
{
    class Program
    {
        static void Main(string[] args)
        {

            //Byte
            Byte a1 = 12;
            //Min -128 (-2^7)
            //Max = 127 (2^7 -1)
            byte a2 = 0; // Default value is zero

            Console.WriteLine(a2);

            //Short
            short b1 = -32768; // Min value = -2^15
            short b2 = 32767; // Max value = 2^15 -1
            short b3 = 0;
            //Example 
            short b4 = 300;


            //Integer - 32Bits Complementary
            int c1 = -2147483648; //Min value (-2^31)
            int c2 = 2147483647; //Min value (-2^31 -1)
            int c3 = 0;

            int c4 = 7453;
            int c5 = 3;
            Int32 c6 = 23;

            
           //Long - 64Bits Complementary
            long d1 = -9223372036854775808L; //Min value (-2^63)
            long d2 = 9223372036854775807; //Min value (-2^63 -1)
            long d3 = 0L;


            //Float - 32Bits IEEE 754 floating numbers
            float e1 = 3.1475814758f; 
            float e2 = 20.01550155f; 
            float e3 = 0.0f;
            Console.WriteLine(e1);


            //Float - 64Bits IEEE 754 floating numbers
            Double f1 = 50.25d;
            double f2 = 435.25458954d;
            double f3 = 0.0d;
            Console.WriteLine(f2);

            //Integer, Double, Floating 


            //Boolean - True or False
            Boolean g1 = true;
            bool g2 = false;
            bool g3 = false;  // Default value of boolean


            //Character - char
            char h1 = 'U';
            char h2 = '6';
            char h3 = '0'; //Default 

            //String 
            String sentence = "This is the boy who bike was stolen and he is 12 years old";
            string name = "My name is Dotcom";

            //Derived Data type - This is a data type created by the programmer

            Nwofor edwin = new Nwofor();



            //Comments in C#
            // Single line comments as //
            //Multiline Comments as /* */

            /*
                float e1 = 3.1475814758f;
                float e2 = 20.01550155f;
                float e3 = 0.0f;
                Console.WriteLine(e1);
            */
        }
    }
}
