using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library
{
    public class OnlineMarket : IComparer<OnlineMarket>
    {
        List<IItem> items = new List<IItem>();
        public int Budget { get; set; }
        public bool AddItem(IItem item, int price)
        {
            bool buy = false;
            try
            {
                if (item.GetPrice() > Budget)
                {
                    throw new Exeption();
                }
                else if (item.GetPrice() < price)
                {
                    throw new Eeption();
                }
                else
                {
                    buy = true;
                    items.Add(item);
                    Budget -= price;
                }
            }
            catch (Exeption)
            {
                Console.WriteLine(item.Model + " purchase failed the amount is not enough");
            }
            catch (Eeption)
            {
                Console.WriteLine(item.Model + " purchase failed the price is greater than the market price");
            }
            return buy;
        }

        public int Compare(OnlineMarket? x, OnlineMarket? y)
        {
            if (x.Budget > y.Budget)
                return 1;
            if (x.items.Count < y.items.Count)
                return -1;
            else
                return 0;
        }
    }
}