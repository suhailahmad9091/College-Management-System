using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace CMS
{
    public partial class home : Form
    {
        public home()
        {
            InitializeComponent();
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            string username = tf_username.Text;
            string password = tf_password.Text;

            if (tf_username.Equals("") || password.Equals(""))
            {
                MessageBox.Show("Please fill in every field", "Message");
            }
            else if (username.Equals("nancy") && password.Equals("12345"))
            {
                this.Hide();
                new menu().Visible = true;
            }
            else
            {
                MessageBox.Show("Username and Password is not Correct", "Message");
            }
        }
    }
}