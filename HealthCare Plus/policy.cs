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
    public partial class policy : Form
    {
        public policy()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            contactus contact = new contactus();
            contact.Show();

            this.Hide();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Main mayn = new Main();
            mayn.Show();

            this.Hide();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            about bout = new about();
            bout.Show();

            this.Hide();
        }

        private void exit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void panelsidebar_Paint(object sender, PaintEventArgs e)
        {

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

        private void picboxclose_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
