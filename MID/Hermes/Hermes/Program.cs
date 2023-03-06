using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hermes
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<ClothingItems> clothingItems = new List<ClothingItems>();
            List<JewelryItems> jewelryItems= new List<JewelryItems>();

            ClothingItems _temp = new ClothingItems(0023, "Tops","Regular", 24, 5, "22-10-2023",12,"Blue","Silk");
            clothingItems.Add(_temp);

            JewelryItems _tempJ = new JewelryItems(0027, "Necklace", "Limited", 2400, 2, "27-10-2023", "Gold", 24);
            jewelryItems.Add(_tempJ);
        }
    }
}
