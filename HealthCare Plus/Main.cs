using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HealthCare_Plus
{
    public partial class Main : Form
    {
        public Main()
        {
            InitializeComponent();
        }

        private void lblstaffdashboard_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            policy pol = new policy();
            pol.Show();

            this.Hide();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            contactus us = new contactus();
            us.Show();

            this.Hide();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            about about = new about();
            about.Show();

            this.Hide();
        }

        private void btcdoctors_Click(object sender, EventArgs e)
        {
            login log = new login();
            log.Show();

            this.Hide();
        }

        private void btnappoinments_Click(object sender, EventArgs e)
        {
            adminlogin ad = new adminlogin();
            ad.Show();

            this.Hide();
        }

        private void exit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void Main_Load(object sender, EventArgs e)
        {

        }

        private void picboxclose_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void picboxminimize_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }
    }
}
