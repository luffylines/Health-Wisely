using HealthCare_Plus.Services;
using HealthCare_Plus.views.admin;
using MySql.Data.MySqlClient;
using QRCoder;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

namespace HealthCare_Plus.views.staff
{

    public partial class add_appoinment : UserControl
    {
        // database object 
        Database dbManager = new Database();

        class Patient
        {
            public int Id { get; set; }
            public string Name { get; set; }
        }

        class Doctor
        {
            public int Id { get; set; }
            public string Name { get; set; }
        }

        // Example method to load patient data from the database
        private List<Patient> LoadPatientsFromDatabase()
        {
            List<Patient> patients = new List<Patient>();

            using (MySqlConnection connection = dbManager.GetConnection())
            {
                dbManager.OpenConnection(connection);

                string query = "SELECT id, name FROM patient";
                using (MySqlCommand cmd = new MySqlCommand(query, connection))
                {
                    using (MySqlDataReader reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            patients.Add(new Patient
                            {
                                Id = reader.GetInt32("id"),
                                Name = reader.GetString("name")
                            });
                        }
                    }
                }
            }

            return patients;
        }

        //load doctors from database

        private List<Doctor> LoadDoctorsFromDatabase()
        {
            List<Doctor> doctors = new List<Doctor>();

            using (MySqlConnection connection = dbManager.GetConnection())
            {
                dbManager.OpenConnection(connection);

                string query = "SELECT id, name FROM doctor";
                using (MySqlCommand cmd = new MySqlCommand(query, connection))
                {
                    using (MySqlDataReader reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            doctors.Add(new Doctor
                            {
                                Id = reader.GetInt32("id"),
                                Name = reader.GetString("name")
                            });
                        }
                    }
                }
            }

            return doctors;
        }

        // get id from patients and doctos 
        private int GetIdFromFormattedText(string formattedText)
        {
            // Split the formatted text by the separator character (assuming "-" here)
            string[] parts = formattedText.Split('-');

            if (parts.Length > 0)
            {
                // Try to parse the first part as an integer
                if (int.TryParse(parts[0].Trim(), out int id))
                {
                    return id;
                }
            }

            // Return -1 or throw an exception based on your needs if parsing fails
            return -1;
        }

        public add_appoinment()
        {
            InitializeComponent();
        }

        private void btnadd_Click(object sender, EventArgs e)
        {

            if (AddAppointmentValidations.IsValidFormFields(
             combopatient,
             combodoctor,
             comboname,
             date,
             txtcost.Text.Trim(),
             rtextdescription.Text.Trim()))
            {
                int patientId = GetIdFromFormattedText(combopatient.Text);
                int doctorId = GetIdFromFormattedText(combodoctor.Text);
                string appointmentDate = date.Value.ToString("yyyy-MM-dd");// Format the date properly
                //int patientname = GetIdFromFormattedText(comboname.Text);
                string appointmentTime = time.Value.ToString("HH:mm:ss");
                string cost = txtcost.Text.Trim();
                string description = rtextdescription.Text.Trim();
                string isActive = "Active"; // Hardcoded value
                int InvoiceStatus = 0;

                string patientName = comboname.Text.Split('-')[1].Trim(); // This gets the name

                using (MySqlConnection connection = dbManager.GetConnection())
                {
                    dbManager.OpenConnection(connection);

                    string insertQuery = "INSERT INTO appoiment (doctor_id, patient_id, patientname, description, date,time, isactive, cost, InvoiceStatus) VALUES (@DoctorId, @PatientId, @PatientName, @Description, @Date, @Time, @IsActive, @Cost, @InvoiceStatus)";
                    using (MySqlCommand insertCommand = new MySqlCommand(insertQuery, connection))
                    {
                        insertCommand.Parameters.AddWithValue("@DoctorId", doctorId);
                        insertCommand.Parameters.AddWithValue("@PatientId", patientId);
                        insertCommand.Parameters.AddWithValue("@PatientName", patientName);
                        insertCommand.Parameters.AddWithValue("@Description", description);
                        insertCommand.Parameters.AddWithValue("@Date", appointmentDate);
                        insertCommand.Parameters.AddWithValue("@Time", appointmentTime);
                        insertCommand.Parameters.AddWithValue("@IsActive", isActive);
                        insertCommand.Parameters.AddWithValue("@Cost", cost);
                        insertCommand.Parameters.AddWithValue("@InvoiceStatus", InvoiceStatus);

                        int rowsAffected = insertCommand.ExecuteNonQuery();
                        if (rowsAffected > 0)
                        {
                            MessageBox.Show("Appointment data added successfully.", "Success");

                            // Generate QR Code
                            GenerateQRCode(patientName, description, appointmentDate, appointmentTime, cost);

                        }
                        else
                        {
                            MessageBox.Show("Failed to add appointment data.", "Error");
                        }
                    }
                }
            }

        }
        private void GenerateQRCode(string patientName, string description, string date, string time, string cost)
        {
            // Prepare the QR code content
            string qrContent = $"Appointment,\n Patient Name: {patientName}\nDate: {date}\nTime: {time}\nCost: {cost}\nDescription: {description}";

            using (var qrGenerator = new QRCodeGenerator())
            {
                QRCodeData qrCodeData = qrGenerator.CreateQrCode(qrContent, QRCodeGenerator.ECCLevel.Q);
                using (var qrCode = new QRCode(qrCodeData))
                {
                    // Generate QR code image
                    Bitmap qrCodeImage = qrCode.GetGraphic(20);

                    // Pass the image to the new form
                    qrcode2 qrForm = new qrcode2(qrCodeImage);
                    qrForm.Show();
                    this.Hide();
                }
            }
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void add_appoinment_Load(object sender, EventArgs e)
        {
            // Load patient data from the database
            List<Patient> patients = LoadPatientsFromDatabase();

            // Format data for display
            List<string> formattedPatientList = new List<string>();
            foreach (Patient patient in patients)
            {
                string formattedEntry = $"{patient.Id} - {patient.Name}";
                formattedPatientList.Add(formattedEntry);
            }

            // Populate the combopatient combo box
            combopatient.DataSource = formattedPatientList;

            // Load doctor data from the database and populate combodoctor
            List<Doctor> doctors = LoadDoctorsFromDatabase();
            foreach (Doctor doctor in doctors)
            {
                string formattedEntry = $"{doctor.Id} - {doctor.Name}";
                combodoctor.Items.Add(formattedEntry);
            }
            // Load additional data for comboname
            List<Patient> patients1 = LoadPatientsFromDatabase();

            // Format data for display
            List<string> formattedPatient1List = new List<string>();
            foreach (Patient patient in patients)
            {
                string formattedEntry = $"{patient.Id} - {patient.Name}";
                formattedPatient1List.Add(formattedEntry);
            }
            comboname.DataSource = formattedPatient1List;
        }

        private void txtcost_TextChanged(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void combodoctor_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
