using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library
{
    public class Ship : Vehicle
    {
        public Ship(string model, int yearManufacture) : base(model, yearManufacture)
        {
        }

        public override int CompareTo(object? obj)
        {
            return GetMaxSpeed().CompareTo(((Vehicle)obj).GetMaxSpeed());
        }

        public override int GetMaxSpeed()
        {
            if (GetPrice() > 20000 && YearManufacture > 2020)
            {
                return 140;
            }
            else if (Model == "Diana" && YearManufacture < 2015)
            {
                return 130;
            }
            else
            {
                return 90;
            }
        }
        public override int GetPrice()
        {
            if (YearManufacture > 2020)
            {
                return 900000;
            }
            else if (YearManufacture > 2010)
            {
                return 30000;
            }
            else
                return 2000;
        }
    }
}