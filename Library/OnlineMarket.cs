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
        public int Budget { get; set; }
        public void AddItem(IItem item,int price)
        {
            if (item.GetPrice() < Budget&&item.GetPrice()>price)
            {
                items.Add(item);
                Budget -= item.GetPrice();
            }
        }
    }
}