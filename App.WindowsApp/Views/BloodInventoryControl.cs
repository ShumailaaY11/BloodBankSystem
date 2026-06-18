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
    public partial class BloodInventoryControl : UserControl
    {
        
            private readonly BloodUnitService _svc;
            private BindingSource _bs = new BindingSource();

            public BloodInventoryControl(BloodUnitService svc)
            {
                InitializeComponent();
                _svc = svc;
                dgvUnits.DataSource = _bs;
                dgvUnits.AutoGenerateColumns = true;
                dgvUnits.ReadOnly = true;
                dgvUnits.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
                dgvUnits.AllowUserToAddRows = false;
                dgvUnits.RowHeadersVisible = false;
                dgvUnits.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

                cmbStatus.Items.AddRange(new string[]
                { "All", "Available", "Reserved", "Used", "Expired" });
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
                    data = data.Where(u =>
                        u.UnitId.ToLower().Contains(search) ||
                        u.BloodGroup.ToLower().Contains(search)
                    ).ToList();

                string status = cmbStatus.SelectedItem?.ToString();
                if (!string.IsNullOrEmpty(status) && status != "All")
                    data = data.Where(u => u.Status == status).ToList();

                _bs.DataSource = data;
                lblCount.Text = $"{data.Count} records";
                btnRefresh.Enabled = true;
            }

            private BloodUnit GetSelected()
            {
                if (_bs.Current is BloodUnit u) return u;
                MessageBox.Show("Please select a record first.",
                    "No Selection", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return null;
            }

        
            private void btnAdd_Click(object sender, EventArgs e)
            {
                var form = new BloodUnitForm(_svc, FormMode.Add, null);
                if (form.ShowDialog() == DialogResult.OK) LoadData();
            }




            private void txtSearch_TextChanged(object sender, EventArgs e)
                => LoadData();
            

            private void btnRefresh_Click(object sender, EventArgs e)
            => LoadData();


            private void cmbStatus_SelectedIndexChanged(object sender, EventArgs e)
            => LoadData();
            
            










            private void label2_Click(object sender, EventArgs e)
        {

        }

       

        private void btnDelete_Click(object sender, EventArgs e)
        {
                var selected = GetSelected();
                if (selected == null) return;

                var confirm = MessageBox.Show(
                    $"Are you sure you want to delete Unit '{selected.UnitId}'?",
                    "Confirm Delete",
                    MessageBoxButtons.YesNo,
                    MessageBoxIcon.Warning);

                if (confirm == DialogResult.Yes)
                {
                    _svc.Delete(selected.UnitId);
                    LoadData();
                }

        }





            private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnView_Click(object sender, EventArgs e)
        {
                var selected = GetSelected();
                if (selected == null) return;
                new BloodUnitForm(_svc, FormMode.View, selected).ShowDialog();

        }

            
         

            private void btnEdit_Click(object sender, EventArgs e)
        {
                var selected = GetSelected();
                if (selected == null) return;
                var form = new BloodUnitForm(_svc, FormMode.Edit, selected);
                if (form.ShowDialog() == DialogResult.OK) LoadData();
            }

        

            





            private void dgvUnits_CellContentClick(object sender, DataGridViewCellEventArgs e)
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
    









        