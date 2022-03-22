using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp2
{
    internal class Bycle : Vehicle
    {

        Bycle bycles = new Bycle();
        public override void Drive(double km)
        {
            bycles.Millage = bycles.Millage + km;


        }

    }
}