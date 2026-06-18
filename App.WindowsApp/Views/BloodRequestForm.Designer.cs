namespace App.WindowsApp.Views
{
    partial class BloodRequestForm
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
            this.pnlBloodRequestForm = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.txtRequestID = new System.Windows.Forms.TextBox();
            this.txtPatientName = new System.Windows.Forms.TextBox();
            this.cmbBloodList = new System.Windows.Forms.ComboBox();
            this.nudUnitsNeeded = new System.Windows.Forms.NumericUpDown();
            this.dtpRequestDate = new System.Windows.Forms.DateTimePicker();
            this.dtpRequiredBy = new System.Windows.Forms.DateTimePicker();
            this.txtHospital = new System.Windows.Forms.TextBox();
            this.cmbStatus = new System.Windows.Forms.ComboBox();
            this.label9 = new System.Windows.Forms.Label();
            this.txtNotes = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.pnlBloodRequestForm.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudUnitsNeeded)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlBloodRequestForm
            // 
            this.pnlBloodRequestForm.BackColor = System.Drawing.Color.White;
            this.pnlBloodRequestForm.Controls.Add(this.button2);
            this.pnlBloodRequestForm.Controls.Add(this.button1);
            this.pnlBloodRequestForm.Controls.Add(this.txtNotes);
            this.pnlBloodRequestForm.Controls.Add(this.label9);
            this.pnlBloodRequestForm.Controls.Add(this.cmbStatus);
            this.pnlBloodRequestForm.Controls.Add(this.txtHospital);
            this.pnlBloodRequestForm.Controls.Add(this.dtpRequiredBy);
            this.pnlBloodRequestForm.Controls.Add(this.dtpRequestDate);
            this.pnlBloodRequestForm.Controls.Add(this.nudUnitsNeeded);
            this.pnlBloodRequestForm.Controls.Add(this.cmbBloodList);
            this.pnlBloodRequestForm.Controls.Add(this.txtPatientName);
            this.pnlBloodRequestForm.Controls.Add(this.txtRequestID);
            this.pnlBloodRequestForm.Controls.Add(this.label8);
            this.pnlBloodRequestForm.Controls.Add(this.label7);
            this.pnlBloodRequestForm.Controls.Add(this.label6);
            this.pnlBloodRequestForm.Controls.Add(this.label5);
            this.pnlBloodRequestForm.Controls.Add(this.label4);
            this.pnlBloodRequestForm.Controls.Add(this.label3);
            this.pnlBloodRequestForm.Controls.Add(this.label2);
            this.pnlBloodRequestForm.Controls.Add(this.label1);
            this.pnlBloodRequestForm.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlBloodRequestForm.Location = new System.Drawing.Point(0, 0);
            this.pnlBloodRequestForm.Name = "pnlBloodRequestForm";
            this.pnlBloodRequestForm.Size = new System.Drawing.Size(390, 407);
            this.pnlBloodRequestForm.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(20, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(64, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Request ID:";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(20, 50);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(78, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Patient Name *";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(20, 90);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(73, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Blood Group *";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(20, 125);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(79, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Units Needed *";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(20, 160);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(80, 13);
            this.label5.TabIndex = 4;
            this.label5.Text = "Request Date *";
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(20, 195);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(65, 13);
            this.label6.TabIndex = 5;
            this.label6.Text = "Required By";
            this.label6.Click += new System.EventHandler(this.label6_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(20, 230);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(45, 13);
            this.label7.TabIndex = 6;
            this.label7.Text = "Hospital";
            this.label7.Click += new System.EventHandler(this.label7_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(20, 263);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(44, 13);
            this.label8.TabIndex = 7;
            this.label8.Text = "Status *";
            this.label8.Click += new System.EventHandler(this.label8_Click);
            // 
            // txtRequestID
            // 
            this.txtRequestID.Location = new System.Drawing.Point(140, 18);
            this.txtRequestID.Name = "txtRequestID";
            this.txtRequestID.ReadOnly = true;
            this.txtRequestID.Size = new System.Drawing.Size(200, 20);
            this.txtRequestID.TabIndex = 8;
            this.txtRequestID.TextChanged += new System.EventHandler(this.txtRequestID_TextChanged);
            // 
            // txtPatientName
            // 
            this.txtPatientName.Location = new System.Drawing.Point(140, 53);
            this.txtPatientName.Name = "txtPatientName";
            this.txtPatientName.Size = new System.Drawing.Size(200, 20);
            this.txtPatientName.TabIndex = 9;
            this.txtPatientName.TextChanged += new System.EventHandler(this.txtPatientName_TextChanged);
            // 
            // cmbBloodList
            // 
            this.cmbBloodList.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbBloodList.FormattingEnabled = true;
            this.cmbBloodList.Items.AddRange(new object[] {
            "A+",
            "A-",
            "B+",
            "B-",
            "AB+",
            "AB-",
            "O+",
            "O-"});
            this.cmbBloodList.Location = new System.Drawing.Point(140, 88);
            this.cmbBloodList.Name = "cmbBloodList";
            this.cmbBloodList.Size = new System.Drawing.Size(120, 21);
            this.cmbBloodList.TabIndex = 10;
            this.cmbBloodList.SelectedIndexChanged += new System.EventHandler(this.cmbBloodList_SelectedIndexChanged);
            // 
            // nudUnitsNeeded
            // 
            this.nudUnitsNeeded.Location = new System.Drawing.Point(140, 123);
            this.nudUnitsNeeded.Maximum = new decimal(new int[] {
            99,
            0,
            0,
            0});
            this.nudUnitsNeeded.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nudUnitsNeeded.Name = "nudUnitsNeeded";
            this.nudUnitsNeeded.Size = new System.Drawing.Size(80, 20);
            this.nudUnitsNeeded.TabIndex = 11;
            this.nudUnitsNeeded.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nudUnitsNeeded.ValueChanged += new System.EventHandler(this.nudUnitsNeeded_ValueChanged);
            // 
            // dtpRequestDate
            // 
            this.dtpRequestDate.Location = new System.Drawing.Point(140, 158);
            this.dtpRequestDate.Name = "dtpRequestDate";
            this.dtpRequestDate.Size = new System.Drawing.Size(180, 20);
            this.dtpRequestDate.TabIndex = 13;
            this.dtpRequestDate.ValueChanged += new System.EventHandler(this.dtpRequestDate_ValueChanged);
            // 
            // dtpRequiredBy
            // 
            this.dtpRequiredBy.Location = new System.Drawing.Point(140, 193);
            this.dtpRequiredBy.Name = "dtpRequiredBy";
            this.dtpRequiredBy.Size = new System.Drawing.Size(180, 20);
            this.dtpRequiredBy.TabIndex = 14;
            this.dtpRequiredBy.ValueChanged += new System.EventHandler(this.dtpRequiredBy_ValueChanged);
            // 
            // txtHospital
            // 
            this.txtHospital.Location = new System.Drawing.Point(140, 230);
            this.txtHospital.Name = "txtHospital";
            this.txtHospital.Size = new System.Drawing.Size(200, 20);
            this.txtHospital.TabIndex = 15;
            this.txtHospital.TextChanged += new System.EventHandler(this.txtHospital_TextChanged);
            // 
            // cmbStatus
            // 
            this.cmbStatus.FormattingEnabled = true;
            this.cmbStatus.Location = new System.Drawing.Point(140, 263);
            this.cmbStatus.Name = "cmbStatus";
            this.cmbStatus.Size = new System.Drawing.Size(130, 21);
            this.cmbStatus.TabIndex = 16;
            this.cmbStatus.SelectedIndexChanged += new System.EventHandler(this.cmbStatus_SelectedIndexChanged);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(20, 300);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(35, 13);
            this.label9.TabIndex = 17;
            this.label9.Text = "Notes";
            this.label9.Click += new System.EventHandler(this.label9_Click);
            // 
            // txtNotes
            // 
            this.txtNotes.Location = new System.Drawing.Point(140, 290);
            this.txtNotes.Multiline = true;
            this.txtNotes.Name = "txtNotes";
            this.txtNotes.Size = new System.Drawing.Size(171, 44);
            this.txtNotes.TabIndex = 18;
            this.txtNotes.TextChanged += new System.EventHandler(this.txtNotes_TextChanged);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(194, 360);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(90, 30);
            this.button1.TabIndex = 19;
            this.button1.Text = "Save";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(288, 360);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(90, 30);
            this.button2.TabIndex = 20;
            this.button2.Text = "Cancel";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // BloodRequestForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(390, 407);
            this.Controls.Add(this.pnlBloodRequestForm);
            this.Name = "BloodRequestForm";
            this.Text = "BloodRequestForm";
            this.pnlBloodRequestForm.ResumeLayout(false);
            this.pnlBloodRequestForm.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudUnitsNeeded)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlBloodRequestForm;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.ComboBox cmbStatus;
        private System.Windows.Forms.TextBox txtHospital;
        private System.Windows.Forms.DateTimePicker dtpRequiredBy;
        private System.Windows.Forms.DateTimePicker dtpRequestDate;
        private System.Windows.Forms.NumericUpDown nudUnitsNeeded;
        private System.Windows.Forms.ComboBox cmbBloodList;
        private System.Windows.Forms.TextBox txtPatientName;
        private System.Windows.Forms.TextBox txtRequestID;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox txtNotes;
        private System.Windows.Forms.Label label9;
    }
}