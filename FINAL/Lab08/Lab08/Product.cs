using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab08
{
    public class Product
    {
        public int _id { get; set; }
        public string _name { get; set; }
        public int _price { get; set; }
        public int _invLevel { get; set; }
        public int _minInvLevel { get; set; }
        public int _reqAmount { get; set ; }

        public Product(int id, string name, int price, int invLevel, int minInvLevel, int reqAmount)
        {
            this._id = id;
            this._name = name;
            this._price = price;
            this._invLevel = invLevel;
            this._minInvLevel = minInvLevel;
            this._reqAmount = reqAmount;
        }

        public void AddQuantity(int amount)
        {
            _invLevel += amount;
        }

    }
}
