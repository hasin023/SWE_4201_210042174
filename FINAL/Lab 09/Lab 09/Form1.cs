using System;
using System.IO;
using System.Windows.Forms;

namespace Lab_09
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void regLink_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Hide();
        }


        public void checkUser(string str)
        {
            string username = $@"E:\VS_C#\Lab009\usernames\{str}.txt";
            string password = $@"E:\VS_C#\Lab009\passwords\{str}.txt";

            if (File.Exists(username) && File.Exists(password))
            {
                string[] users = File.ReadAllLines(username);
                string[] pass = File.ReadAllLines(password);

                foreach (string u in users)
                {
                    if (usertxt.Text == u)
                    {
                        foreach (string p in pass)
                        {
                            if (passtxt.Text == p)
                            {
                                this.Hide();

                            }
                            else
                            {
                                MessageBox.Show("Incorrect Password", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            }
                        }
                    }
                    else
                    {
                        MessageBox.Show("Account does not exist", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
            else
            {
                MessageBox.Show("Account does not exist", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void loginClick_Click(object sender, EventArgs e)
        {
            checkUser(usertxt.Text);
        }
    }
}
