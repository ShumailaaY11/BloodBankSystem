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
    public partial class BloodRequestsControl : UserControl
    {
        private readonly BloodRequestService _svc;
        private BindingSource _bs = new BindingSource();

        public BloodRequestsControl(BloodRequestService svc)
        {
            InitializeComponent();
            _svc = svc;
            dgvRequests.DataSource = _bs;
            dgvRequests.AutoGenerateColumns = true;
            dgvRequests.ReadOnly = true;
            dgvRequests.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvRequests.AllowUserToAddRows = false;
            dgvRequests.RowHeadersVisible = false;
            dgvRequests.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

            cmbStatus.Items.AddRange(new string[]
            { "All", "Pending", "Fulfilled", "Cancelled" });
            cmbStatus.SelectedIndex = 0;

            LoadData();
        }

        private async void LoadData()
        {
            btnRefresh.Enabled = false;
            lblCount.Text = "Loading...";

            var data = await System.Threading.Tasks.Task.Run(() => _svc.GetAll());

            string search = txtSearch.Text.Trim().ToLower();
            if (!string.IsNullOrEmpty(search))
                data = data.Where(r =>
                    r.PatientName.ToLower().Contains(search) ||
                    (r.Hospital != null && r.Hospital.ToLower().Contains(search))
                ).ToList();

            string status = cmbStatus.SelectedItem?.ToString();
            if (!string.IsNullOrEmpty(status) && status != "All")
                data = data.Where(r => r.Status == status).ToList();

            _bs.DataSource = data;
            lblCount.Text = $"{data.Count} records";
            btnRefresh.Enabled = true;
        }

        private BloodRequest GetSelected()
        {
            if (_bs.Current is BloodRequest r) return r;
            MessageBox.Show("Please select a record first.",
                "No Selection", MessageBoxButtons.OK, MessageBoxIcon.Information);
            return null;
        }


        private void btnAdd_Click(object sender, EventArgs e)
        {
            var form = new BloodRequestForm(_svc, FormMode.Add, null);
            if (form.ShowDialog() == DialogResult.OK) LoadData();
        }

       


        private void pnlToolbar_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            var selected = GetSelected();
            if (selected == null) return;
            var form = new BloodRequestForm(_svc, FormMode.Edit, selected);
            if (form.ShowDialog() == DialogResult.OK) LoadData();
        }

       






        private void btnView_Click(object sender, EventArgs e)
        {
            var selected = GetSelected();
            if (selected == null) return;
            new BloodRequestForm(_svc, FormMode.View, selected).ShowDialog();
        }



        

        private void btnDelete_Click(object sender, EventArgs e)
        {
            var selected = GetSelected();
            if (selected == null) return;

            var confirm = MessageBox.Show(
                $"Delete request for '{selected.PatientName}'?",
                "Confirm Delete",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Warning);

            if (confirm == DialogResult.Yes)
            {
                _svc.Delete(selected.RequestId);
                LoadData();
            }
        }



        

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void cmbStatus_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void BloodRequestsControl_Load(object sender, EventArgs e)
        {

        }

        private void dgvRequests_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnRefresh_Click(object sender, EventArgs e)
                   => LoadData();


        //private void txtSearch_TextChanged(object sender, EventArgs e)
        //   => LoadData();

        //private void cmbStatus_SelectedIndexChanged(object sender, EventArgs e)
       //     => LoadData();

    }
}









