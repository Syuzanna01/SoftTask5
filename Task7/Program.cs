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
            //List<IItem> list1 = new List<IItem>()
            //{
            //     new Car("Tesla", 2021, 130, true),
            //     new Car("Suzuki", 2011, 80, false),
            //     new Ship("Viking Longboat", 2022),
            //};

            //List<IItem> list2 = new List<IItem>()
            //{
            //     new Ship("Viking Longboat", 2022),
            //     new Ship("HMS Bounty", 2011),
            //     new PC("Apple", 8000),
            //     new PC("PRESTIGIO SmartBook 141 C7", 3000),
            //};

            //OnlineMarket market1 = new OnlineMarket() { Budget=150000};
            //market1.OMarket(list1);
            //OnlineMarket market2 = new OnlineMarket() { Budget=250000};
            //market2.OMarket(list2);

            //Console.WriteLine(market1 < market2);
            //Console.WriteLine(market1 > market2);
            //Console.WriteLine();

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
                try
                {
                    market.AddItem(item.Key, item.Value);
                    count++;
                }
                catch (DontBuyItem)
                {
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