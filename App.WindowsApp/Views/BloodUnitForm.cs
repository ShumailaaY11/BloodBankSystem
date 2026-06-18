using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


using App.Core.Enums;
using App.Core.Models;
using App.Core.Services;



namespace App.WindowsApp.Views
{
    public partial class BloodUnitForm : Form
    {
        private readonly BloodUnitService _svc;
        private readonly FormMode _mode;

        public BloodUnitForm()
        {
            InitializeComponent();
        }




        public BloodUnitForm(BloodUnitService svc, FormMode mode, BloodUnit existing)
        {
            InitializeComponent();
            _svc = svc;
            _mode = mode;

            cmbBloodGroup.Items.AddRange(new string[]
            { "A+", "A-", "B+", "B-", "AB+", "AB-", "O+", "O-" });

            cmbStatus.Items.AddRange(new string[]
            { "Available", "Reserved", "Used", "Expired" });

            if (mode == FormMode.Add)
            {
                Text = "Add Blood Unit";
                txtUnitId.Text = "BU-" + Guid.NewGuid().ToString().Substring(0, 8).ToUpper();
                txtUnitId.ReadOnly = true;
                cmbStatus.SelectedItem = "Available";
                nudQuantity.Value = 1;
            }
            else
            {
                Text = mode == FormMode.Edit ? "Edit Blood Unit" : "View Blood Unit";
                PopulateFields(existing);
                if (mode == FormMode.View) SetReadOnly();
            }
        }

        private void PopulateFields(BloodUnit u)
        {
            txtUnitId.Text = u.UnitId;
            txtUnitId.ReadOnly = true;
            cmbBloodGroup.SelectedItem = u.BloodGroup;
            dtpCollected.Value = u.CollectedOn;
            dtpExpiry.Value = u.ExpiryDate;
            txtDonorId.Text = u.DonorId;
            cmbStatus.SelectedItem = u.Status;
            nudQuantity.Value = u.Quantity;
        }

        private void SetReadOnly()
        {
            txtDonorId.ReadOnly = true;
            cmbBloodGroup.Enabled = false;
            dtpCollected.Enabled = false;
            dtpExpiry.Enabled = false;
            cmbStatus.Enabled = false;
            nudQuantity.Enabled = false;
            btnSave.Visible = false;
        }










        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void pnlBloodUnit_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void pnlStatus_Paint(object sender, System.Windows.Forms.PaintEventArgs e) { }
        private void lblCount_Click(object sender, EventArgs e) { }
        private void dgvUnits_CellContentClick(object sender, System.Windows.Forms.DataGridViewCellEventArgs e) { }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (cmbBloodGroup.SelectedItem == null)
            {
                MessageBox.Show("Blood Group is required.", "Validation",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (dtpExpiry.Value.Date <= dtpCollected.Value.Date)
            {
                MessageBox.Show("Expiry date must be after collection date.", "Validation",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            var unit = new BloodUnit
            {
                UnitId = txtUnitId.Text,
                BloodGroup = cmbBloodGroup.SelectedItem.ToString(),
                CollectedOn = dtpCollected.Value.Date,
                ExpiryDate = dtpExpiry.Value.Date,
                DonorId = string.IsNullOrWhiteSpace(txtDonorId.Text) ? null : txtDonorId.Text.Trim(),
                Status = cmbStatus.SelectedItem?.ToString() ?? "Available",
                Quantity = (int)nudQuantity.Value
            };

            if (_mode == FormMode.Add)
                _svc.Add(unit);
            else
                _svc.Update(unit);

            DialogResult = DialogResult.OK;
            Close();
        }





        

        private void btnCancel_Click_1(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
            Close();

        }
    }



}








        

      