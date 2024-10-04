﻿using HealthCare_Plus.Controllers;
using HealthCare_Plus.Services;
using HealthCare_Plus.views.staff;
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
using static Google.Protobuf.Reflection.SourceCodeInfo.Types;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;

namespace HealthCare_Plus.views.admin
{
    public partial class doctor_edit : UserControl
    {
        private int doctorId;
        private string doctorName;
        private string _age;
        private string _location;
        private string _phone;
        private string _email;
        private string _specialized;
        private string _qualifications;

        public doctor_edit(int id, string name, string age, string location, string phone, string email, string specialized, string qualifications)
        {
            InitializeComponent();



            // Store the doctor ID
            doctorId = id;

            // get arguments to vriables
            _age = age;
            doctorName = name;
            _location = location;
            _phone = phone;
            _email = email;
            _specialized = specialized;
            _qualifications = qualifications;

        }

        // call doctor class
        doctorClass doctorClass = new doctorClass();

        private void doctor_edit_Load(object sender, EventArgs e)
        {
            // load  database values to componenets
            txtname.Text = doctorName;
            txtage.Text = _age;
            txtlocation.Text = _location;
            txtphone.Text = _phone;
            txtemail.Text = _email;
            txtspecialized.Text = _specialized;
            rtextqualifications.Text = _qualifications;
        }

        private void btnadd_Click(object sender, EventArgs e)
        {
            //check validations
            if (AddDoctorValidations.IsValidFormFields(
                   txtname.Text.Trim(),
                   txtage.Text.Trim(),
                   txtlocation.Text.Trim(),
                   txtphone.Text.Trim(),
                   txtemail.Text.Trim(),
                   txtspecialized.Text.Trim(),
                   rtextqualifications.Text.Trim()))
            {
                // call updatedoctor data sending values
                string name = txtname.Text.Trim();
                string age = txtage.Text.Trim();
                string location = txtlocation.Text.Trim();
                string phone = txtphone.Text.Trim();
                string email = txtemail.Text.Trim();
                string specialized = txtspecialized.Text.Trim();
                string qualifications = rtextqualifications.Text.Trim();

                if (doctorClass.UpdateDoctorData(doctorId, name, age, location, phone, email, specialized, qualifications) )
                {
                    //success message
                    MessageBox.Show("Doctor data updated successfully.", "Success");

                    //back to doctos
                    doctors doctorsForm = new doctors();
                    if (ParentForm is adminDashboard adminDashboard)
                    {
                        adminDashboard.loadform(doctorsForm);
                    }

                } else
                {   // error message if failed
                    MessageBox.Show("Failed to update doctor data.", "Error");
                }
            }
        }

        private void txtage_TextChanged(object sender, EventArgs e)
        {

        }

        ////
    }
}
