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
    public partial class PatientsList : Form
    {
        public PatientsList()
        {
            InitializeComponent();
            populate();
        }
        SqlConnection Connect = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Pierre\Documents\BloodBankApplicationDatabase.mdf;Integrated Security=True;Connect Timeout=30");

        private void Reset()
        {
            P_FirstName.Text = "";
            P_MiddleName.Text = "";
            P_LastName.Text = "";
            P_Gender.SelectedIndex = -1;
            P_BloodGroup.SelectedIndex = -1;
            P_Address.Text = "";
            P_MobilePhone.Text = "";
            cbZone.SelectedIndex = -1;
            Key = 0;
        }

        private void populate()
        {
            Connect.Open();
            string Query = "select P_Number as 'Number', P_FirstName as 'First Name', P_MiddleName as 'Middle Name', P_LastName as 'Last Name', P_DOB as 'Date of Birth', P_Gender as 'Gender', P_BloodGroup as 'Blood Group', P_Address as 'Address', P_MobilePhone as 'Mobile Phone', P_RegistrationPlace as 'Registration Place', Zone_Code as 'Country Code' from TBL_PATIENT inner join TBL_ZONE on TBL_PATIENT.P_ZONE_ID = TBL_ZONE.ZONE_ID";
            SqlDataAdapter sda = new SqlDataAdapter(Query, Connect);
            SqlCommandBuilder builder = new SqlCommandBuilder(sda);
            var ds = new DataSet();
            sda.Fill(ds);
            PatientsDGV.DataSource = ds.Tables[0];
            Connect.Close();
        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void label14_Click(object sender, EventArgs e)
        {

        }

        int Key = 0;
        private void button1_Click(object sender, EventArgs e)
        {
            if (P_FirstName.Text == "" || P_MiddleName.Text == "" || P_LastName.Text == "" || P_Gender.SelectedIndex == -1 || P_BloodGroup.SelectedIndex == -1 || P_Address.Text == "" || P_MobilePhone.Text == "" || cbZone.SelectedIndex == -1)

            {
                MessageBox.Show("Missing Information");
            }
            else
            {
                try
                {
                    string query = "Update TBL_PATIENT set P_FirstName = '" + P_FirstName.Text + "', P_MiddleName = '" + P_MiddleName.Text + "', P_LastName = '" + P_LastName.Text + "', P_Gender = '" + P_Gender.SelectedItem.ToString() + "', P_BloodGroup = '" + P_BloodGroup.SelectedItem.ToString() + "', P_Address = '"+ P_Address.Text + "', P_MobilePhone = '" + P_MobilePhone.Text + "', P_ZONE_ID = '" + ((DataRowView)cbZone.SelectedItem).Row[0] + "' where P_Number = " + Key + ";";
                    Connect.Open();
                    SqlCommand cmd = new SqlCommand(query, Connect);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Patient Successfully Edited");
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

        private void PatientsDGV_SelectionChanged(object sender, EventArgs e)
        {
            if (PatientsDGV.SelectedRows.Count > 0)
            {
                P_FirstName.Text = PatientsDGV.SelectedRows[0].Cells[1].Value.ToString();
                P_MiddleName.Text = PatientsDGV.SelectedRows[0].Cells[2].Value.ToString();
                P_LastName.Text = PatientsDGV.SelectedRows[0].Cells[3].Value.ToString();
                P_Gender.SelectedItem = PatientsDGV.SelectedRows[0].Cells[5].Value.ToString();
                P_BloodGroup.SelectedItem = PatientsDGV.SelectedRows[0].Cells[6].Value.ToString();
                P_Address.Text = PatientsDGV.SelectedRows[0].Cells[7].Value.ToString();
                P_MobilePhone.Text = PatientsDGV.SelectedRows[0].Cells[8].Value.ToString();
                cbZone.SelectedItem = PatientsDGV.SelectedRows[0].Cells[10].Value.ToString();

                if (P_FirstName.Text == "")
                {
                    Key = 0;
                }
                else
                {
                    Key = Convert.ToInt32(PatientsDGV.SelectedRows[0].Cells[0].Value.ToString());
                }
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (Key == 0)
            {
                MessageBox.Show("Select a Patient to Delete !");
            }
            else
            {
                try
                {
                    string query = "Delete from TBL_PATIENT where P_Number = " + Key + ";";
                    Connect.Open();
                    SqlCommand cmd = new SqlCommand(query, Connect);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Patient Successfully Deleted");
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

        private void PatientsList_Load(object sender, EventArgs e)
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

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void P_MobilePhone_TextChanged(object sender, EventArgs e)
        {

        }

        private void P_RegistrationPlace_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label18_Click(object sender, EventArgs e)
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

        private void label3_Click(object sender, EventArgs e)
        {
            DonorsList oDonorsList = new DonorsList();
            oDonorsList.ShowDialog();
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {
            BloodTransfer oBloodTransfer = new BloodTransfer();
            oBloodTransfer.ShowDialog();
        }

        private void label19_Click(object sender, EventArgs e)
        {

        }

        private void PatientsDGV_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            string Query = " select * from TBL_PATIENT where P_LastName like '" + textBox1.Text + "%' ";
            Connect.Open();
            SqlDataAdapter sda = new SqlDataAdapter(Query, Connect);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            PatientsDGV.DataSource = dt;
            Connect.Close();
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            string Query = " select * from TBL_PATIENT where P_BloodGroup like '" + textBox2.Text + "%' ";
            Connect.Open();
            SqlDataAdapter sda = new SqlDataAdapter(Query, Connect);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            PatientsDGV.DataSource = dt;
            Connect.Close();
        }

        private void label10_Click(object sender, EventArgs e)
        {

        }
    }
}
