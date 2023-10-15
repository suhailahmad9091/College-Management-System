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
    public partial class update_course : Form
    {
        public update_course()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            new manage_course().Visible = true;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string course_id = tf_course_id.Text;

            if (course_id.Equals(""))
            {
                MessageBox.Show("Please fill in every field", "Message");
            }
            else
            {
                Regex regex = new Regex(@"^\d+$");
                if (regex.IsMatch(course_id))
                {
                    Connection_Provider conn = new Connection_Provider();
                    conn.openConnection();

                    string query = "select course_id from course where course_id = " + course_id;
                    SqlDataAdapter sda = new SqlDataAdapter(query, conn.conn);
                    DataTable dt = new DataTable();
                    sda.Fill(dt);

                    if (dt.Rows.Count == 1)
                    {
                        this.Hide();
                        new update_course_final(course_id);
                        new update_course_final().Visible = true;
                    }
                    else
                    {
                        MessageBox.Show("Course ID is not correct", "Message");
                    }
                }
                else
                {
                    MessageBox.Show("Course ID is not correct", "Message");
                }
            }
        }
    }
}
