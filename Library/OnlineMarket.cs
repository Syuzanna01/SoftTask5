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
        public int AddItem(IItem item, int price,int count)
        {
            try
            {
                if (item.GetPrice() > Budget )
                {
                    count--;
                    throw new Exeption();
                }
                else if( item.GetPrice() < price)
                {
                    count--;
                    throw new Eeption();
                }
                else
                {
                    items.Add(item);
                    Budget -= price;
                }
            }
            catch (Exeption)
            {
                Console.WriteLine(item.Model + " purchase failed the amount is not enough");
            }
            catch(Eeption )
            {
                Console.WriteLine(item.Model + " purchase failed the price is greater than the market price");
            }
            return count;
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