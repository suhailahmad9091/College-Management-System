using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CMS
{
    public partial class manage_faculty : Form
    {
        public manage_faculty()
        {
            InitializeComponent();
        }

        private void button10_Click(object sender, EventArgs e)
        {
            this.Hide();
            new add_faculty().Visible = true;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.Hide();
            new update_faculty().Visible = true;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Hide();
            new delete_faculty().Visible = true;
        }

        private void button8_Click(object sender, EventArgs e)
        {
            this.Hide();
            new view_faculty().Visible = true;
        }

        private void button5_Click(object sender, EventArgs e)
        {
            this.Hide();
            new menu().Visible = true;
        }
    }
}
