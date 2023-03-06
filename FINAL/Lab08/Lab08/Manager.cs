using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab08
{
    public class Manager : Employee
    {
        private Store _s1 { get; set; }
        public Manager(string name, int age, int salary) : base(name, age, salary)
        {
        }

        public void addProduct(int id, string name, int price, int invLevel, int minInvLevel, int reqAmount, Store s1)
        {
            s1.products.Add(new Product(id, name, price, invLevel, minInvLevel, reqAmount));
            Console.WriteLine($"Product added");
        }

        public void sendRequisition(Store MyStore)
        {
            foreach(Product P in MyStore.products)
            {
                if(P._invLevel < P._minInvLevel)
                {
                    P._reqAmount = P._minInvLevel - P._invLevel;
                }
            }
            Console.WriteLine($"Requisition sent");
        }

        public void addExistingProduct(int id, int quantity, Store s1)
        {
            foreach(Product p in s1.products)
            {
                if(p._id == id)
                {
                    p._invLevel += quantity;
                }
            }

            Console.WriteLine($"Existing Product added");
        }
    
    }
}
