using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library
{
    public class OnlineMarket
    {
        List<IItem> items = new List<IItem>();

        public void OMarket(List<IItem> list)
        {
            items = list;
        }

        public int Budget { get; set; }
        public void AddItem(IItem item, int price)
        {
            if (item.GetPrice() > Budget)
            {
                throw new DontBuyItem();
            }
            else if (item.GetPrice() < price)
            {
                throw new DontBuyItem();
            }
            else
            {
                items.Add(item);
                Budget -= price;
            }
        }

        public static bool operator <(OnlineMarket market1, OnlineMarket market2)
        {
            decimal product1 = 0;
            decimal product2 = 0;
            foreach (var item in market1.items)
            {
                product1 += item.GetPrice();
            }

            foreach (var item in market2.items)
            {
                product2 += item.GetPrice();
            }
            if (market1.Budget > market2.Budget)
            {
                return true;
            }
            else if (product2 > product1)
            {
                return false;
            }
            else
                return false;
        }

        public static bool operator >(OnlineMarket market1, OnlineMarket market2)
        {
            decimal sum1 = 0;
            decimal sum2 = 0;
            foreach (var item in market1.items)
            {
                sum1 += item.GetPrice();
            }

            foreach (var item in market2.items)
            {
                sum2 += item.GetPrice();
            }

            return (market1.Budget + sum1).CompareTo(market2.Budget + sum2) > 0;
        }
    }
}