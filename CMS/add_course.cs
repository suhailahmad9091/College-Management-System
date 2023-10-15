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
    public partial class add_course : Form
    {
        int course_id = 1;

        public add_course()
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
            if (tf_name.Text.Equals("") || tf_description.Text.Equals("") || tf_fees.Text.Equals(""))
            {
                MessageBox.Show("Please fill in every field", "Message");
            }
            else
            {
                string duration = cb_duration.Text;

                string description = "";
                string fees = "";
                
                Boolean flag;

                flag = false;
                string name = tf_name.Text;
                Regex regex = new Regex(@"^[a-zA-Z\s.()]+$");
                if (regex.IsMatch(name))
                {
                    flag = true;
                }
                else
                {
                    flag = false;
                    MessageBox.Show("Please enter correct name", "Message");
                }

                if (flag == true)
                {
                    flag = false;
                    description = tf_description.Text;
                    regex = new Regex(@"^[a-zA-Z\s]+$");
                    if (regex.IsMatch(description))
                    {
                        flag = true;
                    }
                    else
                    {
                        flag = false;
                        MessageBox.Show("Please enter correct description", "Message");
                    }
                }

                if(flag==true)
                {
                    flag = false;
                    fees = tf_fees.Text;
                    regex = new Regex(@"^\d+$");
                    if (regex.IsMatch(fees))
                    {
                        flag = true;
                    }
                    else
                    {
                        flag = false;
                        MessageBox.Show("Please enter correct fees", "Message");
                    }
                }

                if (flag == true)
                {
                    Connection_Provider conn = new Connection_Provider();
                    conn.openConnection();

                    string query = "insert into course values(@course_id, @name, @description, @duration, @fees)";
                    SqlCommand cmd = new SqlCommand(query, conn.conn);
                    cmd.Parameters.AddWithValue("@course_id", course_id);
                    cmd.Parameters.AddWithValue("@name", name);
                    cmd.Parameters.AddWithValue("@description", description);
                    cmd.Parameters.AddWithValue("@duration", duration);
                    cmd.Parameters.AddWithValue("@fees", fees);
                    cmd.ExecuteNonQuery();
                    conn.closeConnection();

                    MessageBox.Show("Course Added Successfully", "Message");

                    this.Hide();
                    new manage_course().Visible = true;
                }
            }
        }

        private void add_course_Load(object sender, EventArgs e)
        {
            Connection_Provider conn = new Connection_Provider();
            conn.openConnection();

            string query = "select max(course_id) as course_id from course";
            SqlDataAdapter sda = new SqlDataAdapter(query, conn.conn);
            DataTable dt = new DataTable();
            sda.Fill(dt);

            string temp = dt.Rows[0]["course_id"].ToString();
            conn.closeConnection();

            if (temp.Equals(""))
            {
                tf_course_id.Text = course_id.ToString();
            }
            else
            {
                course_id = int.Parse(temp) + 1;
                tf_course_id.Text = course_id.ToString();
            }
        }
    }
}
