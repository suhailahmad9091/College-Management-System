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
    public partial class update_subject_final : Form
    {
        static string subject_id = "";

        public update_subject_final()
        {
            InitializeComponent();
        }

        public update_subject_final(string a)
        {
            subject_id = a;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            new update_subject().Visible = true;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (tf_name.Text.Equals(""))
            {
                MessageBox.Show("Please fill in every field", "Message");
            }
            else
            {
                Connection_Provider conn = new Connection_Provider();
                conn.openConnection();

                string course = cb_course.Text;
                string name = tf_name.Text;
                
                string query = "update subject set course = @course, name = @name where subject_id = " + subject_id;
                SqlCommand cmd = new SqlCommand(query, conn.conn);
                cmd.Parameters.AddWithValue("@name", name);
                cmd.Parameters.AddWithValue("@course", course);
                cmd.ExecuteNonQuery();
                conn.closeConnection();

                MessageBox.Show("Subject Updated Successfully", "Message");

                this.Hide();
                new manage_subject().Visible = true;
            }
        }

        private void update_subject_final_Load(object sender, EventArgs e)
        {
            Connection_Provider conn = new Connection_Provider();
            conn.openConnection();

            string query = "select * from subject where subject_id = " + subject_id;
            SqlDataAdapter sda = new SqlDataAdapter(query, conn.conn);
            DataTable dt = new DataTable();
            sda.Fill(dt);

            if (dt.Rows.Count == 1)
            {
                tf_subject_id.Text = subject_id;
                cb_course.Text = dt.Rows[0]["course"].ToString();
                tf_name.Text = dt.Rows[0]["name"].ToString();
            }
        }
    }
}
