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
    public partial class add_subject : Form
    {
        int subject_id = 1;

        public add_subject()
        {
            InitializeComponent();
        }

        private void add_subject_Load(object sender, EventArgs e)
        {
            Connection_Provider conn = new Connection_Provider();
            conn.openConnection();

            string query = "select max(subject_id) as subject_id from subject";
            SqlDataAdapter sda = new SqlDataAdapter(query, conn.conn);
            DataTable dt = new DataTable();
            sda.Fill(dt);

            string temp = dt.Rows[0]["subject_id"].ToString();
            conn.closeConnection();

            if (temp.Equals(""))
            {
                tf_subject_id.Text = subject_id.ToString();
            }
            else
            {
                subject_id = int.Parse(temp) + 1;
                tf_subject_id.Text = subject_id.ToString();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            new manage_subject().Visible = true;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (tf_name.Text.Equals(""))
            {
                MessageBox.Show("Please fill in every field", "Message");
            }
            else
            {
                string course = cb_course.Text;

                Boolean flag;

                flag = false;
                string name = tf_name.Text;
                Regex regex = new Regex(@"^[a-zA-Z\s]+$");
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
                    Connection_Provider conn = new Connection_Provider();
                    conn.openConnection();

                    string query = "insert into subject values(@subject_id, @course, @name)";
                    SqlCommand cmd = new SqlCommand(query, conn.conn);
                    cmd.Parameters.AddWithValue("@subject_id", subject_id);
                    cmd.Parameters.AddWithValue("@course", course);
                    cmd.Parameters.AddWithValue("@name", name);
                    cmd.ExecuteNonQuery();
                    conn.closeConnection();

                    MessageBox.Show("Subject Added Successfully", "Message");

                    this.Hide();
                    new manage_subject().Visible = true;
                }
            }
        }
    }
}
