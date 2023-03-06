using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hermes
{
    public class JewelryItems : Items
    {
        private string _matType { get; set; }
        private int _carate { get; set; }
        public JewelryItems(int id, string itemName, string itemType, int price, int quantity, string manDate, string matType, int carate) : base(id, itemName, itemType, price, quantity, manDate)
        {
            this._matType = matType;
            this._carate = carate;
        }

        public override void AddToCart()
        {
            Console.WriteLine("Item Added to Jewelry List");
        }   

        public override void Sell()
        {
            Console.WriteLine("Jewelry has been sold");
        }
    }
}
