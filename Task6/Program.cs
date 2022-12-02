using Library;

namespace Task6
{
    internal class Program
    {
        static void Main(string[] args)
        {

            //1
            Car car = new("Tesla", 2021, 130, true);
            Ship ship = new("Viking Longboat", 2022);

            car.GetMaxSpeed();
            ship.GetMaxSpeed();

            //2
            List<Vehicle> vehicles = new();
            vehicles.Add(new Car("Tesla", 2021, 130, true));//100
            vehicles.Add(new Car("Suzuki", 2011, 80, false));//80
            vehicles.Add(new Car("BMW", 2018, 300, true));//110
            vehicles.Add(new Car("Mercedes-Benz ", 1975, 90, false));//80
            vehicles.Add(new Ship("Viking Longboat", 2022));//140
            vehicles.Add(new Ship("HMS Bounty", 2011));//90
            vehicles.Add(new Ship("Diana", 2011));//130
            vehicles.Add(new Ship("Diana Frigate", 2016));//90
            foreach (Vehicle item in GetFastestVehicles(vehicles))
            {
                Console.WriteLine(item.Model + " " + item.YearManufacture +
                    " " + item.GetMaxSpeed());
            }

            //5
            PC pc = new("Apple", 8000);//400000
            Car car1 = new("Tesla", 2021, 130, true);//7000000
            Ship ship1 = new("Viking Longboat", 2022);//900000
            OnlineMarket market = new() { Budget = 8000000 };
            market.AddItem(pc,800000);
            market.AddItem(ship1,60000);
            market.AddItem(car1,4000);



            OnlineMarket market1 = new() { Budget = 80000 };
            OnlineMarket market2 = new() { Budget = 5000000 };



        }

        public static Vehicle[] GetFastestVehicles(List<Vehicle> vehicle)
        {
            Vehicle[] vehicles = new Vehicle[3];
            int item1 = 0;
            int current;
            int item2 = 0;
            int item3 = 0;

            foreach (Vehicle item in vehicle)
            {
                current = item.GetMaxSpeed();
                if (item1 < item2)
                {
                    if (item1 < item3 && current > item1)
                    {
                        item1 = current;
                        vehicles[0] = item;
                    }
                    else if (current > item3)
                    {
                        item3 = current;
                        vehicles[2] = item;
                    }
                }
                else if (item2 < item3 && current > item2)
                {
                    item2 = current;
                    vehicles[1] = item;
                }
                else if (current > item3)
                {
                    item3 = current;
                    vehicles[2] = item;
                }
            }
            return vehicles;
        }
    }
}