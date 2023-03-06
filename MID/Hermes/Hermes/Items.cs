using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hermes
{
    public abstract class Items
    {
        protected int _id { get; set; }
        protected string _itemName { get; set; }
        protected string _itemType{ get; set; }
        public int _price { get; set; }
        public int _quantity { get; set; }
        protected string _manDate { get; set; }

        public Items(int id, string itemName, string itemType, int price, int quantity, string manDate) 
        {
            this._id = id;
            this._itemName = itemName;
            this._itemType = itemType;
            this._price = price;
            this._quantity = quantity;
            this._manDate = manDate;
        }

        public abstract void AddToCart();
        public abstract void Sell();

    }
}
