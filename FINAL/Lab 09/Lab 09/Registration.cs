using System;
using System.IO;
using System.Windows.Forms;

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
            string newUsername = $@"E:\VS_C#\SWE_4201_210042174\FINAL\Lab 09\{str}.txt";
            string newPassword = $@"E:\VS_C#\SWE_4201_210042174\FINAL\Lab 09\{str}.txt";
            string newName = $@"E:\VS_C#\SWE_4201_210042174\FINAL\Lab 09\{str}.txt";

            using (StreamWriter writer = new StreamWriter(newUsername))
            {
                writer.Write(usertxt.Text);
            }

            using (StreamWriter writer = new StreamWriter(newPassword))
            {
                writer.Write(passtxt.Text);
            }

            using (StreamWriter writer = new StreamWriter(newName))
            {
                writer.Write(nametxt.Text);
            }
        }

        private void regClick_Click(object sender, EventArgs e)
        {
            regUser(usertxt.Text);
            MessageBox.Show("Account successfully created!!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            this.Hide();
            new Login().Show();
        }
    }
}
