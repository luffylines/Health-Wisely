using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HealthCare_Plus
{
    public partial class contactus : Form
    {
        public contactus()
        {
            InitializeComponent();
        }

        private void lblstaffdashboard_Click(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            Main mayn = new Main();
            mayn.Show();

            this.Hide();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            about aboutus = new about();
            aboutus.Show();

            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            policy pol = new policy();
            pol.Show();

            this.Hide();
        }

        private void label2_Click(object sender, EventArgs e)
        {
            string text = "Hello, World!";
            int consoleWidth = Console.WindowWidth; // Get the current console width
            int padding = (consoleWidth - text.Length) / 2; // Calculate padding

            // Pad the text with spaces on the left to center it
            string centeredText = text.PadLeft(padding + text.Length);

            Console.WriteLine(centeredText);

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            string facebookUrl = "https://www.facebook.com/christianaring6"; // Replace with your Facebook URL
            Process.Start(new ProcessStartInfo(facebookUrl) { UseShellExecute = true });
        }

        private void linkLabel2_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            string facebookUrl = "https://www.instagram.com/crstn.aring6"; // Replace with your Instagram URL
            Process.Start(new ProcessStartInfo(facebookUrl) { UseShellExecute = true });
        }

        private void exit_Click(object sender, EventArgs e)
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

        private void picboxclose_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
