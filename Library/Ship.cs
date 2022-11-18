using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library
{
    public class Ship:Vehicle
    {
        public Ship(string model, int yearManufacture)
        {
            Model = model;
            YearManufacture = yearManufacture;
        }

        public override int price
        {
            get
            {
                if (YearManufacture > 2020)
                {
                    Price = 900000;
                }
                else if (YearManufacture > 2010)
                {
                    Price = 30000;
                }
                else
                    Price = 2000;
                return Price;
            }
            set => this.Price = value;
        }
    }
}
