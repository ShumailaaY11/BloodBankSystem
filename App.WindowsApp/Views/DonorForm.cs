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
    public partial class DonorForm : Form
    {
        private readonly DonorService _svc;
        private readonly FormMode _mode;
        private readonly Donor _existing;

        public DonorForm()
        {
            InitializeComponent();
        }

        public DonorForm(DonorService svc, FormMode mode, Donor existing)
        {
            InitializeComponent();
            _svc = svc;
            _mode = mode;
            _existing = existing;

            cmbBloodGroup.Items.AddRange(new string[]
            { "A+", "A-", "B+", "B-", "AB+", "AB-", "O+", "O-" });
            cmbBloodGroup.SelectedIndex = 0;
            if (mode == FormMode.Add)
            {
                Text = "Add Donor";
                txtDonorId.Text = "D-" + Guid.NewGuid().ToString().Substring(0, 8).ToUpper();
                txtDonorId.ReadOnly = true;
                chkActive.Checked = true;
                dtpLastDonated.Enabled = false;
            }
            else
            {
                Text = mode == FormMode.Edit ? "Edit Donor" : "View Donor";
                PopulateFields(existing);
                if (mode == FormMode.View) SetReadOnly();
            }
        }

        private void PopulateFields(Donor d)
        {
            txtDonorId.Text = d.DonorId;
            txtDonorId.ReadOnly = true;
            txtFullName.Text = d.FullName;
            cmbBloodGroup.SelectedItem = d.BloodGroup;
            dtpDOB.Value = d.DateOfBirth;
            txtPhone.Text = d.Phone;
            txtEmail.Text = d.Email;
            txtAddress.Text = d.Address;
            chkActive.Checked = d.IsActive;

            if (d.LastDonated.HasValue)
            {
                chkHasLastDonated.Checked = true;
                dtpLastDonated.Value = d.LastDonated.Value;
                dtpLastDonated.Enabled = true;
            }
            else
            {
                dtpLastDonated.Enabled = false;
            }
        }

        private void SetReadOnly()
        {
            txtFullName.ReadOnly = true;
            txtPhone.ReadOnly = true;
            txtEmail.ReadOnly = true;
            txtAddress.ReadOnly = true;
            cmbBloodGroup.Enabled = false;
            dtpDOB.Enabled = false;
            chkHasLastDonated.Enabled = false;
            dtpLastDonated.Enabled = false;
            chkActive.Enabled = false;
            btnSave.Visible = false;
        }

        

        private void chkHasLastDonated_CheckedChanged(object sender, EventArgs e)
        {
            dtpLastDonated.Enabled = chkHasLastDonated.Checked;
        }




        private void btnCancel_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
            Close();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtFullName.Text))
            {
                MessageBox.Show("Full Name is required.", "Validation",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (cmbBloodGroup.SelectedItem == null)
            {
                MessageBox.Show("Blood Group is required.", "Validation",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            var donor = new Donor
            {
                DonorId = txtDonorId.Text,
                FullName = txtFullName.Text.Trim(),
                BloodGroup = cmbBloodGroup.SelectedItem.ToString(),
                DateOfBirth = dtpDOB.Value.Date,
                Phone = txtPhone.Text.Trim(),
                Email = txtEmail.Text.Trim(),
                Address = txtAddress.Text.Trim(),
                LastDonated = chkHasLastDonated.Checked ? dtpLastDonated.Value.Date : (DateTime?)null,
                IsActive = chkActive.Checked
            };

            if (_mode == FormMode.Add)
                _svc.Add(donor);
            else
                _svc.Update(donor);

            DialogResult = DialogResult.OK;
            Close();

        }
        

       






       


        private void txtDonorId_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtFullName_TextChanged(object sender, EventArgs e)
        {

        }

        private void cmbBloodGroup_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void dtpDOB_ValueChanged(object sender, EventArgs e)
        {

        }

        private void txtPhone_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtEmail_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtAddress_TextChanged(object sender, EventArgs e)
        {

        }

        

        private void dtpLastDonated_ValueChanged(object sender, EventArgs e)
        {

        }

        private void chkActive_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void btnSave_Click_1(object sender, EventArgs e)
        {

        }
    }
}














