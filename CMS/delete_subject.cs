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
    public partial class delete_subject : Form
    {
        public delete_subject()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            new manage_subject().Visible = true;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int x = 0;
            string subject_id = tf_subject_id.Text;

            if (subject_id.Equals(""))
            {
                MessageBox.Show("Please fill in every field", "Message");
            }
            else
            {
                Regex regex = new Regex(@"^\d+$");
                if (regex.IsMatch(subject_id))
                {
                    Connection_Provider conn = new Connection_Provider();
                    conn.openConnection();

                    string query = "delete from subject where subject_id = " + subject_id;
                    SqlCommand cmd = new SqlCommand(query, conn.conn);
                    x = cmd.ExecuteNonQuery();
                    conn.closeConnection();

                    if (x == 0)
                    {
                        MessageBox.Show("Subject ID is not correct", "Message");
                    }
                    else
                    {
                        MessageBox.Show("Subject Deleted Successfully", "Message");
                        this.Hide();
                        new manage_subject().Visible = true;
                    }
                }
                else
                {
                    MessageBox.Show("Subject ID is not correct", "Message");
                }
            }
        }
    }
}
