using System;
using ClassesCoffee.ClassesAndVariables.texaco;
using ClassesCoffee.MethodsInClasses;

namespace ClassesCoffee
{
    public class Program
    {
        static void Main(string[] args)
        {


            //Calling static methods and static variables - ClassName

            //Calling static variables
            Console.WriteLine(Bmw.RegNum);

           //Calling static methods
            Bmw.TypeLetterSmartStatic();
            double a1 =  Bmw.TypeLetterSmarterStatic();
            double a2 = Bmw.TypeLetterSmartestStatic(6, 3500);



            //Calling instance methods and instance variables - using objects
            Bmw threeSeries = new Bmw();
            //Class object = new copy of Constructor
            Console.WriteLine(threeSeries.GetCarName());

            Bmw mySeries = new Bmw("Bentley", 3);


            Bmw mySeries1 = new Bmw("Ford Fiesta", 5);

            Console.WriteLine(threeSeries.carName);

            double result3 = threeSeries.TypeLetterSmartest(12, 1500);
            Console.WriteLine(result3);

            double result2 = threeSeries.TypeLetterSmartest(12, 2500);
            Console.WriteLine(result2);

            double result = threeSeries.TypeLetterSmarter();
            Console.WriteLine(result);

            threeSeries.TypeLetterSmart();




            //Instance/Field Variable
            HotDrinks mochaDrinks = new HotDrinks();
            mochaDrinks.MakeHotDrink();
            Console.WriteLine(mochaDrinks.volume);

            //Static/Class variable
            Console.WriteLine(HotDrinks.cupVolume);

            //Constant outside of the class
            Console.WriteLine(HotDrinks.CASHIER_NAME);
        }
    }
}
