using MySql.Data.MySqlClient;
using System;
using System.Data;
using System.Windows.Forms;

namespace HealthCare_Plus.Controllers
{
    internal class patientsClass
    {
        // database object 
        Database dbManager = new Database();

        // Add patient
        public bool InsertPatientData(string name, string age, string address, string phone, string bloodType, string description, string isActive)
        {
            using (MySqlConnection connection = dbManager.GetConnection())
            {
                dbManager.OpenConnection(connection);

                string insertQuery = "INSERT INTO patient (name, age, address, phone, blood_type, description, is_active) VALUES (@Name, @Age, @Address, @Phone, @BloodType, @Description, @IsActive)";

                using (MySqlCommand insertCommand = new MySqlCommand(insertQuery, connection))
                {
                    insertCommand.Parameters.AddWithValue("@Name", name);
                    insertCommand.Parameters.AddWithValue("@Age", age);
                    insertCommand.Parameters.AddWithValue("@Address", address);
                    insertCommand.Parameters.AddWithValue("@Phone", phone);
                    insertCommand.Parameters.AddWithValue("@BloodType", bloodType);
                    insertCommand.Parameters.AddWithValue("@Description", description);
                    insertCommand.Parameters.AddWithValue("@IsActive", isActive);

                    int rowsAffected = insertCommand.ExecuteNonQuery();
                    return rowsAffected > 0;
                }
            }
        }

        // Load patient data
        public void LoadPatientData(DataGridView patientGridView, string searchText = null)
        {
            using (MySqlConnection connection = dbManager.GetConnection())
            {
                dbManager.OpenConnection(connection);

                string selectQuery = "SELECT id, name, address, phone, age, blood_type, description FROM patient"; // Default query for loading all patient data

                if (!string.IsNullOrWhiteSpace(searchText))
                {
                    selectQuery += $" WHERE id LIKE '%{searchText}%' OR name LIKE '%{searchText}%' OR address LIKE '%{searchText}%'";
                }

                using (MySqlDataAdapter adapter = new MySqlDataAdapter(selectQuery, connection))
                {
                    DataTable dataTable = new DataTable();
                    adapter.Fill(dataTable);

                    patientGridView.DataSource = dataTable;

                    // Set AutoSizeMode for the DataGridView columns
                    SetAutoSizeMode(patientGridView);
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
    }
}
