using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ExercisesCSharp
{
    class CarFactory
    {
        public class ShapeFactory
        {
            public ShapeFactory()
            { }

            private static ShapeFactory _instance;
            private static object lockObject = new object();

            public static ShapeFactory Instance()
            {

                if (_instance != null) return _instance;
                lock (lockObject)
                {
                    if (_instance == null)
                    {
                        _instance = new ShapeFactory();
                    }
                    return _instance;

                }
            }

        }
        //public Vehicle CreateVehicle(EnumVehicle vehicle, params double[] list)
        //{
        //    Vehicle v=null;
        //    switch (vehicle)
        //    {
        //        case vehicle. s = new Rectangle(list[0], list[1]);
        //            break;
        //        case Figure.Square: s = new Square(list[0]);
        //            break;
        //        case Figure.Circle: s = new Circle(list[0]);
        //            break;
        //        case Figure.Triangle: s = new Triangle(list[0], list[1], list[2]);
        //            break;
        //        default:
        //            break;
        //        default:
        //            break;
        //    }
        //    return v;
        //}
    
    }
}
