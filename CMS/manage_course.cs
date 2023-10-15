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
    public partial class manage_course : Form
    {
        public manage_course()
        {
            InitializeComponent();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            this.Hide();
            new menu().Visible = true;
        }

        private void button10_Click(object sender, EventArgs e)
        {
            this.Hide();
            new add_course().Visible = true;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.Hide();
            new update_course().Visible = true;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Hide();
            new delete_course().Visible = true;
        }

        private void button8_Click(object sender, EventArgs e)
        {
            this.Hide();
            new view_course().Visible = true;
        }
    }
}
