using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SupermarketManagementSystem
{
	public partial class Login : Form
	{
		public Login()
		{
			InitializeComponent();
		}

		
        private void label1_Click(object sender, EventArgs e)
		{

		}

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void Login_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {


            if (textUsername.Text == "ruveyda" && textPassword.Text == "market12") 
            {
                new MainPage().Show();
                this.Hide();

            }
            else
            {
                label7.Visible = true;
                textUsername.Clear();
                textPassword.Clear();
                textUsername.Focus();
            }

            
        }

        private void label2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void showPassword_Click(object sender, EventArgs e)
        {
            if (textPassword.PasswordChar == '*')
            {
                hidePassword.BringToFront();
                textPassword.PasswordChar = '\0';
            }
        }

        private void hidePassword_Click(object sender, EventArgs e)
        {
            if (textPassword.PasswordChar == '\0')
            {
                showPassword.BringToFront();
                textPassword.PasswordChar = '*';
            }
        }
    }
}
