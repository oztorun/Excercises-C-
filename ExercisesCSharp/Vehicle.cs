using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ExercisesCSharp
{
    public abstract class Vehicle
    {

        #region Member
        string brand;
        string model;
        double releaseYear;
        double engineCapacity;
        double fuelComsumption;//biz hesaplayacağız
        string engineType;
        double torque;
        double gasTank;
        double wheel;
        double weight;
        double price;//biz hesaplayacağız
        
        private string _brand;
        private string _model;
        private double _realaseYear;
        private double _engineCapacity1;
        private double _fuelComsumption;
        private double _engineCapacity2;
        private double _torque;
        private double _gasTank;
        private double _wheel;
        private double _weight;
        private double _price;
        #endregion


        #region Constructor
        internal Vehicle (string _brand,string _model,double _realaseYear,double _engineCapacity,string _engineType,double _torque,double _gasTank,double _wheel,double _weight)
	{
        brand = _brand;
        model = _model;
        releaseYear = _realaseYear;
        engineCapacity = _engineCapacity;
        engineType = _engineType;
        torque = _torque;
        gasTank = _gasTank;
        wheel = _wheel;
        weight = _weight;
	}

        public Vehicle(string _brand, string _model, double _realaseYear, double _engineCapacity1, double _fuelComsumption, double _engineCapacity2, double _torque, double _gasTank, double _wheel, double _weight, double _price)
        {
            // TODO: Complete member initialization
            this._brand = _brand;
            this._model = _model;
            this._realaseYear = _realaseYear;
            this._engineCapacity1 = _engineCapacity1;
            this._fuelComsumption = _fuelComsumption;
            this._engineCapacity2 = _engineCapacity2;
            this._torque = _torque;
            this._gasTank = _gasTank;
            this._wheel = _wheel;
            this._weight = _weight;
            this._price = _price;
        }
        #endregion


        public virtual double EngineFuelCheck
        { 
            get
        
            {
                if (engineType == "Diesel")
                {
                    fuelComsumption = engineCapacity * 0.3 + torque * 0.2 + weight * 0.5;
                    
                }

                if (engineType=="Gas")
                {
                    fuelComsumption = engineCapacity * 0.5 + torque * 0.2 + weight * 0.3;
                }
                return fuelComsumption;
                }

            set 
            {
                fuelComsumption = value;
            }
         }

        public double OilLevel

        {
            get
            {
                    return 0;
         
            }

            set
            {
                if (fuelComsumption < 150)
                {
                    Console.WriteLine("Oil Level is Low");
                }
             
            }
        
        }


        public virtual double Acceleration
        {
            get 
            {
                return torque * 0.7 + engineCapacity * 0.3;
            }

            set
            {}           
            
        }

        public virtual double PriceCheck
        {
            get
            {
                if(releaseYear>2005)
                {
                    price=engineCapacity*0.5+torque*0.3+(releaseYear/5);
                }

                if(releaseYear<2005)
                {
                 price=engineCapacity*0.5+torque*0.3+(releaseYear/15);
                }

                return price;
            }


            set
            {
                price=value;
            }
        }

        public virtual double Balance
        {
            get {

               return weight / wheel;
            }

            set
            { 
                
            }
        
        }

    }
}
