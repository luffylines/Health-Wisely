using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HealthCare_Plus.views
{
    public partial class qrcode1 : Form
    {
        public qrcode1(Bitmap qrCodeImage)
        {
            InitializeComponent();
            qrPictureBox.Image = qrCodeImage;
        }

        private void qrcode1_Load(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void btnlogin_Click(object sender, EventArgs e)
        {
            login login = new login();
            login.Show();
            this.Hide();
        }

        private void exit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Main mayn = new Main();
            mayn.Show();

            this.Hide();
        }

        private void qrPictureBox_Click(object sender, EventArgs e)
        {

        }
    }
}
