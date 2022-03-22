using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp2
{
    internal abstract class Vehicle
    {
        public string Color;
        public string Brand;
        public double Millage;
        abstract public void Drive(double km);




        public virtual string ShowInfo()
        {


            return $"Color{Color} Brand{Brand} Millage{Millage}";
        }


    }
}