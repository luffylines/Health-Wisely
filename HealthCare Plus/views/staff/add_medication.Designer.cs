namespace HealthCare_Plus.views.staff
{
    partial class add_medication
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
            this.combopatient = new System.Windows.Forms.ComboBox();
            this.date = new System.Windows.Forms.DateTimePicker();
            this.rtextdescription = new System.Windows.Forms.RichTextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtpname = new System.Windows.Forms.RichTextBox();
            this.btnadd = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lbladmindashboard = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label6 = new System.Windows.Forms.Label();
            this.txtcost = new System.Windows.Forms.RichTextBox();
            this.txtmedication = new System.Windows.Forms.RichTextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // combopatient
            // 
            this.combopatient.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.combopatient.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.combopatient.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.combopatient.FormattingEnabled = true;
            this.combopatient.Location = new System.Drawing.Point(22, 36);
            this.combopatient.Name = "combopatient";
            this.combopatient.Size = new System.Drawing.Size(288, 34);
            this.combopatient.TabIndex = 25;
            // 
            // date
            // 
            this.date.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.date.Location = new System.Drawing.Point(372, 107);
            this.date.MaxDate = new System.DateTime(2025, 8, 20, 0, 0, 0, 0);
            this.date.MinDate = new System.DateTime(2000, 1, 1, 0, 0, 0, 0);
            this.date.Name = "date";
            this.date.Size = new System.Drawing.Size(304, 33);
            this.date.TabIndex = 24;
            this.date.Value = new System.DateTime(2024, 10, 18, 0, 0, 0, 0);
            // 
            // rtextdescription
            // 
            this.rtextdescription.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.rtextdescription.Font = new System.Drawing.Font("Candara Light", 15.75F);
            this.rtextdescription.ForeColor = System.Drawing.Color.Black;
            this.rtextdescription.Location = new System.Drawing.Point(22, 275);
            this.rtextdescription.Name = "rtextdescription";
            this.rtextdescription.Size = new System.Drawing.Size(647, 96);
            this.rtextdescription.TabIndex = 23;
            this.rtextdescription.Text = "";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F);
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(18, 229);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(104, 24);
            this.label1.TabIndex = 22;
            this.label1.Text = "Description";
            // 
            // txtpname
            // 
            this.txtpname.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtpname.Font = new System.Drawing.Font("Candara Light", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtpname.Location = new System.Drawing.Point(22, 125);
            this.txtpname.Multiline = false;
            this.txtpname.Name = "txtpname";
            this.txtpname.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.None;
            this.txtpname.Size = new System.Drawing.Size(288, 33);
            this.txtpname.TabIndex = 19;
            this.txtpname.Text = "";
            // 
            // btnadd
            // 
            this.btnadd.BackColor = System.Drawing.Color.Teal;
            this.btnadd.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnadd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnadd.Font = new System.Drawing.Font("Nirmala UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnadd.ForeColor = System.Drawing.Color.White;
            this.btnadd.Location = new System.Drawing.Point(381, 401);
            this.btnadd.Name = "btnadd";
            this.btnadd.Size = new System.Drawing.Size(288, 46);
            this.btnadd.TabIndex = 16;
            this.btnadd.Text = "Add";
            this.btnadd.UseVisualStyleBackColor = false;
            this.btnadd.Click += new System.EventHandler(this.btnadd_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F);
            this.label5.ForeColor = System.Drawing.Color.Black;
            this.label5.Location = new System.Drawing.Point(349, 160);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(47, 24);
            this.label5.TabIndex = 12;
            this.label5.Text = "Cost";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F);
            this.label4.ForeColor = System.Drawing.Color.Black;
            this.label4.Location = new System.Drawing.Point(349, 80);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(48, 24);
            this.label4.TabIndex = 11;
            this.label4.Text = "Date";
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
            this.lbladmindashboard.Size = new System.Drawing.Size(195, 33);
            this.lbladmindashboard.TabIndex = 32;
            this.lbladmindashboard.Text = "Add Medication";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(3, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(66, 24);
            this.label2.TabIndex = 9;
            this.label2.Text = "Patient";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.panel2.Controls.Add(this.label6);
            this.panel2.Controls.Add(this.txtcost);
            this.panel2.Controls.Add(this.txtmedication);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Controls.Add(this.combopatient);
            this.panel2.Controls.Add(this.date);
            this.panel2.Controls.Add(this.rtextdescription);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Controls.Add(this.txtpname);
            this.panel2.Controls.Add(this.btnadd);
            this.panel2.Controls.Add(this.label5);
            this.panel2.Controls.Add(this.label4);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Location = new System.Drawing.Point(55, 65);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(702, 468);
            this.panel2.TabIndex = 33;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.Black;
            this.label6.Location = new System.Drawing.Point(3, 98);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(122, 24);
            this.label6.TabIndex = 32;
            this.label6.Text = "Patient Name";
            // 
            // txtcost
            // 
            this.txtcost.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtcost.Font = new System.Drawing.Font("Candara Light", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtcost.Location = new System.Drawing.Point(372, 187);
            this.txtcost.Multiline = false;
            this.txtcost.Name = "txtcost";
            this.txtcost.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.None;
            this.txtcost.Size = new System.Drawing.Size(304, 33);
            this.txtcost.TabIndex = 31;
            this.txtcost.Text = "";
            // 
            // txtmedication
            // 
            this.txtmedication.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtmedication.Font = new System.Drawing.Font("Candara Light", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtmedication.Location = new System.Drawing.Point(372, 39);
            this.txtmedication.Multiline = false;
            this.txtmedication.Name = "txtmedication";
            this.txtmedication.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.None;
            this.txtmedication.Size = new System.Drawing.Size(304, 33);
            this.txtmedication.TabIndex = 30;
            this.txtmedication.Text = "";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F);
            this.label3.ForeColor = System.Drawing.Color.Black;
            this.label3.Location = new System.Drawing.Point(331, 9);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(102, 24);
            this.label3.TabIndex = 29;
            this.label3.Text = "Medication";
            // 
            // add_medication
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel2);
            this.Name = "add_medication";
            this.Size = new System.Drawing.Size(900, 742);
            this.Load += new System.EventHandler(this.add_medication_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ComboBox combopatient;
        private System.Windows.Forms.DateTimePicker date;
        private System.Windows.Forms.RichTextBox rtextdescription;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.RichTextBox txtpname;
        private System.Windows.Forms.Button btnadd;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lbladmindashboard;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.RichTextBox txtmedication;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.RichTextBox txtcost;
    }
}
