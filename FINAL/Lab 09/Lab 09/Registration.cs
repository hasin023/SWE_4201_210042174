using System;
using System.IO;
using System.Windows.Forms;
using System.Xml.Linq;

namespace Lab_09
{
    public partial class Registration : Form
    {
        public Registration()
        {
            InitializeComponent();
        }

        private void loginLink_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Hide();
            new Login().Show();
        }

        public void regUser(string str)
        {
            string newUser = $@"E:\VS_C#\SWE_4201_210042174\FINAL\Lab 09\Users\{str}.txt";

            using (StreamWriter writer = new StreamWriter(newUser))
            {
                writer.Write("un:" + usertxt.Text);
                writer.Write('\n');
                if (passtxt.Text.Length >= 6)
                {
                    writer.Write("pass:" + passtxt.Text);
                    writer.Write('\n');
                    
                }
                else
                {
                    MessageBox.Show("Password must be at least 6 characters!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

                writer.Write("nm:" + nametxt.Text);
                writer.Write('\n');

            }
        }

        private void regClick_Click(object sender, EventArgs e)
        {
            if (passtxt.Text.Length >= 6)
            {
                regUser(usertxt.Text);
                MessageBox.Show("Account successfully created!!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Hide();
                new Login().Show();
                
            }
            else
            {
                MessageBox.Show("Password must be at least 6 characters!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            
        }
    }
}
