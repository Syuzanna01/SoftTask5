using ConsoleApp1;

namespace Task5
{
    public class Ship : Classadd
    {
        private int Price;
        public int price
        {
            get
            {

                if (YearManufacture > 2020)
                {
                    Price = 90000;
                }
                else
                    Price = 20000000;
                return Price;
            }
            set => this.price = value;

        }

        public Ship(string model, int yearManufacture)
        {
            Model = model;
            YearManufacture = yearManufacture;
        }
    }
}