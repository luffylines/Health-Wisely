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

namespace HealthCare_Plus.views.staff
{
    public partial class appoinments : UserControl
    {
        public appoinments()
        {
            InitializeComponent();
        }
        // database object 
        Database dbManager = new Database();

        // load room data
        private void LoadAppointmentData(string searchText = null)
        {

            using (MySqlConnection connection = dbManager.GetConnection())
            {
                dbManager.OpenConnection(connection);

                string selectQuery = "SELECT a.id,p.id AS PatientId, p.name AS PatientName, d.id AS DoctorId, " +
                             "a.description, a.date, a.time, a.isactive, a.cost " +
                             "FROM appoiment AS a " +
                             "INNER JOIN doctor AS d ON a.doctor_id = d.id " +
                             //"INNER JOIN patient AS p ON a.patient_name = p.name" +
                             "INNER JOIN patient AS p ON a.patient_id = p.id";

                // Add search filter if searchText is provided
                if (!string.IsNullOrWhiteSpace(searchText))
                {
                    selectQuery += " WHERE a.id LIKE @SearchText OR " +
                                   "p.name LIKE @SearchText OR " +
                                   "p.id LIKE @SearchText OR " +
                                   "d.id LIKE @SearchText";
                }

                using (MySqlCommand cmd = new MySqlCommand(selectQuery, connection))
                {
                    if (!string.IsNullOrWhiteSpace(searchText))
                    {
                        cmd.Parameters.AddWithValue("@SearchText", "%" + searchText + "%");
                    }

                    using (MySqlDataReader reader = cmd.ExecuteReader())
                    {
                        app.Rows.Clear();

                        while (reader.Read())
                        {
                            int appointmentId = Convert.ToInt32(reader["id"]);
                            string doctorId = reader["DoctorId"].ToString();
                            string patientId = reader["PatientId"].ToString();
                            ///string doctorName = reader["DoctorName"].ToString();
                            string patientName = reader["PatientName"].ToString(); // Added this line
                            string description = reader["description"].ToString();
                            DateTime date = Convert.ToDateTime(reader["date"]); // Ensure correct type
                            TimeSpan time = TimeSpan.Parse(reader["time"].ToString()); // Ensure correct type
                            decimal cost = Convert.ToDecimal(reader["cost"]); // Ensure correct type

                            app.Rows.Add(appointmentId, doctorId, patientId, patientName, description, date, time, cost, "Edit");
                        }
                    }
                }
            }

        }

        private void btnaddappoinment_Click(object sender, EventArgs e)
        {
            add_appoinment add_appoinment = new add_appoinment();
            if (ParentForm is staffDashboard staffDashboard)
            {
                staffDashboard.loadform(add_appoinment);
            }
        }

        private void appoinments_Load(object sender, EventArgs e)
        {
            // Set up DataGridView columns
            app.Columns.Clear(); // Clear existing columns if necessary

            app.Columns.Add("id", "Appointment ID");
            app.Columns.Add("DoctorId", "Doctor ID");
            app.Columns.Add("PatientId", "Patient ID");
            app.Columns.Add("PatientName", "Patient Name");
            app.Columns.Add("description", "Description");
            app.Columns.Add("date", "Date");
            app.Columns.Add("time", "Time");
            app.Columns.Add("cost", "Cost");
            // Set AutoSizeMode for columns
            app.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.None; // Optional: reset before applying
            app.Columns[0].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells; // Appointment ID
            app.Columns[1].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            app.Columns[3].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;// Doctor ID
            app.Columns[2].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;

            // Load appointment data
            LoadAppointmentData();

        }

        private void appoinmentgridview_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                // Get the selected row
                DataGridViewRow selectedRow = app.Rows[e.RowIndex];

                // Extract the values you want from the selected row
                int appointmentId = Convert.ToInt32(selectedRow.Cells["id"].Value);
                string doctorId = selectedRow.Cells["DoctorId"].Value.ToString();
                string patientId = selectedRow.Cells["PatientId"].Value.ToString();
                //string doctorName = selectedRow.Cells["DoctorName"].Value.ToString();
                string patientName = selectedRow.Cells["PatientName"].Value.ToString();
                string description = selectedRow.Cells["description"].Value.ToString();
                DateTime date = Convert.ToDateTime(selectedRow.Cells["date"].Value);
                string time = selectedRow.Cells["time"].Value.ToString();
                decimal cost = Convert.ToDecimal(selectedRow.Cells["cost"].Value);

                // Create an instance of the "edit_appointments" form
                edit_appoinment edit_appoinment = new edit_appoinment(appointmentId, doctorId, patientId, patientName, description, date, time, cost);

                if (ParentForm is staffDashboard staffDashboard)
                {
                    staffDashboard.loadform(edit_appoinment);
                }
                // Show the form
               

                // Optionally, handle any actions after the "edit_appointments" form is closed if needed
                // For example, refreshing the data grid view after editing
            }

        }

        private void btnappoint_Click(object sender, EventArgs e)
        {
            add_appoinment add_appoinment = new add_appoinment();
            if (ParentForm is staffDashboard staffDashboard)
            {
                staffDashboard.loadform(add_appoinment);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string search = txtsearch.Text;
            LoadAppointmentData(search);
        }

        private void txtsearch_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnsearch_Click(object sender, EventArgs e)
        {

        }
    }
}
