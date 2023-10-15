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
    public partial class view_faculty : Form
    {
        public view_faculty()
        {
            InitializeComponent();
        }
        
        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            new manage_faculty().Visible = true;
        }

        private void view_faculty_Load(object sender, EventArgs e)
        {
            Connection_Provider cp = new Connection_Provider();
            cp.openConnection();

            SqlCommand cmd = new SqlCommand("select * from faculty", cp.conn);
            SqlDataAdapter sda = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            dataGridView1.DataSource = dt;
            cp.closeConnection();
        }
    }
}
