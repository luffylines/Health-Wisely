namespace HealthCare_Plus
{
    partial class Main
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Main));
            this.paneltop = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.picboxclose = new System.Windows.Forms.PictureBox();
            this.picboxminimize = new System.Windows.Forms.PictureBox();
            this.lblstaffdashboard = new System.Windows.Forms.Label();
            this.panelsidebar = new System.Windows.Forms.Panel();
            this.picboxlogo = new System.Windows.Forms.PictureBox();
            this.btnappoinments = new System.Windows.Forms.Button();
            this.btcdoctors = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.paneltop.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picboxclose)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picboxminimize)).BeginInit();
            this.panelsidebar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picboxlogo)).BeginInit();
            this.SuspendLayout();
            // 
            // paneltop
            // 
            this.paneltop.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.paneltop.Controls.Add(this.label1);
            this.paneltop.Controls.Add(this.picboxclose);
            this.paneltop.Controls.Add(this.picboxminimize);
            this.paneltop.Dock = System.Windows.Forms.DockStyle.Top;
            this.paneltop.Location = new System.Drawing.Point(226, 0);
            this.paneltop.Name = "paneltop";
            this.paneltop.Size = new System.Drawing.Size(926, 69);
            this.paneltop.TabIndex = 6;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Imprint MT Shadow", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.SeaShell;
            this.label1.Location = new System.Drawing.Point(79, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(490, 32);
            this.label1.TabIndex = 12;
            this.label1.Text = "WELCOME TO HEALTH WISELY\r\n";
            // 
            // picboxclose
            // 
            this.picboxclose.Cursor = System.Windows.Forms.Cursors.Hand;
            this.picboxclose.Image = ((System.Drawing.Image)(resources.GetObject("picboxclose.Image")));
            this.picboxclose.Location = new System.Drawing.Point(869, 11);
            this.picboxclose.Name = "picboxclose";
            this.picboxclose.Size = new System.Drawing.Size(37, 39);
            this.picboxclose.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picboxclose.TabIndex = 34;
            this.picboxclose.TabStop = false;
            this.picboxclose.Click += new System.EventHandler(this.picboxclose_Click);
            // 
            // picboxminimize
            // 
            this.picboxminimize.Cursor = System.Windows.Forms.Cursors.Hand;
            this.picboxminimize.Image = ((System.Drawing.Image)(resources.GetObject("picboxminimize.Image")));
            this.picboxminimize.Location = new System.Drawing.Point(814, 11);
            this.picboxminimize.Name = "picboxminimize";
            this.picboxminimize.Size = new System.Drawing.Size(37, 39);
            this.picboxminimize.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picboxminimize.TabIndex = 33;
            this.picboxminimize.TabStop = false;
            this.picboxminimize.Click += new System.EventHandler(this.picboxminimize_Click);
            // 
            // lblstaffdashboard
            // 
            this.lblstaffdashboard.AutoSize = true;
            this.lblstaffdashboard.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lblstaffdashboard.Font = new System.Drawing.Font("Century Gothic", 24F, System.Drawing.FontStyle.Bold);
            this.lblstaffdashboard.ForeColor = System.Drawing.Color.White;
            this.lblstaffdashboard.Location = new System.Drawing.Point(56, 185);
            this.lblstaffdashboard.Name = "lblstaffdashboard";
            this.lblstaffdashboard.Size = new System.Drawing.Size(103, 38);
            this.lblstaffdashboard.TabIndex = 31;
            this.lblstaffdashboard.Text = "MAIN";
            this.lblstaffdashboard.Click += new System.EventHandler(this.lblstaffdashboard_Click);
            // 
            // panelsidebar
            // 
            this.panelsidebar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.panelsidebar.Controls.Add(this.picboxlogo);
            this.panelsidebar.Controls.Add(this.lblstaffdashboard);
            this.panelsidebar.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelsidebar.Location = new System.Drawing.Point(0, 0);
            this.panelsidebar.Name = "panelsidebar";
            this.panelsidebar.Size = new System.Drawing.Size(226, 761);
            this.panelsidebar.TabIndex = 5;
            // 
            // picboxlogo
            // 
            this.picboxlogo.BackColor = System.Drawing.Color.Gray;
            this.picboxlogo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.picboxlogo.Image = ((System.Drawing.Image)(resources.GetObject("picboxlogo.Image")));
            this.picboxlogo.Location = new System.Drawing.Point(29, 18);
            this.picboxlogo.Name = "picboxlogo";
            this.picboxlogo.Size = new System.Drawing.Size(178, 132);
            this.picboxlogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picboxlogo.TabIndex = 35;
            this.picboxlogo.TabStop = false;
            // 
            // btnappoinments
            // 
            this.btnappoinments.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(7)))), ((int)(((byte)(39)))), ((int)(((byte)(105)))));
            this.btnappoinments.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnappoinments.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnappoinments.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnappoinments.ForeColor = System.Drawing.Color.White;
            this.btnappoinments.Location = new System.Drawing.Point(270, 91);
            this.btnappoinments.Name = "btnappoinments";
            this.btnappoinments.Size = new System.Drawing.Size(141, 50);
            this.btnappoinments.TabIndex = 6;
            this.btnappoinments.Text = "ADMIN LOGIN";
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
            this.btcdoctors.Location = new System.Drawing.Point(465, 91);
            this.btcdoctors.Name = "btcdoctors";
            this.btcdoctors.Size = new System.Drawing.Size(130, 50);
            this.btcdoctors.TabIndex = 10;
            this.btcdoctors.Text = "STAFF LOGIN";
            this.btcdoctors.UseVisualStyleBackColor = false;
            this.btcdoctors.Click += new System.EventHandler(this.btcdoctors_Click);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(7)))), ((int)(((byte)(39)))), ((int)(((byte)(105)))));
            this.button2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.ForeColor = System.Drawing.Color.White;
            this.button2.Location = new System.Drawing.Point(994, 90);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(111, 51);
            this.button2.TabIndex = 11;
            this.button2.Text = "POLICY";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(7)))), ((int)(((byte)(39)))), ((int)(((byte)(105)))));
            this.button3.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button3.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button3.ForeColor = System.Drawing.Color.White;
            this.button3.Location = new System.Drawing.Point(643, 90);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(122, 51);
            this.button3.TabIndex = 12;
            this.button3.Text = "ABOUT US";
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button4
            // 
            this.button4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(7)))), ((int)(((byte)(39)))), ((int)(((byte)(105)))));
            this.button4.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button4.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button4.ForeColor = System.Drawing.Color.White;
            this.button4.Location = new System.Drawing.Point(810, 91);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(139, 50);
            this.button4.TabIndex = 13;
            this.button4.Text = "CONTACT US";
            this.button4.UseVisualStyleBackColor = false;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Rockwell", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(396, 348);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(600, 114);
            this.label2.TabIndex = 14;
            this.label2.Text = resources.GetString("label2.Text");
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Elephant", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(265, 256);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(282, 27);
            this.label3.TabIndex = 15;
            this.label3.Text = "What is Health Wisely?\r\n";
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1152, 761);
            this.ControlBox = false;
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.paneltop);
            this.Controls.Add(this.panelsidebar);
            this.Controls.Add(this.btnappoinments);
            this.Controls.Add(this.btcdoctors);
            this.Name = "Main";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Load += new System.EventHandler(this.Main_Load);
            this.paneltop.ResumeLayout(false);
            this.paneltop.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picboxclose)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picboxminimize)).EndInit();
            this.panelsidebar.ResumeLayout(false);
            this.panelsidebar.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picboxlogo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel paneltop;
        private System.Windows.Forms.PictureBox picboxclose;
        private System.Windows.Forms.PictureBox picboxminimize;
        private System.Windows.Forms.Label lblstaffdashboard;
        private System.Windows.Forms.Panel panelsidebar;
        private System.Windows.Forms.Button btnappoinments;
        private System.Windows.Forms.Button btcdoctors;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.PictureBox picboxlogo;
    }
}