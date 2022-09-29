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

namespace BloodBankManagementSystem
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }
        SqlConnection Connect = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Pierre\Documents\BloodBankApplicationDatabase.mdf;Integrated Security=True;Connect Timeout=30");

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void Login_Load(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void label4_Click(object sender, EventArgs e)
        {
            AdminLog adm = new AdminLog();
            adm.Show();
            this.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Connect.Open();
            SqlDataAdapter sda = new SqlDataAdapter("select count(*) from TBL_EMPLOYEE where Emp_ID = '" + Emp_Name.Text + "' and Emp_Password = '" + Emp_Password.Text + "' ", Connect);
            DataTable dt = new DataTable();
            sda.Fill(dt);

            if (dt.Rows[0][0].ToString() == "1")
            {
                HomePage Main = new HomePage();
                Main.Show();
                this.Hide();
                Connect.Close();
            }

            else
            {

                MessageBox.Show("Wrong Name and/or Password");
            }
            Connect.Close();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void Emp_Name_TextChanged(object sender, EventArgs e)
        {

        }

        private void Emp_Password_TextChanged(object sender, EventArgs e)
        {

        }

        private void pictureBox2_MouseClick(object sender, MouseEventArgs e)
        {
            Emp_Password.PasswordChar = '\0';
        }

        private void pictureBox2_MouseLeave(object sender, EventArgs e)
        {
            Emp_Password.PasswordChar = '*';
        }

        private void label3_Click(object sender, EventArgs e)
        {
            
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }
    }
}
