using Library;

namespace Task7
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ////1
            //Vehicle[] vehicles = {
            //new Car("Tesla", 2021, 130, true),//100
            //new Car("Suzuki", 2011, 80, false),//80
            //new Car("BMW", 2018, 300, true),//110
            //new Car("Mercedes-Benz ", 1975, 90, false),//80
            //new Ship("Viking Longboat", 2022),//140
            //new Ship("HMS Bounty", 2011),//90
            //new Ship("Diana", 2011),//130
            //new Ship("Diana Frigate", 2016)//90
            //};

            //int i = 0;
            //foreach (var item in GetFastestVehicles(vehicles))
            //{
            //    if (i < 3)
            //    {
            //        Console.WriteLine(item.Model + " " + item.YearManufacture +
            //      " " + item.GetMaxSpeed());
            //        i++;
            //    }
            //    else
            //    {
            //        break;
            //    }
            //}

            ////2
            //PC pc = new("Apple", 8000);//400000
            //Car car1 = new("Mercedes-Benz ", 1975, 90, false);//7000000
            //Ship ship1 = new("Viking Longboat", 2022);//900000

            //OnlineMarket market1 = new() { Budget = 5000000 };//3500000
            //market1.AddItem(car1, 1000000);//+
            //market1.AddItem(pc, 200000);//+
            //market1.AddItem(ship1, 300000);//+
            //OnlineMarket market2 = new() { Budget = 3000000 };//2400000
            //market2.AddItem(pc, 200000);//+
            //market2.AddItem(car1, 80000);//-
            //market2.AddItem(ship1, 400000);//+

            //Console.WriteLine("--------------------------");
            //OnlineMarket[] market = new OnlineMarket[2];
            //market[0] = market1;
            //market[1] = market2;

            //Array.Sort(market, new OnlineMarket());
            //foreach (var item in market)
            //{
            //    Console.WriteLine(item.Budget);
            //}

            ////3
            //Car car = new("Tesla", 2021, 130, true);
            //Car car1 = new("Suzuki", 2011, 80, false);
            //Ship ship = new("Viking Longboat", 2022);
            //Ship ship1 = new("HMS Bounty", 2011);
            //PC pc = new("Apple", 8000);
            //PC pc1 = new("PRESTIGIO SmartBook 141 C7", 3000);
            //OnlineMarket market = new() { Budget = 5000000 };
            //market.AddItem(car, 1000000);
            //market.AddItem(car1, 20000);
            //market.AddItem(pc, 300000);
            //market.AddItem(pc1, 90000000);
            //market.AddItem(ship, 300000);
            //market.AddItem(ship1, 10000);

            ////4
            //Car car = new("Tesla", 2021, 130, true);
            //Car car1 = new("Suzuki", 2011, 80, false);
            //Car car2 = new("BMW", 2018, 300, true);
            //Car car3 = new("Mercedes-Benz ", 1975, 90, false);
            //Ship ship = new("Viking Longboat", 2022);
            //Ship ship1 = new("HMS Bounty", 2011);
            //Ship ship2 = new("Diana", 2011);
            //Ship ship3 = new("Diana Frigate", 2016);
            //PC pc = new("Apple", 8000);
            //PC pc1 = new("PRESTIGIO SmartBook 141 C7", 3000);
            //PC pc2 = new("HP", 8000);

            //OnlineMarket market = new() { Budget = 5000000 };

            //Dictionary<IItem, int> ItemList = new Dictionary<IItem, int>();
            //ItemList.Add(car, 1000000);
            //ItemList.Add(car1, 20000);
            //ItemList.Add(car2, 130000);
            //ItemList.Add(car3, 68000);
            //ItemList.Add(pc, 300000);
            //ItemList.Add(pc1, 90000000);
            //ItemList.Add(pc2, 7600000);
            //ItemList.Add(ship, 300000);
            //ItemList.Add(ship1, 10000);
            //ItemList.Add(ship2, 600000);
            //ItemList.Add(ship3, 350000);

            //Console.WriteLine("product։ = " + BuyItem(ItemList, market));
        }

        private static int BuyItem(Dictionary<IItem, int> ItemList, OnlineMarket market)
        {
            int count = 0;
            foreach (var item in ItemList)
            {
                if (market.AddItem(item.Key, item.Value))
                {
                    count++;
                }
            }
            return count;
        }

        private static Vehicle[] GetFastestVehicles(Vehicle[] vehicle)
        {
            Array.Sort(vehicle);
            Array.Reverse(vehicle);

            return vehicle;
        }
    }
}