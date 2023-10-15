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
    public partial class view_subject : Form
    {
        public view_subject()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            new manage_subject().Visible = true;
        }

        private void view_subject_Load(object sender, EventArgs e)
        {
            Connection_Provider cp = new Connection_Provider();
            cp.openConnection();

            SqlCommand cmd = new SqlCommand("select * from subject", cp.conn);
            SqlDataAdapter sda = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            dataGridView1.DataSource = dt;
            cp.closeConnection();
        }
    }
}
