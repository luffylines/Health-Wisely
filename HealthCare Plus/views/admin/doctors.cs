using Google.Protobuf.WellKnownTypes;
using HealthCare_Plus.Controllers;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HealthCare_Plus.views.admin
{
    public partial class doctors : UserControl
    {

        public doctors()
        {
            InitializeComponent();
        }
        // database object 
        Database dbManager = new Database();

        // load room data

        private void LoadDoctorData(string searchText = null)
        {
            using (MySqlConnection connection = dbManager.GetConnection())
            {
                dbManager.OpenConnection(connection);

                string selectQuery = "SELECT id, name, age, specialized_area, location, phone, email, qualifications FROM doctor"; // Default query for loading all data

                // Add search filter if searchText is provided
                if (!string.IsNullOrWhiteSpace(searchText))
                {
                    selectQuery += " WHERE id LIKE @SearchText OR " +
                                   "name LIKE @SearchText OR " +
                                   "specialized_area LIKE @SearchText OR " +
                                   "email LIKE @SearchText OR " +
                                   "qualifications LIKE @SearchText";
                }

                using (MySqlCommand cmd = new MySqlCommand(selectQuery, connection))
                {
                    if (!string.IsNullOrWhiteSpace(searchText))
                    {
                        cmd.Parameters.AddWithValue("@SearchText", "%" + searchText + "%");
                    }

                    using (MySqlDataReader reader = cmd.ExecuteReader())
                    {
                        
                        doctorgridview.Rows.Clear();

                        while (reader.Read())
                        {
                    int doctorId = Convert.ToInt32(reader["id"]);
                    string doctorName = reader["name"].ToString();
                    int doctorAge = Convert.ToInt32(reader["age"]);
                    string specializedArea = reader["specialized_area"].ToString();
                    string location = reader["location"].ToString();
                    string phone = reader["phone"].ToString();
                    string email = reader["email"].ToString();
                    string qualifications = reader["qualifications"].ToString();
                            doctorgridview.Rows.Add(doctorId, doctorName, doctorAge, specializedArea, location, phone, email, qualifications, "Edit");
                        }
                        foreach (DataGridViewRow row in doctorgridview.Rows)
                        {
                            row.Height = 30; // Set your desired height here for each row
                        }
                    }
                }
            }
        }
        private void doctor_Load(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                // Get the selected row
                DataGridViewRow selectedRow = doctorgridview.Rows[e.RowIndex];

                // Extract data from the selected row
                int doctorId = Convert.ToInt32(selectedRow.Cells["id"].Value);
                string doctorName = selectedRow.Cells["doctorName"].Value.ToString();
                string doctorAge = selectedRow.Cells["doctorAge"].Value.ToString();
                string specializedArea = selectedRow.Cells["specialized_area"].Value.ToString();
                string location = selectedRow.Cells["location"].Value.ToString();
                string phone = selectedRow.Cells["phone"].Value.ToString();
                string email = selectedRow.Cells["email"].Value.ToString();
                string qualifications = selectedRow.Cells["qualifications"].Value.ToString();


                // load patient edit

                doctor_edit patient_edit = new doctor_edit(doctorId, doctorName, doctorAge, specializedArea, location, phone, email, qualifications);

                if (ParentForm is adminDashboard adminDashboard)
                {
                    adminDashboard.loadform(patient_edit);
                }
            }
        }

        private void orders_Click(object sender, EventArgs e)
        {
            add_doctor addDoctorsForm = new add_doctor();
            if (ParentForm is adminDashboard adminDashboard)
            {
                adminDashboard.loadform(addDoctorsForm);
            }

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string search = txtsearch.Text.Trim().ToLower();
            LoadDoctorData(search);
        }

        private void doctors_Load(object sender, EventArgs e)
        {
            // Set up DataGridView columns for doctorgridview
            doctorgridview.Columns.Clear(); // Clear existing columns if necessary

            doctorgridview.Columns.Add("id", "Doctor ID");
            doctorgridview.Columns.Add("doctorName", "Name");
            doctorgridview.Columns.Add("doctorAge", "Age");
            doctorgridview.Columns.Add("specialized_area", "Specialized Area");
            doctorgridview.Columns.Add("location", "Location");
            doctorgridview.Columns.Add("phone", "Phone");
            doctorgridview.Columns.Add("email", "Email");
            doctorgridview.Columns.Add("qualifications", "Qualifications");


            // Set AutoSizeMode for columns
            doctorgridview.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill; // Reset before applying

            LoadDoctorData();
        }
    }
}
