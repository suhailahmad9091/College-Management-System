using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CMS
{
    public partial class update_student : Form
    {
        public update_student()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            new manage_student().Visible = true;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string student_id = tf_student_id.Text;

            if (student_id.Equals(""))
            {
                MessageBox.Show("Please fill in every field", "Message");
            }
            else
            {
                Regex regex = new Regex(@"^\d+$");
                if (regex.IsMatch(student_id))
                {
                    Connection_Provider conn = new Connection_Provider();
                    conn.openConnection();

                    string query = "select student_id from student where student_id = " + student_id;
                    SqlDataAdapter sda = new SqlDataAdapter(query, conn.conn);
                    DataTable dt = new DataTable();
                    sda.Fill(dt);

                    if (dt.Rows.Count == 1)
                    {
                        this.Hide();
                        new update_student_final(student_id);
                        new update_student_final().Visible = true;
                    }
                    else
                    {
                        MessageBox.Show("Student ID is not correct", "Message");
                    }
                }
                else
                {
                    MessageBox.Show("Student ID is not correct", "Message");
                }
            }
        }
    }
}
