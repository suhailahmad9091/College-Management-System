namespace CMS
{
    partial class add_student
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.cb_course = new System.Windows.Forms.ComboBox();
            this.label9 = new System.Windows.Forms.Label();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.label7 = new System.Windows.Forms.Label();
            this.cb_gender = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.tf_password = new System.Windows.Forms.TextBox();
            this.tf_email = new System.Windows.Forms.TextBox();
            this.tf_mobile_number = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.tf_address = new System.Windows.Forms.TextBox();
            this.tf_name = new System.Windows.Forms.TextBox();
            this.tf_student_id = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.cb_batch = new System.Windows.Forms.ComboBox();
            this.label10 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // cb_course
            // 
            this.cb_course.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.cb_course.FormattingEnabled = true;
            this.cb_course.Items.AddRange(new object[] {
            "BCA",
            "MCA",
            "BBA",
            "MBA",
            "BE/B.Tech",
            "B.Arch",
            "B.Sc (IT)",
            "B.Sc (Nursing)",
            "BPharma",
            "B.Sc (Interior Design)",
            "BDS"});
            this.cb_course.Location = new System.Drawing.Point(174, 261);
            this.cb_course.Name = "cb_course";
            this.cb_course.Size = new System.Drawing.Size(243, 26);
            this.cb_course.TabIndex = 47;
            this.cb_course.Text = "-- Select --";
            // 
            // label9
            // 
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label9.ForeColor = System.Drawing.Color.Black;
            this.label9.Location = new System.Drawing.Point(31, 261);
            this.label9.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(86, 32);
            this.label9.TabIndex = 46;
            this.label9.Text = "course";
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.dateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePicker1.Location = new System.Drawing.Point(174, 201);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(243, 26);
            this.dateTimePicker1.TabIndex = 45;
            // 
            // label7
            // 
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label7.ForeColor = System.Drawing.Color.Black;
            this.label7.Location = new System.Drawing.Point(33, 200);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(84, 29);
            this.label7.TabIndex = 44;
            this.label7.Text = "D O B";
            // 
            // cb_gender
            // 
            this.cb_gender.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.cb_gender.FormattingEnabled = true;
            this.cb_gender.Items.AddRange(new object[] {
            "Male",
            "Female"});
            this.cb_gender.Location = new System.Drawing.Point(174, 149);
            this.cb_gender.Name = "cb_gender";
            this.cb_gender.Size = new System.Drawing.Size(243, 26);
            this.cb_gender.TabIndex = 43;
            this.cb_gender.Text = "-- Select --";
            // 
            // label4
            // 
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label4.ForeColor = System.Drawing.Color.Black;
            this.label4.Location = new System.Drawing.Point(31, 149);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(108, 32);
            this.label4.TabIndex = 42;
            this.label4.Text = "Gender";
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.IndianRed;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.button2.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.button2.Location = new System.Drawing.Point(304, 408);
            this.button2.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(108, 38);
            this.button2.TabIndex = 36;
            this.button2.Text = "Back";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.MediumSpringGreen;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.button1.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.button1.Location = new System.Drawing.Point(598, 408);
            this.button1.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(106, 38);
            this.button1.TabIndex = 34;
            this.button1.Text = "Add";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // tf_password
            // 
            this.tf_password.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.tf_password.Location = new System.Drawing.Point(652, 97);
            this.tf_password.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.tf_password.Multiline = true;
            this.tf_password.Name = "tf_password";
            this.tf_password.PasswordChar = '*';
            this.tf_password.Size = new System.Drawing.Size(363, 26);
            this.tf_password.TabIndex = 30;
            // 
            // tf_email
            // 
            this.tf_email.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.tf_email.Location = new System.Drawing.Point(651, 35);
            this.tf_email.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.tf_email.Multiline = true;
            this.tf_email.Name = "tf_email";
            this.tf_email.Size = new System.Drawing.Size(363, 26);
            this.tf_email.TabIndex = 29;
            // 
            // tf_mobile_number
            // 
            this.tf_mobile_number.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.tf_mobile_number.Location = new System.Drawing.Point(655, 152);
            this.tf_mobile_number.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.tf_mobile_number.Multiline = true;
            this.tf_mobile_number.Name = "tf_mobile_number";
            this.tf_mobile_number.Size = new System.Drawing.Size(363, 26);
            this.tf_mobile_number.TabIndex = 31;
            // 
            // label8
            // 
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label8.ForeColor = System.Drawing.Color.Black;
            this.label8.Location = new System.Drawing.Point(470, 38);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(66, 30);
            this.label8.TabIndex = 41;
            this.label8.Text = "Email";
            // 
            // tf_address
            // 
            this.tf_address.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.tf_address.Location = new System.Drawing.Point(655, 207);
            this.tf_address.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.tf_address.Multiline = true;
            this.tf_address.Name = "tf_address";
            this.tf_address.Size = new System.Drawing.Size(363, 81);
            this.tf_address.TabIndex = 32;
            // 
            // tf_name
            // 
            this.tf_name.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.tf_name.Location = new System.Drawing.Point(174, 97);
            this.tf_name.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.tf_name.Multiline = true;
            this.tf_name.Name = "tf_name";
            this.tf_name.Size = new System.Drawing.Size(243, 26);
            this.tf_name.TabIndex = 28;
            // 
            // tf_student_id
            // 
            this.tf_student_id.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.tf_student_id.Location = new System.Drawing.Point(174, 37);
            this.tf_student_id.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.tf_student_id.Multiline = true;
            this.tf_student_id.Name = "tf_student_id";
            this.tf_student_id.ReadOnly = true;
            this.tf_student_id.Size = new System.Drawing.Size(243, 26);
            this.tf_student_id.TabIndex = 38;
            // 
            // label6
            // 
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label6.ForeColor = System.Drawing.Color.Black;
            this.label6.Location = new System.Drawing.Point(467, 100);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(115, 23);
            this.label6.TabIndex = 40;
            this.label6.Text = "Password";
            // 
            // label5
            // 
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label5.ForeColor = System.Drawing.Color.Black;
            this.label5.Location = new System.Drawing.Point(470, 203);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(98, 27);
            this.label5.TabIndex = 39;
            this.label5.Text = "Address";
            // 
            // label3
            // 
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label3.ForeColor = System.Drawing.Color.Black;
            this.label3.Location = new System.Drawing.Point(467, 152);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(163, 29);
            this.label3.TabIndex = 37;
            this.label3.Text = "Mobile Number";
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(31, 91);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(98, 32);
            this.label1.TabIndex = 35;
            this.label1.Text = "Name";
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(31, 36);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(108, 32);
            this.label2.TabIndex = 33;
            this.label2.Text = "Student ID";
            // 
            // cb_batch
            // 
            this.cb_batch.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.cb_batch.FormattingEnabled = true;
            this.cb_batch.Items.AddRange(new object[] {
            "2022-24",
            "2022-25",
            "2022-26",
            "2023-25",
            "2023-26",
            "2023-27",
            "2024-26",
            "2024-27",
            "2024-28"});
            this.cb_batch.Location = new System.Drawing.Point(174, 313);
            this.cb_batch.Name = "cb_batch";
            this.cb_batch.Size = new System.Drawing.Size(243, 26);
            this.cb_batch.TabIndex = 49;
            this.cb_batch.Text = "-- Select --";
            // 
            // label10
            // 
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label10.ForeColor = System.Drawing.Color.Black;
            this.label10.Location = new System.Drawing.Point(31, 313);
            this.label10.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(71, 32);
            this.label10.TabIndex = 48;
            this.label10.Text = "Batch";
            // 
            // add_student
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.OldLace;
            this.ClientSize = new System.Drawing.Size(1048, 489);
            this.Controls.Add(this.cb_batch);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.cb_course);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.cb_gender);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.tf_password);
            this.Controls.Add(this.tf_email);
            this.Controls.Add(this.tf_mobile_number);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.tf_address);
            this.Controls.Add(this.tf_name);
            this.Controls.Add(this.tf_student_id);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label2);
            this.Name = "add_student";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Add Student";
            this.Load += new System.EventHandler(this.add_student_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private ComboBox cb_course;
        private Label label9;
        private DateTimePicker dateTimePicker1;
        private Label label7;
        private ComboBox cb_gender;
        private Label label4;
        private Button button2;
        private Button button1;
        private TextBox tf_password;
        private TextBox tf_email;
        private TextBox tf_mobile_number;
        private Label label8;
        private TextBox tf_address;
        private TextBox tf_name;
        private TextBox tf_student_id;
        private Label label6;
        private Label label5;
        private Label label3;
        private Label label1;
        private Label label2;
        private ComboBox cb_batch;
        private Label label10;
    }
}