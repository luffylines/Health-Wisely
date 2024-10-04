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
    public partial class about : Form
    {
        public about()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            Main mayn = new Main();
            mayn.Show();

            this.Hide();
        }

        private void exit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void picboxclose_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void picboxminimize_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void picboxlogout_Click(object sender, EventArgs e)
        {
            Main man = new Main();
            this.Hide();
            man.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            contactus man = new contactus();
            this.Hide();
            man.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            policy man = new policy();
            this.Hide();
            man.Show();
        }

        private void about_Load(object sender, EventArgs e)
        {

        }
    }
}
