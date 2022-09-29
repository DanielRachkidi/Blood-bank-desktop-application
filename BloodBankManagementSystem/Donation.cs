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
    public partial class Donation : Form
    {
        public Donation()
        {
            InitializeComponent();
            populate();
            BloodStorage();
        }
        SqlConnection Connect = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Pierre\Documents\BloodBankApplicationDatabase.mdf;Integrated Security=True;Connect Timeout=30");

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

        private void BloodStorage()
        {
            Connect.Open();
            string Query = "select * from TBL_BLOODUNITSTORAGE";
            SqlDataAdapter sda = new SqlDataAdapter(Query, Connect);
            SqlCommandBuilder builder = new SqlCommandBuilder(sda);
            var ds = new DataSet();
            sda.Fill(ds);
            Connect.Close();
        }

        int oldstorage;
        private void GetStorage(string BloodGroup)
        {
            if (Connect.State == ConnectionState.Closed)
            {
                Connect.Open();
            }
            string Query = "select * from TBL_BLOODUNITSTORAGE  where BloodGroup = '" + BloodGroup + "' ";
            SqlCommand cmd = new SqlCommand(Query, Connect);
            DataTable dt = new DataTable();
            SqlDataAdapter sda = new SqlDataAdapter(cmd);
            sda.Fill(dt);
            foreach (DataRow dr in dt.Rows)
            {
                oldstorage = Convert.ToInt32(dr["B_UnitStorage"].ToString());
            }
            Connect.Close();

        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void label11_Click(object sender, EventArgs e)
        {

        }

        private void label12_Click(object sender, EventArgs e)
        {

        }

        private void Reset()
        {
            D_FirstName.Text = "";
            D_MiddleName.Text = "";
            D_LastName.Text = "";
            BloodGroup.Text = "";
        }

        private void DonorDGV_SelectionChanged(object sender, EventArgs e)
        {
            if (DonorDGV.SelectedRows.Count > 0)
            {
                D_FirstName.Text = DonorDGV.SelectedRows[0].Cells[1].Value.ToString();
                D_MiddleName.Text = DonorDGV.SelectedRows[0].Cells[2].Value.ToString();
                D_LastName.Text = DonorDGV.SelectedRows[0].Cells[3].Value.ToString();
                BloodGroup.Text = DonorDGV.SelectedRows[0].Cells[8].Value.ToString();
                GetStorage(BloodGroup.Text);
            }

        }

        private void Donate_Click(object sender, EventArgs e)
        {
            if (D_FirstName.Text == "" || D_MiddleName.Text == "" || D_LastName.Text == "" || BloodGroup.Text == "")
            {
                MessageBox.Show("Please select a Donor !");
            }

            else
            {
                try
                {
                    if (DonorDGV.SelectedRows.Count > 0)
                    {
                        string query = string.Format("select ISNULL( CAST(D_Last_Donation_Date as varchar), '') from TBL_DONOR where D_RegNumber = {0}", DonorDGV.SelectedRows[0].Cells[0].Value);
                        SqlCommand cmd = new SqlCommand(query, Connect);
                        Connect.Open();
                        string val =  cmd.ExecuteScalar().ToString();
                        Connect.Close();

                        if (val == "")
                        {
                            Update_Donation((int)DonorDGV.SelectedRows[0].Cells[0].Value);
                            Donation_Load(sender, e);
                        }
                        else {
                            DateTime odt = new DateTime();
                            odt = Convert.ToDateTime(val);
                            if ((DateTime.Today - odt).TotalDays > 30)
                            {
                                Update_Donation((int)DonorDGV.SelectedRows[0].Cells[0].Value);
                                Donation_Load(sender, e);
                            }
                            else
                                MessageBox.Show("Cannot donate, last donation date is: " + odt.ToString("yyyy-MM-dd"));
                        }
                    }
                    else
                        MessageBox.Show("Please select a Donor!");
                }

                catch (Exception Exp)
                {
                    MessageBox.Show(Exp.Message);
                }
            }
        }

        private void Update_Donation(int d_regnumber)
        {
            int storage = oldstorage + 1;
            string query = "update TBL_BLOODUNITSTORAGE set B_UnitStorage = " + storage + " where BloodGroup = '" + BloodGroup.Text + "'; ";
            SqlCommand cmd = new SqlCommand(query, Connect);
            Connect.Open();
            cmd.ExecuteNonQuery();
            MessageBox.Show("Donation Successful");
            Connect.Close();
            Reset();
            BloodStorage();

            query = string.Format("update TBL_DONOR set D_Last_Donation_Date = '{0}' where D_RegNumber = {1}", DateTime.Today.ToString("yyyy-MM-dd"), d_regnumber);
            cmd = new SqlCommand(query, Connect);
            Connect.Open();
            cmd.ExecuteNonQuery();
            Connect.Close();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Donation_Load(object sender, EventArgs e)
        {
            string Query = "select D_RegNumber as 'Registration Number', D_FirstName as 'First Name', D_MiddleName as 'Middle Name', D_LastName as 'Last Name', D_DOB as 'Date of Birth', D_MobilePhone as 'Mobile Phone', D_Gender as 'Gender', D_Address as 'Address', D_BloodGroup as 'Blood Group', D_Email as 'Email', Zone_Code as 'Country Code', D_Last_Donation_Date as 'Last Donation Date' from TBL_DONOR inner join TBL_ZONE on TBL_DONOR.D_ZONE_ID = TBL_ZONE.ZONE_ID";
            Connect.Open();
            SqlDataAdapter sda = new SqlDataAdapter(Query, Connect);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            DonorDGV.DataSource = dt;
            Connect.Close();
        }

        private void label2_Click(object sender, EventArgs e)
        {
            Donor oDonor = new Donor();
            oDonor.ShowDialog();
        }

        private void label4_Click(object sender, EventArgs e)
        {
            Patient oPatient = new Patient();
            oPatient.ShowDialog();
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
            PatientsList oPatientsList = new PatientsList();
            oPatientsList.ShowDialog();
        }

        private void label7_Click(object sender, EventArgs e)
        {
            BloodTransfer oBloodTransfer = new BloodTransfer();
            oBloodTransfer.ShowDialog();
        }

        private void DonorDGV_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void D_FirstName_TextChanged(object sender, EventArgs e)
        {

        }

        private void D_LastName_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            string Query = "select * from TBL_DONOR where D_BloodGroup like '" + textBox1.Text + "%' ";
            Connect.Open();
            SqlDataAdapter sda = new SqlDataAdapter(Query, Connect);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            DonorDGV.DataSource = dt;
            Connect.Close();
        }

        private void label8_Click(object sender, EventArgs e)
        {

        }
    }
}
