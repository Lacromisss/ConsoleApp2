using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp2
{
    internal class Car : Vehicle
    {
        public Car(string color, string brand, double millage, double fuelcapacity, double currentfuel, double fuelfor1km)
        {
            this.Color = color;
            this.Brand = brand;
            this.Millage = millage;
            this._fuelFor1km = fuelfor1km;
            this._fuelCapacity = fuelcapacity;
            this._currentFuel = currentfuel;

        }

        public string Color;
        public string Brand;
        public double Millag;
        private double _fuelCapacity;
        private double _currentFuel;
        private double _fuelFor1km;

        public virtual void GetInfo()
        {
            Console.WriteLine($"Car Color : {Color}, Car Brand : {Brand}, Car Millage : {Millage}, Car FuelCapacity :{this._fuelCapacity}, Car CurrentFuel : {this._currentFuel}, Car FuelFor1KM : {this._fuelFor1km}");
        }
        public double CurrentFuel
        {
            get => _currentFuel;



            set
            {
                if (value >= 0 && value <= this._fuelCapacity)
                {
                    this._currentFuel = value;
                }
            }
        }
        public double FuelFor1Km
        {
            get => _fuelFor1km;




            set
            {
                if (value > 0)
                {
                    this._fuelFor1km = value;
                }
            }
        }

        public double FuelCapasity
        {
            get => this._fuelCapacity;
            set
            {
                if (_fuelCapacity > 0)
                {
                    this._fuelCapacity = value;

                }

            }
        }
        public override void Drive(double km)
        {


            if (this.CurrentFuel - km * FuelFor1Km >= 0)
            {
                this.CurrentFuel -= km * FuelFor1Km;
                Millage = Millage + km;
            }
            else
            {
                Console.WriteLine("Benzin catmadi bratva");
            }
        }



    }

}