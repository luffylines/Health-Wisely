using HealthCare_Plus.Services;
using HealthCare_Plus.views.admin;
using MySql.Data.MySqlClient;
using System;
using System.Data;
using System.Windows.Forms;

namespace HealthCare_Plus.Controllers
{
    internal class doctorClass
    {
        // database object 
        Database dbManager = new Database();

        // Add doctor method
        public bool AddDoctor(string name, string age, string location, string phone, string email, string specialized, string qualifications)
        {
            using (MySqlConnection connection = dbManager.GetConnection())
            {
                dbManager.OpenConnection(connection);

                string insertQuery = "INSERT INTO doctor (name, age, specialized_area, location, phone, email, qualifications) VALUES (@Name, @Age, @Specialized, @Location, @Phone, @Email, @Qualifications)";

                using (MySqlCommand insertCommand = new MySqlCommand(insertQuery, connection))
                {
                    insertCommand.Parameters.AddWithValue("@Name", name);
                    insertCommand.Parameters.AddWithValue("@Age", age);
                    insertCommand.Parameters.AddWithValue("@Specialized", specialized);
                    insertCommand.Parameters.AddWithValue("@Location", location);
                    insertCommand.Parameters.AddWithValue("@Phone", phone);
                    insertCommand.Parameters.AddWithValue("@Email", email);
                    insertCommand.Parameters.AddWithValue("@Qualifications", qualifications);

                    return insertCommand.ExecuteNonQuery() > 0; // Return true if rows affected
                }
            }
        }

        // Load doctor data
        public void LoadDoctorData(DataGridView doctorGridView, string searchText = null)
        {
            using (MySqlConnection connection = dbManager.GetConnection())
            {
                dbManager.OpenConnection(connection);

                string selectQuery = "SELECT id, name, age, specialized_area, location, phone, email, qualifications FROM doctor";

                if (!string.IsNullOrWhiteSpace(searchText))
                {
                    selectQuery += $" WHERE id LIKE '%{searchText}%' OR name LIKE '%{searchText}%' OR specialized_area LIKE '%{searchText}%' OR email LIKE '%{searchText}%' OR qualifications LIKE '%{searchText}%'";
                }

                using (MySqlDataAdapter adapter = new MySqlDataAdapter(selectQuery, connection))
                {
                    DataTable dataTable = new DataTable();
                    adapter.Fill(dataTable);
                    doctorGridView.DataSource = dataTable;

                    // Set AutoSizeMode for the DataGridView columns
                    SetAutoSizeMode(doctorGridView);
                }
            }
        }

        // Load doctor schedule
        public void LoadDoctorSchedule(DataGridView doctorGridView, int doctorId)
        {
            using (MySqlConnection connection = dbManager.GetConnection())
            {
                dbManager.OpenConnection(connection);

                string selectQuery = "SELECT a.id, p.name AS PatientName, a.description, a.date, a.time, a.cost " +
                                     "FROM appoiment a " +
                                     "INNER JOIN patient p ON a.patient_id = p.id " +
                                     "WHERE a.doctor_id = @DoctorId";

                using (MySqlCommand cmd = new MySqlCommand(selectQuery, connection))
                {
                    cmd.Parameters.AddWithValue("@DoctorId", doctorId);

                    using (MySqlDataAdapter adapter = new MySqlDataAdapter(cmd))
                    {
                        DataTable dataTable = new DataTable();
                        adapter.Fill(dataTable);
                        doctorGridView.DataSource = dataTable;

                        // Set AutoSizeMode for the DataGridView columns
                        SetAutoSizeMode(doctorGridView);
                    }
                }
            }
        }

        // Set AutoSizeMode for columns
        private void SetAutoSizeMode(DataGridView gridView)
        {
            foreach (DataGridViewColumn column in gridView.Columns)
            {
                if (column.Name == "id")
                {
                    column.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
                }
                else
                {
                    column.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill; // Adjust according to your needs
                }
            }
        }

        // Load individual doctor data
        public void LoadDoctorDataInduvidual(int doctorId, Label lblName, Label lblAge, Label lblLocation, Label lblPhone, Label lblEmail, Label lblSpecialized, Label lblQualifications)
        {
            using (MySqlConnection connection = dbManager.GetConnection())
            {
                dbManager.OpenConnection(connection);

                string selectQuery = "SELECT * FROM doctor WHERE id = @DoctorId";

                using (MySqlCommand cmd = new MySqlCommand(selectQuery, connection))
                {
                    cmd.Parameters.AddWithValue("@DoctorId", doctorId);

                    using (MySqlDataReader reader = cmd.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            lblName.Text = reader["name"].ToString();
                            lblAge.Text = reader["age"].ToString();
                            lblLocation.Text = reader["location"].ToString();
                            lblPhone.Text = reader["phone"].ToString();
                            lblEmail.Text = reader["email"].ToString();
                            lblSpecialized.Text = reader["specialized_area"].ToString();
                            lblQualifications.Text = reader["qualifications"].ToString();
                        }
                    }
                }
            }
        }

        // Update doctor data
        public bool UpdateDoctorData(int doctorId, string name, string age, string location, string phone, string email, string specialized, string qualifications)
        {
            using (MySqlConnection connection = dbManager.GetConnection())
            {
                dbManager.OpenConnection(connection);

                string updateQuery = "UPDATE doctor SET name = @Name, age = @Age, specialized_area = @Specialized, location = @Location, phone = @Phone, email = @Email, qualifications = @Qualifications WHERE id = @DoctorId";

                using (MySqlCommand updateCommand = new MySqlCommand(updateQuery, connection))
                {
                    updateCommand.Parameters.AddWithValue("@DoctorId", doctorId);
                    updateCommand.Parameters.AddWithValue("@Name", name);
                    updateCommand.Parameters.AddWithValue("@Age", age);
                    updateCommand.Parameters.AddWithValue("@Specialized", specialized);
                    updateCommand.Parameters.AddWithValue("@Location", location);
                    updateCommand.Parameters.AddWithValue("@Phone", phone);
                    updateCommand.Parameters.AddWithValue("@Email", email);
                    updateCommand.Parameters.AddWithValue("@Qualifications", qualifications);

                    return updateCommand.ExecuteNonQuery() > 0; // Return true if rows affected
                }
            }
        }
    }
}
