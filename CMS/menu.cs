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
    public partial class menu : Form
    {
        public menu()
        {
            InitializeComponent();
        }

        private void button10_Click(object sender, EventArgs e)
        {
            this.Hide();
            new manage_faculty().Visible = true;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.Hide();
            new manage_student().Visible = true;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Hide();
            new manage_course().Visible = true;
        }

        private void button8_Click(object sender, EventArgs e)
        {
            this.Hide();
            new manage_subject().Visible = true;
        }

        private void button5_Click(object sender, EventArgs e)
        {
            this.Hide();
            new home().Visible = true;
        }
    }
}
