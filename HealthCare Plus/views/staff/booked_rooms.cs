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
    public partial class booked_rooms : UserControl
    {
        public booked_rooms()
        {
            InitializeComponent();
        }

        // load data to table

        private void LoadDataToBookedRoomsGridView(string searchText = null)
        {

            // database object 
            Database dbManager = new Database();

            using (MySqlConnection connection = dbManager.GetConnection())
            {
                dbManager.OpenConnection(connection);

                string selectQuery = "SELECT ra.id AS ID, p.name AS Patient, r.room_name AS Room, ra.admit_date AS AdmitDate, ra.discharge_date AS DischargeDate, ra.cost AS Cost " +
                                     "FROM room_allowcation ra " +
                                     "INNER JOIN patient p ON ra.patient_id = p.id " +
                                     "INNER JOIN rooms r ON ra.room_id = r.id";

                if (!string.IsNullOrWhiteSpace(searchText))
                {
                    selectQuery += $" WHERE ra.id LIKE '%{searchText}%' OR p.name LIKE '%{searchText}%'OR ra.admit_date LIKE '%{searchText}%' OR r.room_name LIKE '%{searchText}%'";
                }

                using (MySqlDataAdapter adapter = new MySqlDataAdapter(selectQuery, connection))
                {
                    DataTable dataTable = new DataTable();
                    adapter.Fill(dataTable);

                    bookedroomsgridview.DataSource = dataTable;
                }
            }
        }

        private void booked_rooms_Load(object sender, EventArgs e)
        {
            LoadDataToBookedRoomsGridView();
            // Set AutoSizeMode for DataGridView columns
            bookedroomsgridview.Columns["ID"].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            bookedroomsgridview.Columns["Patient"].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            bookedroomsgridview.Columns["Room"].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells; // Fill remaining space
            bookedroomsgridview.Columns["AdmitDate"].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            bookedroomsgridview.Columns["DischargeDate"].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            bookedroomsgridview.Columns["Cost"].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;

        }

        private void bookedroomsgridview_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                string room = bookedroomsgridview.Rows[e.RowIndex].Cells["Room"].Value.ToString();
                int allowcation_id = Convert.ToInt32(bookedroomsgridview.Rows[e.RowIndex].Cells["ID"].Value);

                // Open the new form and pass the selected room ID and value
                discharge discharge = new discharge(allowcation_id, room);
                if (ParentForm is staffDashboard staffDashboard)
                {
                    staffDashboard.loadform(discharge);
                }
            }
        }

        private void btnsearch_Click(object sender, EventArgs e)
        {
            string searchText = btnsearch.Text.Trim().ToLower();
            LoadDataToBookedRoomsGridView(searchText);
        }

        private void txtsearch_TextChanged(object sender, EventArgs e)
        {
        }
    }
}
