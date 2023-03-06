using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Principal;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Banking_Management_System
{
    public partial class _bms : Form
    {
            bankAccount newAccount = new bankAccount(131, "Hasin" , "Uttara" , "Current", 500.00);
            List<bankAccount> accList = new List<bankAccount>();
        public _bms()
        {

            InitializeComponent();
            accList.Add(newAccount);


            typeComboBox.Items.Add("Savings");
            typeComboBox.Items.Add("Current");
            typeComboBox.Items.Add("DPS");

            branchComboBox.Items.Add("Uttara");
            branchComboBox.Items.Add("Gazipur");
            branchComboBox.Items.Add("Mirpur");
            branchComboBox.Items.Add("Dhanmondi");
            branchComboBox.Items.Add("Gulshan");

            accNumberBox.Text = Convert.ToString(accList.Count + 1);
        }

        
        private void createAcc_Click(object sender, EventArgs e)
        {
           
                string name = userNameBox.Text;
                string branch = branchComboBox.Text;
                string accountType = typeComboBox.Text;
            
                int accNo = accList.Count;
                double initialDeposit = double.Parse(initialDepoBox.Text);

                accList.Add(newAccount);

                userNameBox.Clear();
                initialDepoBox.Clear();

                
                accNumberBox.Text = Convert.ToString(accList.Count + 1);


            MessageBox.Show("Account Has been Created", "Successful", MessageBoxButtons.OK, MessageBoxIcon.Information);

                
        }

        private void withdrawButton_Click(object sender, EventArgs e)
        {
            double _amount = double.Parse(amountBox.Text);

            bool res = newAccount.withdraw(_amount);
            if (res)
            {
                MessageBox.Show("Withdraw Successful", "Successful", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Insufficient Balance!! Withdraw Unsuccessful", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void showBalButton_Click(object sender, EventArgs e)
        {
            MessageBox.Show($"Balance : {newAccount.getBalance()} ", "Successful", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void depositButton_Click(object sender, EventArgs e)
        {
            newAccount.deposit(double.Parse(amountBox.Text));
            MessageBox.Show("Deposit Successful", "Successful", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void suspendButton_Click(object sender, EventArgs e)
        {

        }

        private void showButton_Click(object sender, EventArgs e)
        {

        }
    }
}
