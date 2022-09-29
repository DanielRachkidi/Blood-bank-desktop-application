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
    public partial class DonorsList : Form
    {
        public DonorsList()
        {
            InitializeComponent();
            populate();
        }
        SqlConnection Connect = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Pierre\Documents\BloodBankApplicationDatabase.mdf;Integrated Security=True;Connect Timeout=30");

        private void Reset()
        {
            D_FirstName.Text = "";
            D_MiddleName.Text = "";
            D_LastName.Text = "";
            D_MobilePhone.Text = "";
            D_Gender.SelectedIndex = -1;
            D_Address.Text = "";
            D_BloodGroup.Text = "";
            D_Email.Text = "";
            cbZone.SelectedIndex = -1;
            Key = 0;
        }

        private void populate()
        {
            Connect.Open();
            string Query = "select D_RegNumber as 'Registration Number', D_FirstName as 'First Name', D_MiddleName as 'Middle Name', D_LastName as 'Last Name', D_DOB as 'Date of Birth', D_MobilePhone as 'Mobile Phone', D_Gender as 'Gender', D_Address as 'Address', D_BloodGroup as 'Blood Group', D_Email as 'Email', Zone_Code as 'Country Code', D_Last_Donation_Date as 'Last Donation Date' from TBL_DONOR inner join TBL_ZONE on TBL_DONOR.D_ZONE_ID = TBL_ZONE.ZONE_ID";
            SqlDataAdapter sda = new SqlDataAdapter(Query, Connect);
            SqlCommandBuilder builder = new SqlCommandBuilder(sda);
            var ds = new DataSet();
            sda.Fill(ds);
            DonorDGV.DataSource = ds.Tables[0];
            Connect.Close();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void label10_Click(object sender, EventArgs e)
        {
            Donor oDonor = new Donor();
            oDonor.ShowDialog();
        }

        private void label4_Click(object sender, EventArgs e)
        {
            Patient oPatient = new Patient();
            oPatient.ShowDialog();
        }

        private void label2_Click(object sender, EventArgs e)
        {
            Donation oDonate = new Donation();
            oDonate.ShowDialog();
        }

        private void label6_Click(object sender, EventArgs e)
        {
            BloodUnitsStorage oBloodUnits = new BloodUnitsStorage();
            oBloodUnits.ShowDialog();
        }

        private void label5_Click(object sender, EventArgs e)
        {
            PatientsList oPatientsList = new PatientsList();
            oPatientsList.ShowDialog();
        }

        private void label7_Click(object sender, EventArgs e)
        {
            BloodTransfer oBloodTransfer = new BloodTransfer();
            oBloodTransfer.ShowDialog();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        int Key = 0;
        private void button1_Click(object sender, EventArgs e)
        {
            if (D_FirstName.Text == "" || D_MiddleName.Text == "" || D_LastName.Text == "" || D_MobilePhone.Text == "" || D_Gender.SelectedIndex == -1 || D_Address.Text == "" || D_BloodGroup.Text == "" || D_Email.Text == "" || cbZone.SelectedIndex == -1)

            {
                MessageBox.Show("Missing Information");
            }
            else
            {
                try
                {
                    string query = "Update TBL_DONOR set D_FirstName = '" + D_FirstName.Text + "', D_MiddleName = '" + D_MiddleName.Text + "', D_LastName = '" + D_LastName.Text + "', D_MobilePhone = '" + D_MobilePhone.Text + "', D_Gender = '" + D_Gender.SelectedItem.ToString() + "', D_Address = '" + D_Address.Text + "', D_BloodGroup = '" + D_BloodGroup.Text + "', D_Email = '" + D_Email.Text + "', D_ZONE_ID = '" + ((DataRowView)cbZone.SelectedItem).Row[0] + "' where D_RegNumber = " + Key + ";";
                    Connect.Open();
                    SqlCommand cmd = new SqlCommand(query, Connect);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Donor Successfully Edited");
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

        private void button2_Click(object sender, EventArgs e)
        {
            if (Key == 0)
            {
                MessageBox.Show("Select a Donor to Delete !");
            }
            else
            {
                try
                {
                    string query = "Delete from TBL_DONOR where D_RegNumber = " + Key + ";";
                    Connect.Open();
                    SqlCommand cmd = new SqlCommand(query, Connect);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Donor Successfully Deleted");
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

        private void DonorDGV_SelectionChanged(object sender, EventArgs e)
        {
            if (DonorDGV.SelectedRows.Count > 0)
            {
                D_FirstName.Text = DonorDGV.SelectedRows[0].Cells[1].Value.ToString();
                D_MiddleName.Text = DonorDGV.SelectedRows[0].Cells[2].Value.ToString();
                D_LastName.Text = DonorDGV.SelectedRows[0].Cells[3].Value.ToString();
                D_MobilePhone.Text = DonorDGV.SelectedRows[0].Cells[5].Value.ToString();
                D_Gender.SelectedItem = DonorDGV.SelectedRows[0].Cells[6].Value.ToString();
                D_Address.Text = DonorDGV.SelectedRows[0].Cells[7].Value.ToString();
                D_BloodGroup.Text = DonorDGV.SelectedRows[0].Cells[8].Value.ToString();
                D_Email.Text = DonorDGV.SelectedRows[0].Cells[9].Value.ToString();
                cbZone.SelectedItem = DonorDGV.SelectedRows[0].Cells[10].Value.ToString();

                if (D_FirstName.Text == "")
                {
                    Key = 0;
                }

                else
                {
                    Key = Convert.ToInt32(DonorDGV.SelectedRows[0].Cells[0].Value.ToString());
                }
            }
        }

        private void DonorsList_Load(object sender, EventArgs e)
        {
            string Query = "SELECT * FROM TBL_ZONE";
            Connect.Open();
            SqlCommand cmd = new SqlCommand(Query, Connect);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.FillSchema(dt, SchemaType.Source);
            da.Fill(dt);
            cbZone.ValueMember = dt.Columns[0].ColumnName;
            cbZone.DisplayMember = dt.Columns[1].ColumnName;
            cbZone.DataSource = dt;
            Connect.Close();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            string Query = "select * from TBL_DONOR where D_LastName like '" + textBox1.Text + "%' ";
            Connect.Open();
            SqlDataAdapter sda = new SqlDataAdapter(Query, Connect);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            DonorDGV.DataSource = dt;
            Connect.Close();
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            string Query = "select * from TBL_DONOR where D_BloodGroup like '" + textBox2.Text + "%' ";
            Connect.Open();
            SqlDataAdapter sda = new SqlDataAdapter(Query, Connect);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            DonorDGV.DataSource = dt;
            Connect.Close();
        }

        private void label13_Click(object sender, EventArgs e)
        {

        }

        private void cbZone_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label15_Click(object sender, EventArgs e)
        {

        }

        private void label19_Click(object sender, EventArgs e)
        {

        }
    }
}
