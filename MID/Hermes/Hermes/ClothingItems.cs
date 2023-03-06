using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hermes
{
    public sealed class ClothingItems : Items
    {
        private int _size { get; set; }
        private string _color { get; set; }
        private string _fabric { get; set; }
        public ClothingItems(int id, string itemName, string itemType, int price, int quantity, string manDate, int size, string color, string fabric) : base(id, itemName, itemType, price, quantity, manDate)
        {
            this._size= size;
            this._fabric= fabric;
            this._color= color;
        }

        public override void AddToCart()
        {
            Console.WriteLine("Item Added to Clothing List");
        }

        public override void Sell()
        {
            Console.WriteLine("Cloth has been Sold");
        }
    }
}
