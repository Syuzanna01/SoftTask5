using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library
{
    public class PC : IItem
    {
        public string Model { get; private set; }
        public int Mamory { get; private set; }
        public PC(string model, int mamory)
        {
            Model = model;
            Mamory = mamory;
        }

        public int GetPrice()
        {
            if (Model == "APPLE IMAC 24 RETINA" && Mamory > 8000)
            {
                return 900000;
            }
            else if (Model == "PRESTIGIO SmartBook 141 C7 ")
            {
                return 500000;
            }
            else if (Mamory > 5000)
            {
                return 400000;
            }
            else
            {
                return 100000;
            }
        }
    }
}