﻿using MySql.Data.MySqlClient;
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
    public partial class rooms : UserControl
    {
        public rooms()
        {
            InitializeComponent();
        }

        // database object 
        Database dbManager = new Database();

        // load room data

        private void LoadRoomData(string searchText = null)
        {
            using (MySqlConnection connection = dbManager.GetConnection())
            {
                dbManager.OpenConnection(connection);

                string selectQuery = "SELECT id, room_name, room_type, availability FROM rooms";

                // Add search filter if searchText is provided
                if (!string.IsNullOrWhiteSpace(searchText))
                {
                        selectQuery += " WHERE id LIKE @SearchText OR " +
                                       "room_name LIKE @SearchText OR " +
                                       "room_type LIKE @SearchText OR " +
                                       "availability LIKE @SearchText";
                }

                using (MySqlCommand cmd = new MySqlCommand(selectQuery, connection))
                {
                    if (!string.IsNullOrWhiteSpace(searchText))
                    {
                        cmd.Parameters.AddWithValue("@SearchText", "%" + searchText + "%");
                    }

                    using (MySqlDataReader reader = cmd.ExecuteReader())
                    {
                        // Clear existing data in the roomgridview
                        roomgridview.Rows.Clear();

                        while (reader.Read())
                        {
                            // Retrieve room data from the reader
                            int roomId = Convert.ToInt32(reader["id"]);
                            string roomName = reader["room_name"].ToString();
                            string roomType = reader["room_type"].ToString();
                            int availability = Convert.ToInt32(reader["availability"]);

                            // Map availability to "Available" or "Not Available"
                            string availabilityText = availability == 1 ? "Available" : "Not Available";

                            // Add the room data to the roomgridview
                            roomgridview.Rows.Add(roomId, roomName, roomType, availabilityText, "Edit");
                        }
                    }
                }
            }
        }



        private void rooms_Load(object sender, EventArgs e)
        {
            LoadRoomData();
        }

        private void btnaddroom_Click(object sender, EventArgs e)
        {
            add_room add_room = new add_room();
            if (ParentForm is adminDashboard adminDashboard)
            {
                adminDashboard.loadform(add_room);
            }
        }

        private void btnsearch_Click(object sender, EventArgs e)
        {
            string search = txtsearch.Text;
            LoadRoomData(search);
        }

        private void txtsearch_TextChanged(object sender, EventArgs e)
        {

        }

        private void roomgridview_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
