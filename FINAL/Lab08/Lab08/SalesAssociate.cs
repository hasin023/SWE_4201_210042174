using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab08
{
    public class SalesAssociate : Employee
    {
        private Store _s1 {  get; set; }
        private double _bonus { get; set; }
        private double _totalSalary { get; set; }

        public SalesAssociate(string name, int age, int salary) : base(name, age, salary)
        {
        }

        public void sellProduct(int id, int quantity, Store s1)
        {
            foreach (Product p in s1.products)
            {
                int left = p._invLevel - quantity;

                if (p._id == id && left > p._minInvLevel)
                {
                    p._invLevel -= quantity;
                    _bonus = p._price * 0.01;
                    _totalSalary += _bonus;

                    Console.WriteLine($"Product Sold");
                }
               
            }

            
        }
    }
}
