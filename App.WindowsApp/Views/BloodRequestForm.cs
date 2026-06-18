using App.Core.Enums;
using App.Core.Models;
using App.Core.Services;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;





namespace App.WindowsApp.Views
{


    public partial class BloodRequestForm : Form
    {
        private readonly BloodRequestService _svc;
        private readonly FormMode _mode;

        public BloodRequestForm()
        {
            InitializeComponent();
        }

        public BloodRequestForm(BloodRequestService svc, FormMode mode, BloodRequest existing)
        {
            InitializeComponent();
            _svc = svc;
            _mode = mode;

            cmbBloodList.Items.AddRange(new string[]
            { "A+", "A-", "B+", "B-", "AB+", "AB-", "O+", "O-" });

            cmbStatus.Items.AddRange(new string[]
            { "Pending", "Fulfilled", "Cancelled" });

            if (mode == FormMode.Add)
            {
                Text = "Add Blood Request";
                txtRequestID.Text = "REQ-" + Guid.NewGuid().ToString().Substring(0, 8).ToUpper();
                txtRequestID.ReadOnly = true;
                cmbStatus.SelectedItem = "Pending";
                dtpRequestDate.Value = DateTime.Now;
                nudUnitsNeeded.Value = 1;
            }
            else
            {
                Text = mode == FormMode.Edit ? "Edit Blood Request" : "View Blood Request";
                PopulateFields(existing);
                if (mode == FormMode.View) SetReadOnly();
            }
        }


        private void PopulateFields(BloodRequest r)
        {
            txtRequestID.Text = r.RequestId;
            txtRequestID.ReadOnly = true;
            txtPatientName.Text = r.PatientName;
            cmbBloodList.SelectedItem = r.BloodGroup;
            nudUnitsNeeded.Value = r.UnitsNeeded;
            dtpRequestDate.Value = r.RequestDate;
            if (r.RequiredBy.HasValue) dtpRequiredBy.Value = r.RequiredBy.Value;
            txtHospital.Text = r.Hospital;
            cmbStatus.SelectedItem = r.Status;
            txtNotes.Text = r.Notes;
        }


        private void SetReadOnly()
        {
            txtPatientName.ReadOnly = true;
            txtHospital.ReadOnly = true;
            txtNotes.ReadOnly = true;
            cmbBloodList.Enabled = false;
            nudUnitsNeeded.Enabled = false;
            dtpRequestDate.Enabled = false;
            dtpRequiredBy.Enabled = false;
            cmbStatus.Enabled = false;
            button1.Visible = false; // Save button
        }


      


        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void txtRequestID_TextChanged(object sender, EventArgs e)
        {

        }


        private void label2_Click(object sender, EventArgs e)
        {

        }


        private void txtPatientName_TextChanged(object sender, EventArgs e)
        {

        }
       


        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void cmbBloodList_SelectedIndexChanged(object sender, EventArgs e)
        {

        }






        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void nudUnitsNeeded_ValueChanged(object sender, EventArgs e)
        {

        }





      


        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void dtpRequestDate_ValueChanged(object sender, EventArgs e)
        {

        }



        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void dtpRequiredBy_ValueChanged(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void txtHospital_TextChanged(object sender, EventArgs e)
        {

        }






        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void cmbStatus_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void txtNotes_TextChanged(object sender, EventArgs e)
        {

        }




       










       

        

        

        

       

        

        

        

      

        private void button1_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtPatientName.Text))
            {
                MessageBox.Show("Patient Name is required.", "Validation",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (cmbBloodList.SelectedItem == null)
            {
                MessageBox.Show("Blood Group is required.", "Validation",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            var req = new BloodRequest
            {
                RequestId = txtRequestID.Text,
                PatientName = txtPatientName.Text.Trim(),
                BloodGroup = cmbBloodList.SelectedItem.ToString(),
                UnitsNeeded = (int)nudUnitsNeeded.Value,
                RequestDate = dtpRequestDate.Value.Date,
                RequiredBy = dtpRequiredBy.Value.Date,
                Hospital = txtHospital.Text.Trim(),
                Status = cmbStatus.SelectedItem?.ToString() ?? "Pending",
                Notes = txtNotes.Text.Trim()
            };

            if (_mode == FormMode.Add)
                _svc.Add(req);
            else
                _svc.Update(req);

            DialogResult = DialogResult.OK;
            Close();
        }


        

        private void button2_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
            Close();
        }

        




    }
}















