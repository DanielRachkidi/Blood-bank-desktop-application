namespace BloodBankManagementSystem
{
    partial class Employee
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Employee));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panel5 = new System.Windows.Forms.Panel();
            this.label21 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.EmployeesDGV = new System.Windows.Forms.DataGridView();
            this.label9 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.Emp_Password = new System.Windows.Forms.TextBox();
            this.label16 = new System.Windows.Forms.Label();
            this.panel6 = new System.Windows.Forms.Panel();
            this.Emp_Name = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.panel7 = new System.Windows.Forms.Panel();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.panel5.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.EmployeesDGV)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.Color.OrangeRed;
            this.panel5.Controls.Add(this.label21);
            this.panel5.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel5.Location = new System.Drawing.Point(208, 0);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(872, 52);
            this.panel5.TabIndex = 66;
            // 
            // label21
            // 
            this.label21.AutoSize = true;
            this.label21.Font = new System.Drawing.Font("Times New Roman", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label21.ForeColor = System.Drawing.Color.Black;
            this.label21.Location = new System.Drawing.Point(212, 9);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(458, 36);
            this.label21.TabIndex = 1;
            this.label21.Text = "BLOOD BANK APPLICATION";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.OrangeRed;
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Controls.Add(this.pictureBox2);
            this.panel1.Controls.Add(this.label8);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(208, 562);
            this.panel1.TabIndex = 65;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Black;
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.ForeColor = System.Drawing.Color.Black;
            this.panel2.Location = new System.Drawing.Point(12, 115);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(10, 55);
            this.panel2.TabIndex = 20;
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pictureBox2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(69, 9);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(64, 69);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 19;
            this.pictureBox2.TabStop = false;
            this.pictureBox2.Click += new System.EventHandler(this.pictureBox2_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.Transparent;
            this.label8.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label8.Cursor = System.Windows.Forms.Cursors.Hand;
            this.label8.Font = new System.Drawing.Font("Times New Roman", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.Black;
            this.label8.Location = new System.Drawing.Point(50, 517);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(99, 33);
            this.label8.TabIndex = 15;
            this.label8.Text = "Logout";
            this.label8.Click += new System.EventHandler(this.label8_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Cursor = System.Windows.Forms.Cursors.No;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(37, 130);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(122, 26);
            this.label2.TabIndex = 3;
            this.label2.Text = "Employees";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // EmployeesDGV
            // 
            this.EmployeesDGV.BackgroundColor = System.Drawing.Color.White;
            this.EmployeesDGV.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.EmployeesDGV.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.EmployeesDGV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.EmployeesDGV.Location = new System.Drawing.Point(464, 176);
            this.EmployeesDGV.Name = "EmployeesDGV";
            this.EmployeesDGV.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.EmployeesDGV.Size = new System.Drawing.Size(365, 226);
            this.EmployeesDGV.TabIndex = 112;
            this.EmployeesDGV.SelectionChanged += new System.EventHandler(this.EmployeesDGV_SelectionChanged);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.BackColor = System.Drawing.Color.White;
            this.label9.Font = new System.Drawing.Font("Times New Roman", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.Red;
            this.label9.Location = new System.Drawing.Point(558, 67);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(184, 31);
            this.label9.TabIndex = 113;
            this.label9.Text = "EMPLOYEES";
            this.label9.Click += new System.EventHandler(this.label9_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(611, 101);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(80, 69);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 114;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // Emp_Password
            // 
            this.Emp_Password.BackColor = System.Drawing.Color.White;
            this.Emp_Password.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.Emp_Password.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Emp_Password.Location = new System.Drawing.Point(795, 447);
            this.Emp_Password.Name = "Emp_Password";
            this.Emp_Password.Size = new System.Drawing.Size(177, 19);
            this.Emp_Password.TabIndex = 120;
            this.Emp_Password.TextChanged += new System.EventHandler(this.Emp_Password_TextChanged);
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.BackColor = System.Drawing.Color.White;
            this.label16.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label16.ForeColor = System.Drawing.Color.Black;
            this.label16.Location = new System.Drawing.Point(819, 422);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(133, 22);
            this.label16.TabIndex = 119;
            this.label16.Text = "Emp Password";
            this.label16.Click += new System.EventHandler(this.label16_Click);
            // 
            // panel6
            // 
            this.panel6.BackColor = System.Drawing.Color.Red;
            this.panel6.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel6.Location = new System.Drawing.Point(795, 468);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(177, 4);
            this.panel6.TabIndex = 118;
            // 
            // Emp_Name
            // 
            this.Emp_Name.BackColor = System.Drawing.Color.White;
            this.Emp_Name.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.Emp_Name.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Emp_Name.Location = new System.Drawing.Point(324, 447);
            this.Emp_Name.Name = "Emp_Name";
            this.Emp_Name.Size = new System.Drawing.Size(177, 19);
            this.Emp_Name.TabIndex = 117;
            this.Emp_Name.TextChanged += new System.EventHandler(this.Emp_Name_TextChanged);
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.BackColor = System.Drawing.Color.White;
            this.label12.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.ForeColor = System.Drawing.Color.Black;
            this.label12.Location = new System.Drawing.Point(344, 422);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(143, 22);
            this.label12.TabIndex = 116;
            this.label12.Text = "Employee Name";
            // 
            // panel7
            // 
            this.panel7.BackColor = System.Drawing.Color.Red;
            this.panel7.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel7.Location = new System.Drawing.Point(324, 468);
            this.panel7.Name = "panel7";
            this.panel7.Size = new System.Drawing.Size(177, 4);
            this.panel7.TabIndex = 115;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Blue;
            this.button1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button1.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.Location = new System.Drawing.Point(607, 516);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(84, 34);
            this.button1.TabIndex = 122;
            this.button1.Text = "Edit";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.Red;
            this.button2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button2.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.ForeColor = System.Drawing.Color.White;
            this.button2.Location = new System.Drawing.Point(715, 516);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(87, 34);
            this.button2.TabIndex = 121;
            this.button2.Text = "Delete";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.Green;
            this.button3.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button3.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button3.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button3.ForeColor = System.Drawing.Color.White;
            this.button3.Location = new System.Drawing.Point(496, 516);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(87, 34);
            this.button3.TabIndex = 123;
            this.button3.Text = "Save";
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // Employee
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1080, 562);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.Emp_Password);
            this.Controls.Add(this.label16);
            this.Controls.Add(this.panel6);
            this.Controls.Add(this.Emp_Name);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.panel7);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.EmployeesDGV);
            this.Controls.Add(this.panel5);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Employee";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Employee";
            this.Load += new System.EventHandler(this.Employee_Load);
            this.panel5.ResumeLayout(false);
            this.panel5.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.EmployeesDGV)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Label label21;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView EmployeesDGV;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.TextBox Emp_Password;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.TextBox Emp_Name;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Panel panel7;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Panel panel2;
    }
}