using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HealthCare_Plus.views.staff
{
    public partial class qrcode2 : Form
    {
        public qrcode2(Bitmap qrCodeImage)
        {
            InitializeComponent();
            qrPictureBox.Image = qrCodeImage;
        }

        private void qrcode2_Load(object sender, EventArgs e)
        {

        }

        private void qrPictureBox_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnlogin_Click(object sender, EventArgs e)
        {
            staffDashboard login = new staffDashboard();
            login.Show();
            this.Hide();
        }
    }
}
