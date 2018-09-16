using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ExercisesCSharp
{
   internal class Car : Vehicle
    
    {

        internal Car(string _brand, string _model, double _realaseYear, double _engineCapacity,string _engineType, double _torque, double _gasTank, double _wheel, double _weight)
         : base(_brand, _model, _realaseYear,_engineCapacity,_engineType,_torque, _gasTank, _wheel, _weight)
        {
           
        }


    }

}