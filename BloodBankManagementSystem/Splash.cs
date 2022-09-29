using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BloodBankManagementSystem
{
    public partial class Splash : Form
    {
        public Splash()
        {
            InitializeComponent();
        }

        int progress = 0;
        private void nextStep()
        {
            progress += 5;
            if (progress >= 100)
            {
                Spl_Timer.Enabled = false;
                Spl_Timer.Stop();
                this.Spl_Timer.Stop();
                this.Hide();
                Login log = new Login();
                log.Show();
            }
            CircularProgressBar1.Value = progress;
        }
        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Splash_Load(object sender, EventArgs e)
        {
            CircularProgressBar1.Value = 0;
        }

        private void circularProgressBar1_Click(object sender, EventArgs e)
        {

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            nextStep();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
    }
}
