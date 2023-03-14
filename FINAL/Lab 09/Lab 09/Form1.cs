using System;
using System.IO;
using System.Windows.Forms;

namespace Lab_09
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void regLink_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Hide();
            new Registration().Show();
        }


        public void checkUser(string str)
        {
            string username = $@"E:\VS_C#\SWE_4201_210042174\FINAL\Lab 09\{str}.txt";
            string password = $@"E:\VS_C#\SWE_4201_210042174\FINAL\Lab 09\{str}.txt";

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
