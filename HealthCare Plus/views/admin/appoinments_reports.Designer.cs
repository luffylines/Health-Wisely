﻿namespace HealthCare_Plus.views.admin
{
    partial class appoinments_reports
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.btngenerate = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lbladmindashboard = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.todate = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.fromdate = new System.Windows.Forms.DateTimePicker();
            this.btnexportpdf = new System.Windows.Forms.Button();
            this.appoinmentgridview = new System.Windows.Forms.DataGridView();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.appoinmentgridview)).BeginInit();
            this.SuspendLayout();
            // 
            // btngenerate
            // 
            this.btngenerate.BackColor = System.Drawing.Color.Teal;
            this.btngenerate.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btngenerate.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btngenerate.Font = new System.Drawing.Font("Nirmala UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btngenerate.ForeColor = System.Drawing.Color.White;
            this.btngenerate.Location = new System.Drawing.Point(468, 59);
            this.btngenerate.Name = "btngenerate";
            this.btngenerate.Size = new System.Drawing.Size(288, 46);
            this.btngenerate.TabIndex = 16;
            this.btngenerate.Text = "Generate";
            this.btngenerate.UseVisualStyleBackColor = false;
            this.btngenerate.Click += new System.EventHandler(this.btngenerate_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Red;
            this.panel1.Controls.Add(this.lbladmindashboard);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(910, 41);
            this.panel1.TabIndex = 44;
            // 
            // lbladmindashboard
            // 
            this.lbladmindashboard.AutoSize = true;
            this.lbladmindashboard.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lbladmindashboard.Font = new System.Drawing.Font("Arial Narrow", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbladmindashboard.ForeColor = System.Drawing.Color.Black;
            this.lbladmindashboard.Location = new System.Drawing.Point(14, 3);
            this.lbladmindashboard.Name = "lbladmindashboard";
            this.lbladmindashboard.Size = new System.Drawing.Size(266, 33);
            this.lbladmindashboard.TabIndex = 32;
            this.lbladmindashboard.Text = "Appoinments Reports";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(18, 18);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(55, 24);
            this.label2.TabIndex = 9;
            this.label2.Text = "From";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.panel2.Controls.Add(this.todate);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Controls.Add(this.fromdate);
            this.panel2.Controls.Add(this.btngenerate);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Location = new System.Drawing.Point(20, 47);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(871, 126);
            this.panel2.TabIndex = 43;
            // 
            // todate
            // 
            this.todate.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.todate.Location = new System.Drawing.Point(468, 9);
            this.todate.MaxDate = new System.DateTime(2025, 8, 20, 0, 0, 0, 0);
            this.todate.MinDate = new System.DateTime(2023, 8, 20, 0, 0, 0, 0);
            this.todate.Name = "todate";
            this.todate.Size = new System.Drawing.Size(358, 33);
            this.todate.TabIndex = 41;
            this.todate.Value = new System.DateTime(2024, 9, 26, 0, 0, 0, 0);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(429, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(33, 24);
            this.label1.TabIndex = 40;
            this.label1.Text = "To";
            // 
            // fromdate
            // 
            this.fromdate.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.fromdate.Location = new System.Drawing.Point(79, 12);
            this.fromdate.MaxDate = new System.DateTime(2025, 8, 20, 0, 0, 0, 0);
            this.fromdate.MinDate = new System.DateTime(2000, 1, 8, 0, 0, 0, 0);
            this.fromdate.Name = "fromdate";
            this.fromdate.Size = new System.Drawing.Size(322, 33);
            this.fromdate.TabIndex = 39;
            this.fromdate.Value = new System.DateTime(2024, 9, 17, 0, 0, 0, 0);
            // 
            // btnexportpdf
            // 
            this.btnexportpdf.BackColor = System.Drawing.Color.Teal;
            this.btnexportpdf.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnexportpdf.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnexportpdf.Font = new System.Drawing.Font("Nirmala UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnexportpdf.ForeColor = System.Drawing.Color.White;
            this.btnexportpdf.Location = new System.Drawing.Point(603, 613);
            this.btnexportpdf.Name = "btnexportpdf";
            this.btnexportpdf.Size = new System.Drawing.Size(288, 46);
            this.btnexportpdf.TabIndex = 46;
            this.btnexportpdf.Text = "Export";
            this.btnexportpdf.UseVisualStyleBackColor = false;
            this.btnexportpdf.Visible = false;
            this.btnexportpdf.Click += new System.EventHandler(this.btnexportpdf_Click);
            // 
            // appoinmentgridview
            // 
            this.appoinmentgridview.AllowUserToAddRows = false;
            this.appoinmentgridview.AllowUserToDeleteRows = false;
            this.appoinmentgridview.BackgroundColor = System.Drawing.Color.White;
            this.appoinmentgridview.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.appoinmentgridview.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft YaHei", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.appoinmentgridview.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.appoinmentgridview.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.GradientActiveCaption;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.appoinmentgridview.DefaultCellStyle = dataGridViewCellStyle2;
            this.appoinmentgridview.GridColor = System.Drawing.Color.Silver;
            this.appoinmentgridview.Location = new System.Drawing.Point(20, 179);
            this.appoinmentgridview.Name = "appoinmentgridview";
            this.appoinmentgridview.ReadOnly = true;
            this.appoinmentgridview.RowHeadersVisible = false;
            this.appoinmentgridview.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.Black;
            this.appoinmentgridview.RowsDefaultCellStyle = dataGridViewCellStyle3;
            this.appoinmentgridview.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.appoinmentgridview.Size = new System.Drawing.Size(871, 428);
            this.appoinmentgridview.TabIndex = 45;
            this.appoinmentgridview.Visible = false;
            // 
            // appoinments_reports
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.btnexportpdf);
            this.Controls.Add(this.appoinmentgridview);
            this.Name = "appoinments_reports";
            this.Size = new System.Drawing.Size(910, 674);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.appoinmentgridview)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btngenerate;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lbladmindashboard;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.DateTimePicker todate;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DateTimePicker fromdate;
        private System.Windows.Forms.Button btnexportpdf;
        private System.Windows.Forms.DataGridView appoinmentgridview;
    }
}
