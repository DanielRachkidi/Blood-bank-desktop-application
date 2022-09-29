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
    public partial class Donor : Form
    {
        public Donor()
        {
            InitializeComponent();
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
            D_BloodGroup.SelectedIndex = -1;
            D_Email.Text = "";
            cbZone.SelectedIndex = -1;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (D_FirstName.Text == "" || D_MiddleName.Text == "" || D_LastName.Text == "" || D_MobilePhone.Text == "" || D_Gender.SelectedIndex == -1 || D_Address.Text == "" || D_BloodGroup.SelectedIndex == -1 || D_Address.Text == "" || cbZone.SelectedIndex == -1)
            {
                MessageBox.Show("Missing Information");
            }

            else
            {
                try
                {
                    string query = "insert into TBL_DONOR values('" + D_FirstName.Text + "', '" + D_MiddleName.Text + "', '" + D_LastName.Text + "', '" + Convert.ToDateTime(D_dpDOB.Text).ToString("yyyy-MM-dd") + "',  '" + D_MobilePhone.Text + "', '" + D_Gender.SelectedItem.ToString() + "', '" + D_Address.Text + "', '" + D_BloodGroup.SelectedItem.ToString() + "', '" + D_Email.Text + "', '" + ((DataRowView)cbZone.SelectedItem).Row[0] + "' , NULL)";
                    Connect.Open();
                    SqlCommand cmd = new SqlCommand(query, Connect);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Donor Successfully Registered");
                    Connect.Close();
                    Reset();
                }

                catch (Exception Exp)
                {
                    MessageBox.Show(Exp.Message);
                }
            }
        }

        private void Donor_Load(object sender, EventArgs e)
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

        private void label12_Click(object sender, EventArgs e)
        {

        }

        private void label11_Click_1(object sender, EventArgs e)
        {

        }

        private void label15_Click(object sender, EventArgs e)
        {

        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void label7_Click(object sender, EventArgs e)
        {
            BloodTransfer oBloodTransfer = new BloodTransfer();
            oBloodTransfer.ShowDialog();
        }

        private void label18_Click(object sender, EventArgs e)
        {

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

        private void cbZone_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void D_FirstName_TextChanged(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }
    }
}
