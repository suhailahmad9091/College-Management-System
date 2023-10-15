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
    public partial class update_faculty_final : Form
    {
        static string faculty_id = "";

        public update_faculty_final()
        {
            InitializeComponent();
        }

        public update_faculty_final(string a)
        {
            faculty_id = a;
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            this.Hide();
            new update_faculty().Visible = true;
        }

        private void button1_Click_1(object sender, EventArgs e)
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
                string department = cb_department.Text;
                string email = tf_email.Text;
                string password = tf_password.Text;
                string mobile_number = tf_mobile_number.Text;
                string address = tf_address.Text;

                string query = "update faculty set name = @name, gender = @gender, dob = @dob, department = @department, email = @email, password = @password, mobile_number = @mobile_number, address = @address where faculty_id = " + faculty_id;
                SqlCommand cmd = new SqlCommand(query, conn.conn);
                cmd.Parameters.AddWithValue("@name", name);
                cmd.Parameters.AddWithValue("@gender", gender);
                cmd.Parameters.AddWithValue("@dob", dob);
                cmd.Parameters.AddWithValue("@department", department);
                cmd.Parameters.AddWithValue("@email", email);
                cmd.Parameters.AddWithValue("@password", password);
                cmd.Parameters.AddWithValue("@mobile_number", mobile_number);
                cmd.Parameters.AddWithValue("@address", address);
                cmd.ExecuteNonQuery();
                conn.closeConnection();

                MessageBox.Show("Faculty Updated Successfully", "Message");

                this.Hide();
                new manage_faculty().Visible = true;
            }
        }

        private void update_faculty_final_Load(object sender, EventArgs e)
        {
            Connection_Provider conn = new Connection_Provider();
            conn.openConnection();

            string query = "select * from faculty where faculty_id = " + faculty_id;
            SqlDataAdapter sda = new SqlDataAdapter(query, conn.conn);
            DataTable dt = new DataTable();
            sda.Fill(dt);

            if (dt.Rows.Count == 1)
            {
                tf_faculty_id.Text = faculty_id;
                tf_name.Text = dt.Rows[0]["name"].ToString();
                cb_gender.Text = dt.Rows[0]["gender"].ToString();
                cb_department.Text = dt.Rows[0]["department"].ToString();
                dateTimePicker1.Text = dt.Rows[0]["dob"].ToString();
                tf_email.Text = dt.Rows[0]["email"].ToString();
                tf_password.Text = dt.Rows[0]["password"].ToString();
                tf_mobile_number.Text = dt.Rows[0]["mobile_number"].ToString();
                tf_address.Text = dt.Rows[0]["address"].ToString();
            }
        }
    }
}
