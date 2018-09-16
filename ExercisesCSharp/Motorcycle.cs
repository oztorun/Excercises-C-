using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ExercisesCSharp
{
     public class Motorcycle : Vehicle
    {
        internal Motorcycle(string _brand, string _model, double _realaseYear, double _engineCapacity, double _fuelComsumption, string _engineType, double _torque, double _gasTank, double _wheel, double _weight, double _price)
            : base(_brand, _model, _realaseYear, _engineCapacity, _fuelComsumption, _engineCapacity, _torque, _gasTank, _wheel, _weight, _price)
        { }


        public override double EngineFuelCheck
        {
            get
            {
                return EngineFuelCheck;
            }
            set
            {
                base.EngineFuelCheck = value;
            }
        }

        public override double Acceleration
        {
            get
            {
                return base.Acceleration;
            }
            set
            {
                base.Acceleration = value;
            }
        }
       

         
    }


}
