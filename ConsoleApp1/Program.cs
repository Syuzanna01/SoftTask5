using System.Text;

namespace Task5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Car car = new Car("BMV", 2012, 120, true);
            Ship ship = new Ship("MD", 2022);
            PriceMax(car.Model, car.price, car.GearBox, car.YearManufacture, car.Horsepower, ship.Model, ship.price, ship.YearManufacture);
        }

        private static void PriceMax(string model, int price, bool gearBox, int yearManufacture, int horsepower, string model1, int price1, int yearManufacture1)
        {
            if (price > price1)
            {
                Console.WriteLine($"A car of model - {model} gearBox - {gearBox} " +
                    $"yearManufactur - {yearManufacture} horsepower - {horsepower}" +
                    $" is more expensive than boat of model - {model1} yearManufacture1 - {yearManufacture1}");
            }
            else
            {
                Console.WriteLine($"A car of model - {model1} yearManufacture1 - {yearManufacture1}" +
                    $" is more expensive than boat of model - {model} gearBox - {gearBox} " +
                    $"yearManufactur - {yearManufacture} horsepower - {horsepower}");
            }
        }
    }
}