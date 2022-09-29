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
    public partial class BloodTransfer : Form
    {
        public BloodTransfer()
        {
            InitializeComponent();
            FillPatient();
        }
        SqlConnection Connect = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Pierre\Documents\BloodBankApplicationDatabase.mdf;Integrated Security=True;Connect Timeout=30");

        private void FillPatient()
        {
            Connect.Open();
            SqlCommand cmd = new SqlCommand("Select P_Number from TBL_PATIENT", Connect);
            SqlDataReader rdr;
            rdr = cmd.ExecuteReader();
            DataTable dt = new DataTable();
            dt.Columns.Add("P_Number", typeof(int));
            dt.Load(rdr);
            BT_Number.ValueMember = "P_Number";
            BT_Number.DataSource = dt;
            Connect.Close();
        }

        private void GetInfo()
        {
            Connect.Open();
            string Query = "select * from TBL_PATIENT  where P_Number = " + BT_Number.SelectedValue.ToString() + " ";
            SqlCommand cmd = new SqlCommand(Query, Connect);
            DataTable dt = new DataTable();
            SqlDataAdapter sda = new SqlDataAdapter(cmd);
            sda.Fill(dt);
            foreach (DataRow dr in dt.Rows)
            {
                BT_FirstName.Text = dr["P_FirstName"].ToString();
                BT_MiddleName.Text = dr["P_MiddleName"].ToString();
                BT_LastName.Text = dr["P_LastName"].ToString();
                BloodG.Text = dr["P_BloodGroup"].ToString();
            }
            Connect.Close();

        }

        int storage;
        private void GetStorage(string BloodGroup)
        {
            Connect.Open();
            string Query = "select * from TBL_BLOODUNITSTORAGE where BloodGroup = '" + BloodGroup + "' ";
            SqlCommand cmd = new SqlCommand(Query, Connect);
            DataTable dt = new DataTable();
            SqlDataAdapter sda = new SqlDataAdapter(cmd);
            sda.Fill(dt);
            foreach (DataRow dr in dt.Rows)
            {
                storage = Convert.ToInt32(dr["B_UnitStorage"].ToString());
            }
            Connect.Close();
        }

        private void Reset()
        {
            BT_FirstName.Text = "";
            BT_MiddleName.Text = "";
            BT_LastName.Text = "";
            BloodG.Text = "";
            AvailableLabel.Visible = false;
            Transfer.Visible = false;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (BT_FirstName.Text == "" || BT_MiddleName.Text == "" || BT_LastName.Text == "")
            {
                MessageBox.Show("Missing Information");
            }

            else
            {
                try
                {
                    string query = "Insert into TBL_BLOODTRANSFER values('" + BT_FirstName.Text + "', '" + BT_MiddleName.Text + "', '" + BT_LastName.Text + "', '" + BloodG.Text + "')";
                    Connect.Open();
                    SqlCommand cmd = new SqlCommand(query, Connect);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Blood Unit Successfully Transfered");
                    Connect.Close();
                    GetStorage(BloodG.Text);
                    UpdateStorage();
                    Reset();
                }

                catch (Exception Exp)
                {
                    MessageBox.Show(Exp.Message);
                }
            }
        }

        private void UpdateStorage()
        {
            int newstorage = storage - 1;
            try
            {
                string query = "Update TBL_BLOODUNITSTORAGE set B_UnitStorage = '" + newstorage + "' where BloodGroup = '" + BloodG.Text + "' ;";
                Connect.Open();
                SqlCommand cmd = new SqlCommand(query, Connect);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Blood Storage Successfully Updated");
                Connect.Close();

            }
            catch (Exception Exp)
            {
                MessageBox.Show(Exp.Message);
            }
        }

        private void BloodTransfer_Load(object sender, EventArgs e)
        {

        }

        private void label16_Click(object sender, EventArgs e)
        {

        }

       

        private void label14_Click(object sender, EventArgs e)
        {

        }

        private void BloodGroup_TextChanged(object sender, EventArgs e)
        {

        }

        private void panel13_Paint(object sender, PaintEventArgs e)
        {

        }

        private void BT_Number_SelectionChangeCommitted_1(object sender, EventArgs e)
        {
            GetInfo();
            GetStorage(BloodG.Text);

            if (storage > 0)
            {
                Transfer.Visible = true;
                AvailableLabel.Text = "Available Blood Group";
                AvailableLabel.Visible = true;
            }

            else
            {
                Transfer.Visible = false;
                AvailableLabel.Text = "No Available Blood Group";
                AvailableLabel.Visible = true;

            }
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void label12_Click(object sender, EventArgs e)
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
            PatientsList oPatientsList = new PatientsList();
            oPatientsList.ShowDialog();
        }

        private void AvailableLabel_Click(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }
    }
}
