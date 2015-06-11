using DarkEdenNetworkSite.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace DarkEdenWebsite.Models
{
    public class Cart
    {
        public Cart(User Owner)
        {
            _Owner = Owner;
        }

        private User _Owner;

        public User Owner
        {
            get { return _Owner; }
        }

        private Dictionary<GoodsListInfo, int> _CartItems = new Dictionary<GoodsListInfo, int>();

        public Dictionary<GoodsListInfo, int> CartItems
        {
            get { return _CartItems; }
            set { _CartItems = value; }
        }

        public int this[GoodsListInfo item]
        {
            get
            {
                return _CartItems[item];
            }

            set
            {
                if (_CartItems.ContainsKey(item))
                {
                    _CartItems[item] += value;
                }
                else
                {
                    _CartItems.Add(item, value);
                }
            }
        }

        public void RemoveItem(GoodsListInfo i)
        {
            _CartItems.Remove(i);
        }

        public int Count()
        {
            return _CartItems.Count();
        }
    }
}