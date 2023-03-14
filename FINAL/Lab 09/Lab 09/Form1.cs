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
            string user = $@"E:\VS_C#\SWE_4201_210042174\FINAL\Lab 09\Users\{str}.txt";

            if (File.Exists(user))
            {
                string[] users = File.ReadAllLines(user);

                foreach (string u in users)
                {
                    if (u.Contains("un:"))
                    {
                        if (usertxt.Text == u.Remove(0, 3))
                        {
                            foreach (string p in users)
                            {
                                if (p.Contains("pass:"))
                                {
                                    if (passtxt.Text == p.Remove(0, 5))
                                    {
                                        this.Hide();
                                        new Dashboard().Show();
                                    }
                                    else
                                    {
                                        MessageBox.Show("Incorrect Password", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                    }
                                }
                            }
                        }
                        else
                        {
                            MessageBox.Show("Account does not exist", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
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
