using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CMS
{
    public partial class update_course_final : Form
    {
        static string course_id = "";

        public update_course_final()
        {
            InitializeComponent();
        }

        public update_course_final(string a)
        {
            course_id = a;  
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            new update_course().Visible = true;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (tf_name.Text.Equals("") || tf_description.Text.Equals("") || tf_fees.Text.Equals(""))
            {
                MessageBox.Show("Please fill in every field", "Message");
            }
            else
            {
                Connection_Provider conn = new Connection_Provider();
                conn.openConnection();

                string name = tf_name.Text;
                string duration = cb_duration.Text;
                string description = tf_description.Text;
                string fees = tf_fees.Text;
        
                string query = "update course set name = @name, description = @description, duration = @duration, fees = @fees where course_id = " + course_id;
                SqlCommand cmd = new SqlCommand(query, conn.conn);
                cmd.Parameters.AddWithValue("@name", name);
                cmd.Parameters.AddWithValue("@description", description);
                cmd.Parameters.AddWithValue("@duration", duration);
                cmd.Parameters.AddWithValue("@fees", fees);
                cmd.ExecuteNonQuery();
                conn.closeConnection();

                MessageBox.Show("Course Updated Successfully", "Message");

                this.Hide();
                new manage_course().Visible = true;
            }
        }

        private void update_course_final_Load(object sender, EventArgs e)
        {
            Connection_Provider conn = new Connection_Provider();
            conn.openConnection();

            string query = "select * from course where course_id = " + course_id;
            SqlDataAdapter sda = new SqlDataAdapter(query, conn.conn);
            DataTable dt = new DataTable();
            sda.Fill(dt);

            if (dt.Rows.Count == 1)
            {
                tf_course_id.Text = course_id;
                tf_name.Text = dt.Rows[0]["name"].ToString();
                tf_description.Text = dt.Rows[0]["description"].ToString();
                cb_duration.Text = dt.Rows[0]["duration"].ToString();
                tf_fees.Text = dt.Rows[0]["fees"].ToString();
            }
        }
    }
}
