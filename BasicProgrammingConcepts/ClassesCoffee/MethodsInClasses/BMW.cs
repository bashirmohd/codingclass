using System;

namespace ClassesCoffee.MethodsInClasses
{
    public class Bmw
    {


        public string carName;
        private int carAge = 2;
        public static string RegNum = "BK61VHL";

        public Bmw()
        {
            carName = "Volvo";
            carAge = 5;
        }

        public Bmw(string myCarName, int myCarAge)
        {
            carName = myCarName;
            carAge = myCarAge;
        }


        public string GetCarName()
        {
            return carName;
        }

        //Smart methods
        public static void TypeLetterSmartStatic()
        {
            int a = 5;
            double salary = 2000d;
            double total = salary * a;
            Console.WriteLine(total);
        }

        //Smarter methods
        public static double TypeLetterSmarterStatic()
        {
            int a = 5;
            double salary = 2000d;
            double total = salary * a;
            return total;
        }


        //Smartest methods = Highly reusable
        public static double TypeLetterSmartestStatic(int nonOfMonths, double salary)
        {
            return salary * nonOfMonths;
        }


        //Instance methods
        //Smart methods
        public void TypeLetterSmart()
        {
            int a = 5;
            double salary = 2000d;
            double total = salary * a;
            Console.WriteLine(total);
        }

        //Smarter methods
        public double TypeLetterSmarter()
        {
            int a = 5;
            double salary = 2000d;
            double total = salary * a;
            return total;
        }


        //Smartest methods = Highly reusable
        public double TypeLetterSmartest(int nonOfMonths, double salary)
        {
            return salary * nonOfMonths;
        }

    }
}
