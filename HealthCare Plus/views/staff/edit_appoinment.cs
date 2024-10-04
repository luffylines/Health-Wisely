﻿using HealthCare_Plus.Services;
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
using static HealthCare_Plus.Services.AddPatientRecords;

namespace HealthCare_Plus.views.staff
{
    public partial class edit_appoinment : UserControl
    {
        int appoinmentid;

        // database object 
        Database dbManager = new Database();
        public edit_appoinment(int appointmentId, string doctorId, string patientId, string patientName,
                                string description, DateTime date, string time, decimal cost)
        {
            InitializeComponent();


            // Use the values as needed in your "edit_appointments" form
            // For example, set text boxes or labels with the received data
            appoinmentid = appointmentId;
            lblpatient.Text = patientId;
            lbldoctor.Text = doctorId;
            lblpname.Text = patientName;
            txtcost.Text = cost.ToString();
            //date.Date = date.Date("yyyy/mm/dd");
            rtextdescription.Text = description;
            //time.

        }

     

        private void edit_appoinment_Load(object sender, EventArgs e)
        {

        }

        private void btncancel_Click(object sender, EventArgs e)
        {

            using (MySqlConnection connection = dbManager.GetConnection())
            {
                try
                {
                    dbManager.OpenConnection(connection);

                    // Define the SQL DELETE statement
                    string deleteQuery = "DELETE FROM appoiment WHERE id = @AppointmentId AND InvoiceStatus = 0";

                    using (MySqlCommand cmd = new MySqlCommand(deleteQuery, connection))
                    {
                        // Replace "appointmentId" with the actual appointment ID you want to delete
                        cmd.Parameters.AddWithValue("@AppointmentId", appoinmentid);

                        int rowsAffected = cmd.ExecuteNonQuery();

                        if (rowsAffected > 0)
                        {
                            // Deletion successful
                            MessageBox.Show("Appointment deleted successfully.");
                            appoinments appoinments = new appoinments();
                            if (ParentForm is staffDashboard staffDashboard)
                            {
                                staffDashboard.loadform(appoinments);
                            }
                        }
                        else
                        {
                            // No rows were deleted (appointment ID not found)
                            MessageBox.Show("Appointment already billed. deletion failed.");
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: " + ex.Message);
                }
            }

        }

        private void btnedit_Click(object sender, EventArgs e)
        {
            if (EditAppointmentValidations.IsValidFields(
         
           date,
           txtcost.Text.Trim(),
           rtextdescription.Text.Trim()))
            {
                // Validation successful, proceed with adding the appointment
                // Implement the code to add the appointment to the database here

                // Example code to insert the appointment into the database:
                using (MySqlConnection connection = dbManager.GetConnection())
                {
                    try
                    {
                        dbManager.OpenConnection(connection);

                        string updateQuery = "UPDATE appoiment " +
                     "SET Date = @Date, " +
                     "Time = @Time, " +
                     "Cost = @Cost, " +
                     "Description = @Description " + // Remove the comma here
                     "WHERE id = @AppointmentId";

                        using (MySqlCommand cmd = new MySqlCommand(updateQuery, connection))
                        {
                            // Set parameter values based on your form fields
                            cmd.Parameters.AddWithValue("@Date", date.Value.ToString("yyyy-MM-dd"));
                            cmd.Parameters.AddWithValue("@Time", time.Value.ToString("HH:mm:ss"));
                            cmd.Parameters.AddWithValue("@Cost", txtcost.Text.Trim());
                            cmd.Parameters.AddWithValue("@Description", rtextdescription.Text.Trim());
                            cmd.Parameters.AddWithValue("@AppointmentId", appoinmentid); // Replace with the actual appointment ID





                            int rowsAffected = cmd.ExecuteNonQuery();

                            if (rowsAffected > 0)
                            {
                                // Insertion successful
                                MessageBox.Show("Appointment edited successfully.");
                                appoinments appoinments = new appoinments();
                                if (ParentForm is staffDashboard staffDashboard)
                                {
                                    staffDashboard.loadform(appoinments);
                                }
                            }
                            else
                            {
                                // Insertion failed
                                MessageBox.Show("Failed to edit the appointment.");
                            }
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Error: " + ex.Message);
                    }
                }
            }
            // If validation fails, an appropriate error message will be shown
        }
    }
    }

