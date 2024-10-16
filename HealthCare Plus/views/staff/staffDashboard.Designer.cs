﻿namespace HealthCare_Plus.views.staff
{
    partial class staffDashboard
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(staffDashboard));
            this.paneltop = new System.Windows.Forms.Panel();
            this.picboxminimize = new System.Windows.Forms.PictureBox();
            this.picboxclose = new System.Windows.Forms.PictureBox();
            this.picboxlogout = new System.Windows.Forms.PictureBox();
            this.lblstaffdashboard = new System.Windows.Forms.Label();
            this.panelsidebar = new System.Windows.Forms.Panel();
            this.rooms = new System.Windows.Forms.Button();
            this.picboxlogo = new System.Windows.Forms.PictureBox();
            this.btnmedications = new System.Windows.Forms.Button();
            this.btnappoinments = new System.Windows.Forms.Button();
            this.btcdoctors = new System.Windows.Forms.Button();
            this.btnrooms = new System.Windows.Forms.Button();
            this.btndoctors = new System.Windows.Forms.Button();
            this.panelcontent = new System.Windows.Forms.Panel();
            this.paneltop.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picboxminimize)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picboxclose)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picboxlogout)).BeginInit();
            this.panelsidebar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picboxlogo)).BeginInit();
            this.SuspendLayout();
            // 
            // paneltop
            // 
            this.paneltop.BackColor = System.Drawing.Color.White;
            this.paneltop.Controls.Add(this.picboxlogout);
            this.paneltop.Controls.Add(this.lblstaffdashboard);
            this.paneltop.Controls.Add(this.picboxminimize);
            this.paneltop.Controls.Add(this.picboxclose);
            this.paneltop.Dock = System.Windows.Forms.DockStyle.Top;
            this.paneltop.Location = new System.Drawing.Point(234, 0);
            this.paneltop.Name = "paneltop";
            this.paneltop.Size = new System.Drawing.Size(911, 69);
            this.paneltop.TabIndex = 4;
            this.paneltop.Paint += new System.Windows.Forms.PaintEventHandler(this.paneltop_Paint);
            // 
            // picboxminimize
            // 
            this.picboxminimize.Cursor = System.Windows.Forms.Cursors.Hand;
            this.picboxminimize.Image = ((System.Drawing.Image)(resources.GetObject("picboxminimize.Image")));
            this.picboxminimize.Location = new System.Drawing.Point(778, 13);
            this.picboxminimize.Name = "picboxminimize";
            this.picboxminimize.Size = new System.Drawing.Size(44, 41);
            this.picboxminimize.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picboxminimize.TabIndex = 40;
            this.picboxminimize.TabStop = false;
            this.picboxminimize.Click += new System.EventHandler(this.picboxminimize_Click_1);
            // 
            // picboxclose
            // 
            this.picboxclose.Cursor = System.Windows.Forms.Cursors.Hand;
            this.picboxclose.Image = ((System.Drawing.Image)(resources.GetObject("picboxclose.Image")));
            this.picboxclose.Location = new System.Drawing.Point(864, 13);
            this.picboxclose.Name = "picboxclose";
            this.picboxclose.Size = new System.Drawing.Size(47, 41);
            this.picboxclose.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picboxclose.TabIndex = 34;
            this.picboxclose.TabStop = false;
            this.picboxclose.Click += new System.EventHandler(this.picboxclose_Click);
            // 
            // picboxlogout
            // 
            this.picboxlogout.Cursor = System.Windows.Forms.Cursors.Hand;
            this.picboxlogout.Image = ((System.Drawing.Image)(resources.GetObject("picboxlogout.Image")));
            this.picboxlogout.Location = new System.Drawing.Point(828, 16);
            this.picboxlogout.Name = "picboxlogout";
            this.picboxlogout.Size = new System.Drawing.Size(35, 34);
            this.picboxlogout.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picboxlogout.TabIndex = 30;
            this.picboxlogout.TabStop = false;
            this.picboxlogout.Click += new System.EventHandler(this.picboxlogout_Click);
            // 
            // lblstaffdashboard
            // 
            this.lblstaffdashboard.AutoSize = true;
            this.lblstaffdashboard.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lblstaffdashboard.Font = new System.Drawing.Font("Century Gothic", 24F, System.Drawing.FontStyle.Bold);
            this.lblstaffdashboard.ForeColor = System.Drawing.Color.Black;
            this.lblstaffdashboard.Location = new System.Drawing.Point(272, 16);
            this.lblstaffdashboard.Name = "lblstaffdashboard";
            this.lblstaffdashboard.Size = new System.Drawing.Size(261, 38);
            this.lblstaffdashboard.TabIndex = 31;
            this.lblstaffdashboard.Text = "Staff Dashboard";
            // 
            // panelsidebar
            // 
            this.panelsidebar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.panelsidebar.Controls.Add(this.rooms);
            this.panelsidebar.Controls.Add(this.picboxlogo);
            this.panelsidebar.Controls.Add(this.btnmedications);
            this.panelsidebar.Controls.Add(this.btnappoinments);
            this.panelsidebar.Controls.Add(this.btcdoctors);
            this.panelsidebar.Controls.Add(this.btnrooms);
            this.panelsidebar.Controls.Add(this.btndoctors);
            this.panelsidebar.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelsidebar.Location = new System.Drawing.Point(0, 0);
            this.panelsidebar.Name = "panelsidebar";
            this.panelsidebar.Size = new System.Drawing.Size(234, 788);
            this.panelsidebar.TabIndex = 3;
            // 
            // rooms
            // 
            this.rooms.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(7)))), ((int)(((byte)(39)))), ((int)(((byte)(105)))));
            this.rooms.Cursor = System.Windows.Forms.Cursors.Hand;
            this.rooms.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.rooms.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rooms.ForeColor = System.Drawing.Color.White;
            this.rooms.Location = new System.Drawing.Point(32, 607);
            this.rooms.Name = "rooms";
            this.rooms.Size = new System.Drawing.Size(165, 58);
            this.rooms.TabIndex = 36;
            this.rooms.Text = "ROOMS";
            this.rooms.UseVisualStyleBackColor = false;
            this.rooms.Click += new System.EventHandler(this.rooms_Click);
            // 
            // picboxlogo
            // 
            this.picboxlogo.Image = ((System.Drawing.Image)(resources.GetObject("picboxlogo.Image")));
            this.picboxlogo.Location = new System.Drawing.Point(57, 11);
            this.picboxlogo.Name = "picboxlogo";
            this.picboxlogo.Size = new System.Drawing.Size(100, 96);
            this.picboxlogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picboxlogo.TabIndex = 35;
            this.picboxlogo.TabStop = false;
            // 
            // btnmedications
            // 
            this.btnmedications.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(7)))), ((int)(((byte)(39)))), ((int)(((byte)(105)))));
            this.btnmedications.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnmedications.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnmedications.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnmedications.ForeColor = System.Drawing.Color.White;
            this.btnmedications.Location = new System.Drawing.Point(32, 511);
            this.btnmedications.Name = "btnmedications";
            this.btnmedications.Size = new System.Drawing.Size(165, 58);
            this.btnmedications.TabIndex = 7;
            this.btnmedications.Text = "MEDICATIONS";
            this.btnmedications.UseVisualStyleBackColor = false;
            this.btnmedications.Click += new System.EventHandler(this.btnreports_Click);
            // 
            // btnappoinments
            // 
            this.btnappoinments.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(7)))), ((int)(((byte)(39)))), ((int)(((byte)(105)))));
            this.btnappoinments.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnappoinments.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnappoinments.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnappoinments.ForeColor = System.Drawing.Color.White;
            this.btnappoinments.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.btnappoinments.Location = new System.Drawing.Point(32, 147);
            this.btnappoinments.Name = "btnappoinments";
            this.btnappoinments.Size = new System.Drawing.Size(165, 58);
            this.btnappoinments.TabIndex = 6;
            this.btnappoinments.Text = "APPOINMENTS";
            this.btnappoinments.UseVisualStyleBackColor = false;
            this.btnappoinments.Click += new System.EventHandler(this.btnappoinments_Click);
            // 
            // btcdoctors
            // 
            this.btcdoctors.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(7)))), ((int)(((byte)(39)))), ((int)(((byte)(105)))));
            this.btcdoctors.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btcdoctors.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btcdoctors.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btcdoctors.ForeColor = System.Drawing.Color.White;
            this.btcdoctors.Location = new System.Drawing.Point(32, 234);
            this.btcdoctors.Name = "btcdoctors";
            this.btcdoctors.Size = new System.Drawing.Size(163, 58);
            this.btcdoctors.TabIndex = 10;
            this.btcdoctors.Text = "DOCTOR SCHEDULE";
            this.btcdoctors.UseVisualStyleBackColor = false;
            this.btcdoctors.Click += new System.EventHandler(this.btcdoctors_Click);
            // 
            // btnrooms
            // 
            this.btnrooms.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(7)))), ((int)(((byte)(39)))), ((int)(((byte)(105)))));
            this.btnrooms.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnrooms.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnrooms.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnrooms.ForeColor = System.Drawing.Color.White;
            this.btnrooms.Location = new System.Drawing.Point(32, 317);
            this.btnrooms.Name = "btnrooms";
            this.btnrooms.Size = new System.Drawing.Size(163, 58);
            this.btnrooms.TabIndex = 8;
            this.btnrooms.Text = "PATIENT RECORDS";
            this.btnrooms.UseVisualStyleBackColor = false;
            this.btnrooms.Click += new System.EventHandler(this.btnrooms_Click);
            // 
            // btndoctors
            // 
            this.btndoctors.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(7)))), ((int)(((byte)(39)))), ((int)(((byte)(105)))));
            this.btndoctors.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btndoctors.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btndoctors.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btndoctors.ForeColor = System.Drawing.Color.White;
            this.btndoctors.Location = new System.Drawing.Point(30, 410);
            this.btndoctors.Name = "btndoctors";
            this.btndoctors.Size = new System.Drawing.Size(165, 58);
            this.btndoctors.TabIndex = 9;
            this.btndoctors.Text = "DOCTORS";
            this.btndoctors.UseVisualStyleBackColor = false;
            this.btndoctors.Click += new System.EventHandler(this.btndoctors_Click);
            // 
            // panelcontent
            // 
            this.panelcontent.Location = new System.Drawing.Point(240, 75);
            this.panelcontent.Name = "panelcontent";
            this.panelcontent.Size = new System.Drawing.Size(900, 742);
            this.panelcontent.TabIndex = 5;
            this.panelcontent.Paint += new System.Windows.Forms.PaintEventHandler(this.panelcontent_Paint);
            // 
            // staffDashboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1145, 788);
            this.Controls.Add(this.paneltop);
            this.Controls.Add(this.panelsidebar);
            this.Controls.Add(this.panelcontent);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "staffDashboard";
            this.Text = "staffDashboard";
            this.Load += new System.EventHandler(this.staffDashboard_Load);
            this.paneltop.ResumeLayout(false);
            this.paneltop.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picboxminimize)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picboxclose)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picboxlogout)).EndInit();
            this.panelsidebar.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.picboxlogo)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel paneltop;
        private System.Windows.Forms.PictureBox picboxclose;
        private System.Windows.Forms.PictureBox picboxlogout;
        private System.Windows.Forms.Label lblstaffdashboard;
        private System.Windows.Forms.Panel panelsidebar;
        private System.Windows.Forms.PictureBox picboxlogo;
        private System.Windows.Forms.Button btnmedications;
        private System.Windows.Forms.Button btnappoinments;
        private System.Windows.Forms.Button btcdoctors;
        private System.Windows.Forms.Button btnrooms;
        private System.Windows.Forms.Button btndoctors;
        private System.Windows.Forms.Panel panelcontent;
        private System.Windows.Forms.Button rooms;
        private System.Windows.Forms.PictureBox picboxminimize;
    }
}