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
    public partial class Patient : Form
    {
        public Patient()
        {
            InitializeComponent();
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
            P_RegistrationPlace.SelectedIndex = -1;
            cbZone.SelectedIndex = -1;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (P_FirstName.Text == "" || P_MiddleName.Text == "" || P_LastName.Text == "" || P_Gender.SelectedIndex == -1 || P_BloodGroup.SelectedIndex == -1 || P_Address.Text == "" || P_MobilePhone.Text == "" || P_RegistrationPlace.SelectedIndex == -1 || cbZone.SelectedIndex == -1)
            {
                MessageBox.Show("Missing Information");
            }
            else
            {
                try
                {
                    string query = "insert into TBL_PATIENT values('" + P_FirstName.Text + "', '" + P_MiddleName.Text + "', '" + P_LastName.Text + "', '" + Convert.ToDateTime(P_dpDOB.Text).ToString("yyyy-MM-dd") + "', '" + P_Gender.SelectedItem.ToString() + "', '" + P_BloodGroup.SelectedItem.ToString() + "', '" + P_Address.Text + "', '" + P_MobilePhone.Text + "', '" + P_RegistrationPlace.SelectedItem.ToString() + "', '" + ((DataRowView)cbZone.SelectedItem).Row[0] + "')";
                    Connect.Open();
                    SqlCommand cmd = new SqlCommand(query, Connect);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Patient Successfully Registered");
                    Connect.Close();
                    Reset();
                }

                catch (Exception Exp)
                {
                    MessageBox.Show(Exp.Message);
                }
            }
        }

        private void Patient_Load(object sender, EventArgs e)
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

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void label18_Click(object sender, EventArgs e)
        {
            Donor oDonor = new Donor();
            oDonor.ShowDialog();
        }

        private void label4_Click(object sender, EventArgs e)
        {

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

        private void label7_Click(object sender, EventArgs e)
        {
            BloodTransfer oBloodTransfer = new BloodTransfer();
            oBloodTransfer.ShowDialog();
        }

        private void P_RegistrationPlace_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
