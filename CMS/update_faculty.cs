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
    public partial class update_faculty : Form
    {
        public update_faculty()
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

                    string query = "select faculty_id from faculty where faculty_id = " + faculty_id;
                    SqlDataAdapter sda = new SqlDataAdapter(query, conn.conn);
                    DataTable dt = new DataTable();
                    sda.Fill(dt);

                    if (dt.Rows.Count == 1)
                    {
                        this.Hide();
                        new update_faculty_final(faculty_id);
                        new update_faculty_final().Visible = true;
                    }
                    else
                    {
                        MessageBox.Show("Faculty ID is not correct", "Message");
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
