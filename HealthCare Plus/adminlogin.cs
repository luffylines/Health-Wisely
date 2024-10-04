using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using HealthCare_Plus.Services;
using HealthCare_Plus.views.admin;
using HealthCare_Plus.views.staff;
using MySql.Data.MySqlClient;

namespace HealthCare_Plus
{
    public partial class adminlogin : Form
    {
        // database object 
        Database dbManager = new Database();
        public adminlogin()
        {
            InitializeComponent();
        }

        private void exit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnlogin_Click(object sender, EventArgs e)
        {

            if (LoginValidations.IsValidLogin(txtusername.Text.Trim(), txtpassword.Text.Trim()))
            {
                using (MySqlConnection connection = dbManager.GetConnection())
                {
                    dbManager.OpenConnection(connection);

                    string usernameInput = txtusername.Text;
                    string passwordInput = md5convert.GetMd5Hash(txtpassword.Text.Trim());

                    string query = "SELECT * FROM user WHERE username = @Username AND password = @Password";
                    using (MySqlCommand cmd = new MySqlCommand(query, connection))
                    {
                        cmd.Parameters.AddWithValue("@Username", usernameInput);
                        cmd.Parameters.AddWithValue("@Password", passwordInput);

                        using (MySqlDataReader reader = cmd.ExecuteReader())
                        {
                            if (reader.HasRows)
                            {
                                reader.Read();
                                int role = Convert.ToInt32(reader["role"]);

                                if (role == 1)
                                {
                                    // User has role 1 / admin
                                    adminDashboard adminDashboard = new adminDashboard();
                                    adminDashboard.Show();

                                    this.Hide();
                                }
                                else
                                {
                                    // User has staff role
                                    staffDashboard staffDashboard = new staffDashboard();
                                    staffDashboard.Show();

                                    this.Hide();
                                }
                            }
                            else
                            {
                                // Invalid login
                                MessageBox.Show("Invalid login information.", "Error");
                            }
                        }
                    }
                }
            }
        }


        private void register_Click(object sender, EventArgs e)
        {
            adminsign admin = new adminsign();
            admin.Show();

            this.Hide();
        }

        private void txtpassword_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Main mayn = new Main();
            mayn.Show();

            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (LoginValidations.IsValidLogin(txtusername.Text.Trim(), txtpassword.Text.Trim()))
            {
                using (MySqlConnection connection = dbManager.GetConnection())
                {
                    dbManager.OpenConnection(connection);

                    string usernameInput = txtusername.Text;
                    string passwordInput = md5convert.GetMd5Hash(txtpassword.Text.Trim());

                    string query = "SELECT * FROM user WHERE username = @Username AND password = @Password";
                    using (MySqlCommand cmd = new MySqlCommand(query, connection))
                    {
                        cmd.Parameters.AddWithValue("@Username", usernameInput);
                        cmd.Parameters.AddWithValue("@Password", passwordInput);

                        using (MySqlDataReader reader = cmd.ExecuteReader())
                        {
                            if (reader.HasRows)
                            {
                                reader.Read();
                                int role = Convert.ToInt32(reader["role"]);

                                if (role == 1)
                                {
                                    // User has role 1 / admin
                                    adminDashboard adminDashboard = new adminDashboard();
                                    adminDashboard.Show();

                                    this.Hide();
                                }
                                else
                                {
                                    // User has staff role
                                    staffDashboard staffDashboard = new staffDashboard();
                                    staffDashboard.Show();

                                    this.Hide();
                                }
                            }
                            else
                            {
                                // Invalid login
                                MessageBox.Show("Invalid login information.", "Error");
                            }
                        }
                    }
                }
            }

        }
    }
}
