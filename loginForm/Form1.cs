using System;
using System.Drawing;
using System.Windows.Forms;

namespace loginForm
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string user, pass;

            user = txt_User.Text;
            pass = txt_Pass.Text;

            if (user == "root" && pass == "root")
            {
                MessageBox.Show("Login Successful");
            }
            else
            {
                MessageBox.Show("Error");
            }
        }

        private void txt_User_Enter(object sender, EventArgs e)
        {
            if (txt_User.Text == "Username")
            {
                txt_User.Text = "";
                txt_User.ForeColor = Color.Black;
            }
        }

        private void txt_User_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txt_User.Text))
            {
                txt_User.Text = "Username";
                txt_User.ForeColor = Color.Silver;
            }
        }

        private void txt_Pass_Enter(object sender, EventArgs e)
        {
            if (txt_Pass.Text == "Password")
            {  
                txt_Pass.Text = "";
                txt_Pass.ForeColor = Color.Black;
                txt_Pass.PasswordChar = '*'; // You can use a password character like '*'
            }
        }

        private void txt_Pass_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txt_Pass.Text))
            {
                txt_Pass.Text = "Password";
                txt_Pass.ForeColor = Color.Silver;
                txt_Pass.PasswordChar = '\0'; // Reset password character
            }
        }

        private void txt_User_Layout(object sender, LayoutEventArgs e)
        {

        }
    }
}
