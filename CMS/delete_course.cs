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
    public partial class delete_course : Form
    {
        public delete_course()
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
            int x = 0;
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

                    string query = "delete from course where course_id = " + course_id;
                    SqlCommand cmd = new SqlCommand(query, conn.conn);
                    x = cmd.ExecuteNonQuery();
                    conn.closeConnection();

                    if (x == 0)
                    {
                        MessageBox.Show("Course ID is not correct", "Message");
                    }
                    else
                    {
                        MessageBox.Show("Course Deleted Successfully", "Message");
                        this.Hide();
                        new manage_course().Visible = true;
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
