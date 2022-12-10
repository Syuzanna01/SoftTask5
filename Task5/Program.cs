using Library;
using System.Linq;
using System.Text;

namespace Task5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ////3
            //Car car = new Car("Suzuki", 2012, 120, true);
            //Ship ship = new Ship("HMS Beagle", 2022);

            //PriceMax(car, ship);

            ////4
            //List<Ship> list = new List<Ship>();
            //list.Add(new Ship("Viking Longboat", 2022));
            //list.Add(new Ship("HMS Bounty", 2011));
            //list.Add(new Ship("Diana Frigate", 1980));
            //list.Add(new Ship("Diana Frigate", 2016));

            //foreach (Ship item in VehiclePurchases(list, 89000))
            //{
            //    Console.WriteLine($"{item.Model}, {item.YearManufacture} year, {item.GetPrice}$");
            //}

            //5
            List<Car> carList = new List<Car>();
            carList.Add(new Car("Tesla", 2012, 120, true));
            carList.Add(new Car("Suzuki", 2011, 120, true));
            carList.Add(new Car("BMV", 2012, 120, true));
            carList.Add(new Car("Mercedes-Benz ", 1975, 120, true));

            List<Ship> shipList = new List<Ship>();
            shipList.Add(new Ship("Viking Longboat", 2022));
            shipList.Add(new Ship("HMS Bounty", 2011));
            shipList.Add(new Ship("Diana Frigate", 2011));
            shipList.Add(new Ship("Diana Frigate", 2016));

            foreach (var item in MaxShipShopp(carList, shipList))
            {
                Console.WriteLine(item);
            }
            Console.ReadKey();
        }

        //3
        private static void PriceMax(Car car, Ship ship)
        {
            if (car.GetPrice() > ship.GetPrice())
            {
                Console.WriteLine($"A car of model - {car.Model} gearBox - {car.GearBox} " +
                    $"YearManufactur - {car.YearManufacture} horsepower - {car.Horsepower}" +
                    $" is more expensive than boat of model - {ship.Model} YearManufacture - {ship.YearManufacture}");
            }
            else if (car.GetPrice() < ship.GetPrice())
            {
                Console.WriteLine($"A car of model - {ship.Model} YearManufacture - {ship.YearManufacture}" +
                   $" is more expensive than boat of model - {car.Model} gearBox - {car.GearBox} " +
                   $"YearManufactur - {car.YearManufacture} horsepower - {car.Horsepower}");
            }
            else
            {
                Console.WriteLine($"A car of model - {car.Model} gearBox - {car.GearBox} " +
                  $"YearManufactur - {car.YearManufacture} horsepower - {car.Horsepower}" +
                  $" is equal model - {ship.Model} YearManufacture - {ship.YearManufacture}");
            }
        }

        ////4
        //private static List<Ship> VehiclePurchases(List<Ship> shipLlist, int money)
        //{
        //    List<Ship> shoppԼist = new List<Ship>();
        //    shipLlist.Sort((x, y) => x.GetPrice().CompareTo(y.GetPrice()));
        //    int sum = 0;
        //    foreach (Ship item in shipLlist)
        //    {
        //        if (sum + item.GetPrice() <= money)
        //        {
        //            sum += item.GetPrice();
        //            shoppԼist.Add(item);
        //        }
        //        else
        //        {
        //            break;
        //        }
        //    }
        //    return shoppԼist;
        //}

        //5
        private static List<int> MaxShipShopp(List<Car> cars, List<Ship> ships)
        {
            List<int> years = new List<int>();
            Dictionary<int, int> ShipList = new Dictionary<int, int>();
            Dictionary<int, int> CarList = new Dictionary<int, int>();
            foreach (Ship item in ships)
            {
                if (ShipList.ContainsKey(item.YearManufacture))
                {
                    ShipList[item.YearManufacture] += 1;
                }
                else
                {
                    ShipList.Add(item.YearManufacture, 1);
                }
            }
            foreach (Car item in cars)
            {
                if (CarList.ContainsKey(item.YearManufacture))
                {
                    CarList[item.YearManufacture] += 1;
                }
                else
                {
                    CarList.Add(item.YearManufacture, 1);
                }
            }
            foreach (var item in ShipList)
            {
                if (ShipList.ContainsKey(item.Key) == CarList.ContainsKey(item.Key) && ShipList[item.Key] > CarList[item.Key])
                {
                    years.Add(item.Key);
                    break;
                }
            }
            return years;
        }
    }
}