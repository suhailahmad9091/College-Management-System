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
    public partial class update_subject : Form
    {
        public update_subject()
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

                    string query = "select subject_id from subject where subject_id = " + subject_id;
                    SqlDataAdapter sda = new SqlDataAdapter(query, conn.conn);
                    DataTable dt = new DataTable();
                    sda.Fill(dt);

                    if (dt.Rows.Count == 1)
                    {
                        this.Hide();
                        new update_subject_final(subject_id);
                        new update_subject_final().Visible = true;
                    }
                    else
                    {
                        MessageBox.Show("Subject ID is not correct", "Message");
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
