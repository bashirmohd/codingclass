using System;

namespace ClassesCoffee.ClassesAndVariables.texaco
{
    //Class
    public class HotDrinks 
    {
        
        //Variables - Fields/Instance Variables
        private string hotDrinkName = null;
        public double volume = 4d;
        protected int jam = 0;
        private long age = 0l;

        //Variables - Static/Class Variables
        private static string cupName = null;
        public static double cupVolume = 4d;
        protected static int noOfCup = 0;
        private static long cupSuppliedQty = 0l;


        //Variables - Static/Class Variables
        public const string CASHIER_NAME = "";

        // ReadOnly
        private readonly string amount; 


        /*
         * There are different kinds of variables
         * 1. Local variables 
         * 2. Field/Instance Variable
         * 3. Class/Static variables
         * 4. Constant 
         * 5. ReadOnly        * 
         * 
         */

        public void MakeHotDrink()
        {
            Console.WriteLine(CASHIER_NAME);

            Console.WriteLine(hotDrinkName);
            //Local variables 
            int quantity = 3;
            double volume = 8.23;

            string name = "Mocha";
            Console.WriteLine(name);
            name = "Capaccino";
            Console.WriteLine(name);
        }

        public void GrabHotDrink()
        {
            Console.WriteLine(age);
            string name = "Mocha";
            Console.WriteLine(name);
        }


        public void PourDrink()
        {
            Console.WriteLine(cupName);
        }


    }
}
