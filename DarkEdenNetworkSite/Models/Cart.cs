using DarkEdenNetworkSite.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace DarkEdenNetworkSite.Models
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

        private List<GoodsListInfo> _CartItems = new List<GoodsListInfo>();

        public List<GoodsListInfo> CartItems
        {
            get { return _CartItems; }
            set { _CartItems = value; }
        }

        public GoodsListInfo this[int index]
        {
            get
            {
                return _CartItems[index];
            }

            set
            {
                if (index < _CartItems.Count && index >= 0)
                {
                    _CartItems[index] = value;
                }
                else
                {
                    _CartItems.Add(value);
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