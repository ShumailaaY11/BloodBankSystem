using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using App.Core.Models;
using App.Core.Services;
using App.Core.Enums;


namespace App.WindowsApp.Views
{
    public partial class DonorsControl : UserControl
    {
        private readonly DonorService _svc;
        private BindingSource _bs = new BindingSource();

        public DonorsControl(DonorService svc)
        {
            InitializeComponent();
            _svc = svc;
            dgvDonors.DataSource = _bs;
            dgvDonors.AutoGenerateColumns = true;
            dgvDonors.ReadOnly = true;
            dgvDonors.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvDonors.AllowUserToAddRows = false;
            dgvDonors.RowHeadersVisible = false;
            dgvDonors.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

            // Blood group filter items
            cmbBloodGroup.Items.AddRange(new string[]
            { "All", "A+", "A-", "B+", "B-", "AB+", "AB-", "O+", "O-" });
            cmbBloodGroup.SelectedIndex = 0;

            LoadData();
        }

        private async void LoadData()
        {
            btnRefresh.Enabled = false;
            lblCount.Text = "Loading...";

            var data = await _svc.GetAllAsync();

            // Search filter
            string search = txtSearch.Text.Trim().ToLower();
            if (!string.IsNullOrEmpty(search))
                data = data.Where(d =>
                    (d.FullName != null && d.FullName.ToLower().Contains(search)) ||
                    (d.Phone != null && d.Phone.Contains(search))
                ).ToList();

            // Blood group filter
            string bg = cmbBloodGroup.SelectedItem?.ToString();
            if (!string.IsNullOrEmpty(bg) && bg != "All")
                data = data.Where(d => d.BloodGroup == bg).ToList();

            _bs.DataSource = data;
            lblCount.Text = $"{data.Count} records";
            btnRefresh.Enabled = true;
        }

        private Donor GetSelected()
        {
            if (_bs.Current is Donor d) return d;
            MessageBox.Show("Please select a record first.",
                "No Selection", MessageBoxButtons.OK, MessageBoxIcon.Information);
            return null;
        }

        


        private void btnAdd_Click(object sender, EventArgs e)
        {
            var form = new DonorForm(_svc, FormMode.Add, null);
            if (form.ShowDialog() == DialogResult.OK) LoadData();

        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            var selected = GetSelected();
            if (selected == null) return;
            var form = new DonorForm(_svc, FormMode.Edit, selected);
            if (form.ShowDialog() == DialogResult.OK) LoadData();
        }

       



        private void btnView_Click(object sender, EventArgs e)
        {
            var selected = GetSelected();
            if (selected == null) return;
            new DonorForm(_svc, FormMode.View, selected).ShowDialog();

        }




        private void btnDelete_Click(object sender, EventArgs e)
        {
            var selected = GetSelected();
            if (selected == null) return;

            var confirm = MessageBox.Show(
                $"Are you sure you want to delete '{selected.FullName}'?",
                "Confirm Delete",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Warning);

            if (confirm == DialogResult.Yes)
            {
                _svc.Delete(selected.DonorId);
                LoadData();
            }

        }
      

        private void btnRefresh_Click(object sender, EventArgs e)
            => LoadData();

        private void txtSearch_TextChanged(object sender, EventArgs e)
            => LoadData();

        private void cmbBloodGroup_SelectedIndexChanged(object sender, EventArgs e)
            => LoadData();

        

        

        

        

        private void txtSearch_TextChanged_1(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void cmbBloodGroup_SelectedIndexChanged_1(object sender, EventArgs e)
        {

        }

        private void dgvDonors_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void pnlStatus_Paint(object sender, PaintEventArgs e)
        {

        }

        private void lblCount_Click(object sender, EventArgs e)
        {

        }
    }
}





















