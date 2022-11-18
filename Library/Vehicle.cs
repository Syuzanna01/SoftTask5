using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library
{
    public class Vehicle
    {
        public string Model { get; set; }
        public int YearManufacture { get; set; }
        public virtual int price { get; set; }
        protected int Price;
    }
}
