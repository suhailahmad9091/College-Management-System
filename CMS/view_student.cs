﻿using System;
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
    public partial class view_student : Form
    {
        public view_student()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            new manage_student().Visible = true;
        }

        private void view_student_Load(object sender, EventArgs e)
        {
            Connection_Provider cp = new Connection_Provider();
            cp.openConnection();

            SqlCommand cmd = new SqlCommand("select * from student", cp.conn);
            SqlDataAdapter sda = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            dataGridView1.DataSource = dt;
            cp.closeConnection();
        }
    }
}
