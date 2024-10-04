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
    public partial class progress : Form
    {
        public progress()
        {
            InitializeComponent();
        }

        private void timer2_Tick(object sender, EventArgs e)
        {
            if (progressBar1.Value < 100)
            {
                progressBar1.Value++;
                label1.Text = $"{progressBar1.Value}%";
            }
            else
            {
                // Stop the timer when progress is complete
                timer2.Stop();

                // Open the next form
                Main nextForm = new Main();
                nextForm.Show(); // Use ShowDialog() if you want it to be modal

                this.Hide(); // Optionally hide the progress form
            }
        }

        private void progressBar1_Click(object sender, EventArgs e)
        {

        }

        private void progress_Load(object sender, EventArgs e)
        {
            timer2.Start();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
