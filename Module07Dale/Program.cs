using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace Module07Dale
{
    // class AutoDealer
    //  contains: 
    //      class: Automobile
    //      methods: 
    //          static method example 
    //          nonstatic method example

    class AutoDealer
    {
        static void Main(string[] args)
        {
            Automobile myAutomobile = new Module07Dale.AutoDealer.Automobile();

            // write properties of constructor

            WriteLine("My automobile is a classy {0} {1} that was built in the year {2}. \nThe color is {3} and the engine type is {4}.",
                 myAutomobile.AutoMake,
                 myAutomobile.AutoModel,
                 myAutomobile.AutoYear,
                 myAutomobile.AutoColor,
                 myAutomobile.AutoEngine);

            Automobile my2ndAutomobile = new Automobile("GMC");

            // write property of overloaded constructor
            WriteLine("\nMy 2nd automobile is an overloaded {0}.  \nI should go unload the {0}.  \nI have not handled the {0} responsibly.\n",
                 my2ndAutomobile.AutoMake);

            // static method example called
            Automobile.AutomobileExampleStatic();

            // nonstatic method example called;

            myAutomobile.AutomobileExampleNonStatic();

            // create 2 more different objects - assignment step .e  
            Automobile myCar = new Automobile("Pontiac");
            Automobile myOtherCar = new Automobile();

            WriteLine("\nMy car and my other car were:");

            WriteLine("{0}", myCar.AutoMake);
            WriteLine("{0}", myOtherCar.AutoMake);

            // reassign values in myCar and myOtherCar
            myCar.AutoMake = "Ford";
            myOtherCar.AutoMake = "Cadillac";

            WriteLine("\nTraded my car and my other car for");

            WriteLine("{0}", myCar.AutoMake);
            WriteLine("{0}", myOtherCar.AutoMake);


            ReadLine();
        }



        class Automobile
        {
            public string AutoMake { get; set; }
            public string AutoModel { get; set; }
            public int AutoYear { get; set; }
            public string AutoColor { get; set; }
            public string AutoEngine { get; set; }


            // constructor setting all properties
            public Automobile()
            {
                AutoMake = "Chevrolet";
                AutoModel = "Avalanche";
                AutoYear = 2011;
                AutoColor = "silver";
                AutoEngine = "5.7L V8";
            }

            // overloaded constructor setting the AutoMake
            public Automobile(string automake)
            {
                AutoMake = automake;
            }

            public static void AutomobileExampleStatic()
            {
                WriteLine("Hello from my static method: AutomobileExampleStatic\n");
            }

            public void AutomobileExampleNonStatic()
            {
                WriteLine("Hello from my nonstatic method: AutomobileExampleNonStatic");
                WriteLine("This is also known as an instance method");
            } 
        }            
    } 
}
