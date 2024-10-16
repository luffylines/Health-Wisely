﻿namespace HealthCare_Plus.views.staff
{
    partial class doctor_shedule
    {
        /// <summary> 
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.combodoctor = new System.Windows.Forms.ComboBox();
            this.date = new System.Windows.Forms.DateTimePicker();
            this.btnavailability = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lbladmindashboard = new System.Windows.Forms.Label();
            this.panel2.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // combodoctor
            // 
            this.combodoctor.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.combodoctor.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.combodoctor.Font = new System.Drawing.Font("Calibri", 15.75F);
            this.combodoctor.FormattingEnabled = true;
            this.combodoctor.Location = new System.Drawing.Point(153, 34);
            this.combodoctor.Name = "combodoctor";
            this.combodoctor.Size = new System.Drawing.Size(316, 34);
            this.combodoctor.TabIndex = 29;
            // 
            // date
            // 
            this.date.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.date.Location = new System.Drawing.Point(153, 129);
            this.date.MaxDate = new System.DateTime(2025, 8, 20, 0, 0, 0, 0);
            this.date.MinDate = new System.DateTime(2023, 8, 20, 0, 0, 0, 0);
            this.date.Name = "date";
            this.date.Size = new System.Drawing.Size(316, 33);
            this.date.TabIndex = 28;
            this.date.Value = new System.DateTime(2024, 10, 18, 0, 0, 0, 0);
            // 
            // btnavailability
            // 
            this.btnavailability.BackColor = System.Drawing.Color.Teal;
            this.btnavailability.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnavailability.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnavailability.Font = new System.Drawing.Font("Nirmala UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnavailability.ForeColor = System.Drawing.Color.White;
            this.btnavailability.Location = new System.Drawing.Point(153, 247);
            this.btnavailability.Name = "btnavailability";
            this.btnavailability.Size = new System.Drawing.Size(288, 46);
            this.btnavailability.TabIndex = 27;
            this.btnavailability.Text = "Check Availability";
            this.btnavailability.UseVisualStyleBackColor = false;
            this.btnavailability.Click += new System.EventHandler(this.btnavailability_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F);
            this.label3.ForeColor = System.Drawing.Color.Black;
            this.label3.Location = new System.Drawing.Point(66, 44);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(65, 24);
            this.label3.TabIndex = 30;
            this.label3.Text = "Doctor";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.panel2.Controls.Add(this.label1);
            this.panel2.Controls.Add(this.btnavailability);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Controls.Add(this.date);
            this.panel2.Controls.Add(this.combodoctor);
            this.panel2.Location = new System.Drawing.Point(125, 112);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(586, 359);
            this.panel2.TabIndex = 32;
            this.panel2.Paint += new System.Windows.Forms.PaintEventHandler(this.panel2_Paint);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F);
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(83, 138);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(48, 24);
            this.label1.TabIndex = 31;
            this.label1.Text = "Date";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Red;
            this.panel1.Controls.Add(this.lbladmindashboard);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(900, 41);
            this.panel1.TabIndex = 34;
            // 
            // lbladmindashboard
            // 
            this.lbladmindashboard.AutoSize = true;
            this.lbladmindashboard.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lbladmindashboard.Font = new System.Drawing.Font("Arial Narrow", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbladmindashboard.ForeColor = System.Drawing.Color.Black;
            this.lbladmindashboard.Location = new System.Drawing.Point(14, 3);
            this.lbladmindashboard.Name = "lbladmindashboard";
            this.lbladmindashboard.Size = new System.Drawing.Size(390, 33);
            this.lbladmindashboard.TabIndex = 32;
            this.lbladmindashboard.Text = "Doctor Availability and Schedule";
            // 
            // doctor_shedule
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel2);
            this.Name = "doctor_shedule";
            this.Size = new System.Drawing.Size(900, 742);
            this.Load += new System.EventHandler(this.doctor_shedule_Load);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ComboBox combodoctor;
        private System.Windows.Forms.DateTimePicker date;
        private System.Windows.Forms.Button btnavailability;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lbladmindashboard;
    }
}
