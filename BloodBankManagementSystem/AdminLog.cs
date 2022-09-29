using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BloodBankManagementSystem
{
    public partial class AdminLog : Form
    {
        public AdminLog()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (Admin_Password.Text == "")
            {
                MessageBox.Show("Please enter the Admin Password !");
            }

            else if (Admin_Password.Text == "Password")
            {
                Employee Emp = new Employee();
                Emp.Show();
                this.Close();
            }

            else
            {
                MessageBox.Show("Wrong Password. Try again.");
                Admin_Password.Text = "";
            }
        }

        private void label4_Click(object sender, EventArgs e)
        {
            Login log = new Login();
            log.Show();
            this.Hide();
        }

        private void label5_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void Admin_Password_TextChanged(object sender, EventArgs e)
        {

        }

        private void pictureBox2_MouseClick(object sender, MouseEventArgs e)
        {
            Admin_Password.PasswordChar = '\0';
        }

        private void pictureBox2_MouseLeave(object sender, EventArgs e)
        {
            Admin_Password.PasswordChar = '*';
        }

        private void AdminLog_Load(object sender, EventArgs e)
        {

        }
    }
}
