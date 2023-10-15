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
using System.Text.RegularExpressions;

namespace CMS
{
    public partial class delete_faculty : Form
    {
        public delete_faculty()
        {
            InitializeComponent();
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            this.Hide();
            new manage_faculty().Visible = true;
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            int x = 0;
            string faculty_id = tf_faculty_id.Text;

            if (faculty_id.Equals(""))
            {
                MessageBox.Show("Please fill in every field", "Message");
            }
            else
            {
                Regex regex = new Regex(@"^\d+$");
                if (regex.IsMatch(faculty_id))
                {
                    Connection_Provider conn = new Connection_Provider();
                    conn.openConnection();

                    string query = "delete from faculty where faculty_id = " + faculty_id;
                    SqlCommand cmd = new SqlCommand(query, conn.conn);
                    x = cmd.ExecuteNonQuery();
                    conn.closeConnection();

                    if (x == 0)
                    {
                        MessageBox.Show("Faculty ID is not correct", "Message");
                    }
                    else
                    {
                        MessageBox.Show("Faculty Deleted Successfully", "Message");
                        this.Hide();
                        new manage_faculty().Visible = true;
                    }
                }
                else
                {
                    MessageBox.Show("Faculty ID is not correct", "Message");
                }
            }
        }
    }
}
