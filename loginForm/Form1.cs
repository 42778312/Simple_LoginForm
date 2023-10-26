using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading.Tasks;
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

            if (user == "root"&& pass == "root")
            {
                MessageBox.Show("Login Successful");
            }
            else
            {
                MessageBox.Show("Error");
            }
        }
    }
}
