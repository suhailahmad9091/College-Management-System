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
    public partial class update_student_final : Form
    {
        static string student_id = "";

        public update_student_final()
        {
            InitializeComponent();
        }

        public update_student_final(string a)
        {
            student_id = a;
        }

        private void update_student_final_Load(object sender, EventArgs e)
        {
            Connection_Provider conn = new Connection_Provider();
            conn.openConnection();

            string query = "select * from student where student_id = " + student_id;
            SqlDataAdapter sda = new SqlDataAdapter(query, conn.conn);
            DataTable dt = new DataTable();
            sda.Fill(dt);

            if (dt.Rows.Count == 1)
            {
                tf_student_id.Text = student_id;
                tf_name.Text = dt.Rows[0]["name"].ToString();
                cb_gender.Text = dt.Rows[0]["gender"].ToString();
                cb_course.Text = dt.Rows[0]["course"].ToString();
                cb_batch.Text = dt.Rows[0]["batch"].ToString();
                dateTimePicker1.Text = dt.Rows[0]["dob"].ToString();
                tf_email.Text = dt.Rows[0]["email"].ToString();
                tf_password.Text = dt.Rows[0]["password"].ToString();
                tf_mobile_number.Text = dt.Rows[0]["mobile_number"].ToString();
                tf_address.Text = dt.Rows[0]["address"].ToString();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            new update_student().Visible = true;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (tf_name.Text.Equals("") || tf_mobile_number.Text.Equals("") || tf_email.Text.Equals("") || tf_password.Text.Equals("") || tf_address.Text.Equals(""))
            {
                MessageBox.Show("Please fill in every field", "Message");
            }
            else
            {
                Connection_Provider conn = new Connection_Provider();
                conn.openConnection();

                string name = tf_name.Text;
                string gender = cb_gender.Text;
                string dob = dateTimePicker1.Text;
                string course = cb_course.Text;
                string batch = cb_batch.Text;
                string email = tf_email.Text;
                string password = tf_password.Text;
                string mobile_number = tf_mobile_number.Text;
                string address = tf_address.Text;

                string query = "update student set name = @name, gender = @gender, dob = @dob, email = @email, password = @password, mobile_number = @mobile_number, address = @address, course = @course, batch = @batch where student_id = " + student_id;
                SqlCommand cmd = new SqlCommand(query, conn.conn);
                cmd.Parameters.AddWithValue("@name", name);
                cmd.Parameters.AddWithValue("@gender", gender);
                cmd.Parameters.AddWithValue("@dob", dob);
                cmd.Parameters.AddWithValue("@course", course);
                cmd.Parameters.AddWithValue("@batch", batch);
                cmd.Parameters.AddWithValue("@email", email);
                cmd.Parameters.AddWithValue("@password", password);
                cmd.Parameters.AddWithValue("@mobile_number", mobile_number);
                cmd.Parameters.AddWithValue("@address", address);
                cmd.ExecuteNonQuery();
                conn.closeConnection();

                MessageBox.Show("Student Updated Successfully", "Message");

                this.Hide();
                new manage_student().Visible = true;
            }
        }
    }
}
