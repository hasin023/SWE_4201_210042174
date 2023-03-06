using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab08
{
    public class Store
    {
        public Store() { }

        public List<Product> products = new List<Product>();
        private Manager MichaelScott = new Manager("Michael Scott", 42, 40000);
        private SalesAssociate JimHalpert = new SalesAssociate("Jim Halpert", 28, 30000);
        private SalesAssociate PamBeesly = new SalesAssociate("Pam Beesly", 25, 30000);

        public void showStoreDetails()
        {
            Console.WriteLine($"Manager : {MichaelScott._name}" + "\n" +
                $"SalesAssociate : {JimHalpert._name} , {PamBeesly._name}" + "\n" +
                $"Products : {products.Count}");
        }
    }
}
