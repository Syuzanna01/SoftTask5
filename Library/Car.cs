﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library
{
    public class Car:Vehicle
    {
        public int Horsepower { get; set; }
        public bool GearBox { get; set; }

        public Car(string model, int yearManufacture, int horsepower, bool gearBox)
        {
            Model = model;
            YearManufacture = yearManufacture;
            Horsepower = horsepower;
            GearBox = gearBox;
        }

        public override int price
        {
            get
            {
                if ((YearManufacture > 2010) && (GearBox == true))
                {
                    Price = 7000000;
                }
                else if (YearManufacture > 2010)
                {
                    Price = 5000000;
                }
                else if (GearBox = true)
                {
                    Price = 3000000;
                }
                else
                {
                    Price = 1000000;
                }
                return Price;
            }
            set => this.price = value;
        }
    }
}