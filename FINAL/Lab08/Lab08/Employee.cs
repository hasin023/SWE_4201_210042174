using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab08
{
    public abstract class Employee
    {

        public string _name {get;set;}
        private int _age { get;set;}
        private int _baseSalary { get;set;}

        public Employee(string name, int age, int baseSalary)
        {
            this._name = name;
            this._age = age;
            this._baseSalary = baseSalary;
        }

        public void showEmployeeInfo()
        {
            Console.WriteLine($"Name: {_name}" + "\n" +
                $"Age : {_age}" + "\n" +
                $"Salary: {_baseSalary}");
        }


    }
}
