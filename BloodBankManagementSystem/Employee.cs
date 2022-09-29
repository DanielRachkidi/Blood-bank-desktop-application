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
    public partial class Employee : Form
    {
        public Employee()
        {
            InitializeComponent();
            populate();
        }
        SqlConnection Connect = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Pierre\Documents\BloodBankApplicationDatabase.mdf;Integrated Security=True;Connect Timeout=30");

        private void Reset()
        {
            Emp_Name.Text = "";
            Emp_Password.Text = "";
            Key = 0;
        }

        private void populate()
        {

            Connect.Open();
            String Query = "select Emp_Number as 'ID', Emp_ID as 'Name', Emp_Password as 'Password' from TBL_EMPLOYEE";
            SqlDataAdapter sda = new SqlDataAdapter(Query, Connect);
            SqlCommandBuilder builder = new SqlCommandBuilder(sda);
            var ds = new DataSet();
            sda.Fill(ds);
            EmployeesDGV.DataSource = ds.Tables[0];
            Connect.Close();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (Emp_Name.Text == "" || Emp_Password.Text == "")
            {
                MessageBox.Show("Missing Information");
                return;
            }

            if (Emp_Password.Text.Length < 8)
            {
                MessageBox.Show("Password must be at least 8 characters");
                return;
            }

            try
            {

                String query = "Insert into TBL_EMPLOYEE values('" + Emp_Name.Text + "','" + Emp_Password.Text + "')";
                Connect.Open();
                SqlCommand cmd = new SqlCommand(query, Connect);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Employee Successfully Registered");
                Connect.Close();
                Reset();
                populate();
            }

            catch (Exception Exp)
            {
                MessageBox.Show(Exp.Message);
            }

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {
            Login log = new Login();
            log.Show();
            this.Close();
        }

        int Key = 0;
        private void EmployeesDGV_SelectionChanged(object sender, EventArgs e)
        {
            if (EmployeesDGV.SelectedRows.Count > 0)
            {
                Emp_Name.Text = EmployeesDGV.SelectedRows[0].Cells[1].Value.ToString();
                Emp_Password.Text = EmployeesDGV.SelectedRows[0].Cells[2].Value.ToString();

                if (Emp_Name.Text == "")
                {
                    Key = 0;
                }

                else
                {
                    Key = Convert.ToInt32(EmployeesDGV.SelectedRows[0].Cells[0].Value.ToString());
                }
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            {
                if (Key == 0)
                {
                    MessageBox.Show("Select the Employee to Delete");
                }

                else
                {
                    try
                    {
                        String query = " Delete from TBL_EMPLOYEE where Emp_Number = " + Key + ";";
                        Connect.Open();
                        SqlCommand cmd = new SqlCommand(query, Connect);
                        cmd.ExecuteNonQuery();
                        MessageBox.Show("Employee Successfully Removed");
                        Connect.Close();
                        Reset();
                        populate();
                    }

                    catch (Exception Exp)
                    {
                        MessageBox.Show(Exp.Message);
                    }
                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            {
                if (Emp_Name.Text == "" || Emp_Password.Text == "")
                {
                    MessageBox.Show("Select the Employee to Edit");
                    return;
                }

                if (Emp_Password.Text.Length < 8)
                {
                    MessageBox.Show("Password must be at least 8 characters");
                    return;
                }

                try
                {
                    String query = " Update TBL_EMPLOYEE set Emp_ID = '" + Emp_Name.Text + "', Emp_Password = '" + Emp_Password.Text + "' where Emp_Number = " + Key + ";";
                    Connect.Open();
                    SqlCommand cmd = new SqlCommand(query, Connect);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Employee Successfully Edited");
                    Connect.Close();
                    Reset();
                    populate();
                }
                catch (Exception Exp)
                {
                    MessageBox.Show(Exp.Message);
                }
            }
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void Employee_Load(object sender, EventArgs e)
        {

        }

        private void Emp_Name_TextChanged(object sender, EventArgs e)
        {

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            HomePage oHomepage = new HomePage();
            oHomepage.ShowDialog();
        }

        private void label16_Click(object sender, EventArgs e)
        {

        }

        private void Emp_Password_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
 