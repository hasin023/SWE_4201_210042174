using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Banking_Management_System
{
    internal class bankAccount
    {
        private int accNo;
        private string userName;
        private string branchName;
        private double balance;
        private string type;


        public bankAccount(int _accNo, string _userName , string _branchName , string _type, double _balance)
        {
            accNo = _accNo;
            userName = _userName;
            branchName = _branchName;
            balance = _balance;
            type = _type;

        }


        public void deposit(double amount)
        {
            balance += amount;
        }

        public bool withdraw(double amount)
        {
            if(balance > amount)
            {
                balance -= amount;
                return true;
            }
            else
            {
                return false;
            }
        }

        public double getBalance()
        {
            return balance;
        }
    }
}
