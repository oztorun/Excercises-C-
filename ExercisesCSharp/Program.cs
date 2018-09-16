using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ExercisesCSharp
{
    class Program
    {
        static void Main(string[] args)
        {
            //araç sınıfı olacak 5 
            //bunlardan araba,motor,uçak türeyecek 5 
            //factory singleton pattern kullanılacak 
            //abstrack,virtual,override kullanılacak
            //doubleerface kullanılacak
            //get,set property olacak aracın hızı şundan düşük olmaaz benzin düşükse uyarı ver oalcak
            //metodlar olacak


            Car c1 = new Car("bmw", "e30", 1985, 2500, "Diesel", 220, 50, 4, 1250);
            Console.WriteLine(c1.Acceleration);
            Console.WriteLine(c1.EngineFuelCheck);
            Console.WriteLine(c1.PriceCheck);

            //Motorcycle m1 = new Motorcycle("yamaha", "yzf", 2012, 1200);


            Console.ReadKey();

            

        }
    }
}
