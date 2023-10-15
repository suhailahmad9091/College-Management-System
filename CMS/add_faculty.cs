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
    public partial class add_faculty : Form
    {
        int faculty_id = 1;
        
        public add_faculty()
        {
            InitializeComponent();
        }

        private void customer_register_Load(object sender, EventArgs e)
        {
            Connection_Provider conn = new Connection_Provider();
            conn.openConnection();

            string query = "select max(faculty_id) as faculty_id from faculty";
            SqlDataAdapter sda = new SqlDataAdapter(query, conn.conn);
            DataTable dt = new DataTable();
            sda.Fill(dt);

            string temp = dt.Rows[0]["faculty_id"].ToString();
            conn.closeConnection();

            if (temp.Equals(""))
            {
                tf_faculty_id.Text = faculty_id.ToString();
            }
            else
            {
                faculty_id = int.Parse(temp) + 1;
                tf_faculty_id.Text = faculty_id.ToString();
            }
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            this.Hide();
            new manage_faculty().Visible = true;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (tf_name.Text.Equals("") || tf_mobile_number.Text.Equals("") || tf_email.Text.Equals("") || tf_password.Text.Equals("") || tf_address.Text.Equals(""))
            {
                MessageBox.Show("Please fill in every field", "Message");
            }
            else
            {
                string password = tf_password.Text;
                string address = tf_address.Text;
                string gender = cb_gender.Text;
                string dob = dateTimePicker1.Text;
                string department = cb_department.Text;

                string mobile_number = "";
                string email = "";

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
                    flag = false;
                    email = tf_email.Text;
                    regex = new Regex("^[a-zA-Z0-9+_.-]+@[a-zA-Z0-9.-]+$");
                    if (regex.IsMatch(email))
                    {
                        flag = true;
                    }
                    else
                    {
                        flag = false;
                        MessageBox.Show("Please enter correct email", "Message");
                    }
                }

                if (flag == true)
                {
                    flag = false;
                    mobile_number = tf_mobile_number.Text;
                    regex = new Regex("[789][0-9]{9}");
                    if (regex.IsMatch(mobile_number))
                    {
                        flag = true;
                    }
                    else
                    {
                        flag = false;
                        MessageBox.Show("Please enter correct mobile number", "Message");
                    }
                }

                if (flag == true)
                {
                    Connection_Provider conn = new Connection_Provider();
                    conn.openConnection();

                    string query = "insert into faculty values(@faculty_id, @name, @gender, @dob, @address, @mobile_number, @email, @password, @department)";
                    SqlCommand cmd = new SqlCommand(query, conn.conn);
                    cmd.Parameters.AddWithValue("@faculty_id", faculty_id);
                    cmd.Parameters.AddWithValue("@name", name);
                    cmd.Parameters.AddWithValue("@gender", gender);
                    cmd.Parameters.AddWithValue("@dob", dob);
                    cmd.Parameters.AddWithValue("@address", address);
                    cmd.Parameters.AddWithValue("@mobile_number", mobile_number);
                    cmd.Parameters.AddWithValue("@email", email);
                    cmd.Parameters.AddWithValue("@password", password);
                    cmd.Parameters.AddWithValue("@department", department);
                    cmd.ExecuteNonQuery();

                    conn.closeConnection();

                    MessageBox.Show("Faculty Added Successfully", "Message");

                    this.Hide();
                    new manage_faculty().Visible = true;
                }
            }
        }
    }
}
