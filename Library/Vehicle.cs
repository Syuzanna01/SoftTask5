using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library
{
    public abstract class Vehicle:IItem
    {
        public string Model { get; private set; }
        public int YearManufacture { get; private set; }
        public Vehicle(string model, int yearManufacture)
        {
            Model = model;
            YearManufacture = yearManufacture;
        }

        public Vehicle()
        {
        }

        public abstract int GetMaxSpeed();

        public abstract int GetPrice();
    }
}