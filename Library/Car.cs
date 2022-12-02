using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library
{
    public class Car : Vehicle
    {
        public int Horsepower { get; private set; }
        public bool GearBox { get; private set; }

        public Car(string model, int yearManufacture, int horsepower, bool gearBox) : base(model, yearManufacture)
        {
            Horsepower = horsepower;
            GearBox = gearBox;
        }
        public override int CompareTo(object? obj)
        {
            return GetMaxSpeed().CompareTo(((Vehicle)obj).GetMaxSpeed());
        }

        public override int GetMaxSpeed()
        {
            if ((Model == "Tesla" || Model == "Suzuki") && YearManufacture > 2020)
            {
                return 100;
            }
            else if (Horsepower > 120 && GearBox && GetPrice() > 1000000)
            {
                return 110;
            }
            else if (Model == "Suzuki" && Horsepower > 140 && GearBox == false)
            {
                return 120;
            }
            else
            {
                return 80;
            }
        }

        public override int GetPrice()
        {
            if ((YearManufacture > 2010) && (GearBox == true))
            {
                return 7000000;
            }
            else if (YearManufacture > 2010)
            {
                return 5000000;
            }
            else if (GearBox = true)
            {
                return 3000000;
            }
            else
            {
                return 1000000;
            }
        }
    }
}