using HealthCare_Plus.Services;
using HealthCare_Plus.views;
using MySql.Data.MySqlClient;
using OfficeOpenXml.ConditionalFormatting;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;
using QRCoder;

namespace HealthCare_Plus
{
    public partial class staffRegistration : Form
    {

        // database object 
        Database dbManager = new Database();


        public staffRegistration()
        {
            InitializeComponent();
        }

        private void exit_Click(object sender, EventArgs e)
        {
            login login = new login();
            login.Show();

            this.Hide();
        }

        private void btncancel_Click(object sender, EventArgs e)
        {
            Main login = new Main();
            login.Show();

            this.Hide();
        }

        // register button logic

        private void btnregister_Click(object sender, EventArgs e)
        {
            using (MySqlConnection connection = dbManager.GetConnection())
            {
                dbManager.OpenConnection(connection);

                if (RegisterValidations.IsValidRegistration(
                    txtname.Text.Trim(),
                    txtaddress.Text.Trim(),
                    txtphone.Text.Trim(),
                    txtemail.Text.Trim(),
                    txtusername.Text.Trim(),
                    txtpassword.Text.Trim()))
                {
                    string usernameInput = txtusername.Text;
                    string passwordInput = md5convert.GetMd5Hash(txtpassword.Text.Trim());

                    string query = "INSERT INTO user (email, username, password, role) VALUES (@Email, @Username, @Password, @Role)";
                    using (MySqlCommand insertCommand = new MySqlCommand(query, connection))
                    {
                        insertCommand.Parameters.AddWithValue("@Email", txtemail.Text.Trim());
                        insertCommand.Parameters.AddWithValue("@Username", usernameInput);
                        insertCommand.Parameters.AddWithValue("@Password", passwordInput);
                        insertCommand.Parameters.AddWithValue("@Role", 2);

                        int rowsAffected = insertCommand.ExecuteNonQuery();
                        if (rowsAffected > 0)
                        {
                            long userId = insertCommand.LastInsertedId;

                            // Insert into "staff" table
                            string staffQuery = "INSERT INTO staff (user_id, name, address, phone) VALUES (@UserId, @Name, @Address, @Phone)";
                            using (MySqlCommand staffInsertCommand = new MySqlCommand(staffQuery, connection))
                            {
                                staffInsertCommand.Parameters.AddWithValue("@UserId", userId);
                                staffInsertCommand.Parameters.AddWithValue("@Name", txtname.Text.Trim());
                                staffInsertCommand.Parameters.AddWithValue("@Address", txtaddress.Text.Trim());
                                staffInsertCommand.Parameters.AddWithValue("@Phone", txtphone.Text.Trim());

                                staffInsertCommand.ExecuteNonQuery();
                            }

                            // Generate QR Code
                            Bitmap qrCodeImage;
                            using (var qrGenerator = new QRCodeGenerator())
                            {
                                string qrContent = $"Name:{txtname.Text.Trim()},\n Username:{usernameInput}, \n Password:{txtpassword.Text.Trim()},\n Phone:{txtphone.Text.Trim()},\n Role: Staff"; // Assuming 2 is the role for staff
                                QRCodeData qrCodeData = qrGenerator.CreateQrCode(qrContent, QRCodeGenerator.ECCLevel.Q);

                                using (var qrCode = new QRCode(qrCodeData))
                                {
                                    qrCodeImage = qrCode.GetGraphic(20);
                                }
                            }

                            // Show QR code in qrcode1 form
                            qrcode1 qrForm = new qrcode1(qrCodeImage);
                            qrForm.Show();

                            MessageBox.Show("Registration was successful. Now you can login", "Success");
                            this.Hide();
                        }
                        else
                        {
                            MessageBox.Show("Something went wrong. Please check and register again", "Error");
                        }
                    }
                }
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
