using App.Core.Services;
using LiveChartsCore;
using LiveChartsCore.SkiaSharpView;
using LiveChartsCore.SkiaSharpView.WinForms;
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
    public partial class DashboardControl : UserControl
    {

        private readonly DonorService _donorSvc;
        private readonly BloodUnitService _unitSvc;
        private readonly BloodRequestService _reqSvc;

        public DashboardControl()
        {
            InitializeComponent();
        }

        public DashboardControl(DonorService d, BloodUnitService u, BloodRequestService r)
        {
            InitializeComponent();
            _donorSvc = d;
            _unitSvc = u;
            _reqSvc = r;
            LoadDashboard();
        }




        private async void LoadDashboard()
        {
          
            if (_donorSvc == null) return;

           
            pnlBarChart.BackColor = System.Drawing.Color.Yellow; 

           
           
            btnRefresh.Enabled = false;

            var donors = await System.Threading.Tasks.Task.Run(() => _donorSvc.GetAll());
            var units = await System.Threading.Tasks.Task.Run(() => _unitSvc.GetAll());
            var reqs = await System.Threading.Tasks.Task.Run(() => _reqSvc.GetAll());

            lblTotalDonors.Text = donors.Count.ToString();
            lblAvailableUnits.Text = units.Count(u => u.Status == "Available").ToString();
            lblPendingRequests.Text = reqs.Count(r => r.Status == "Pending").ToString();

            // Chart 1 — Pie chart
            var groups = units
                .Where(u => u.Status == "Available")
                .GroupBy(u => u.BloodGroup)
                .Select(g => new PieSeries<double>
                {
                    Name = g.Key,
                    Values = new double[] { g.Count() }
                })
                .ToArray<ISeries>();

            var pieChart = new PieChart
            {
                Series = groups,
                Dock = DockStyle.Fill
            };

            pnlPieChart.Controls.Clear();
            pnlPieChart.Controls.Add(pieChart);




            // Chart 2 — Column chart
            var cartesianChart = new CartesianChart
            {
                Series = new ISeries[]
                {
                    new ColumnSeries<double>
                    {
                        Name   = "Requests",
                        Values = new double[]
                        {
                            reqs.Count(r => r.Status == "Pending"),
                            reqs.Count(r => r.Status == "Fulfilled"),
                            reqs.Count(r => r.Status == "Cancelled")
                        }
                    }
                },
                XAxes = new[]
                {
                    new Axis
                    {
                        Labels = new[] { "Pending", "Fulfilled", "Cancelled" }
                    }
                },
                Dock = DockStyle.Fill
            };



            pnlPieChart.Size = new Size((this.Width / 2) - 15, 250);
            pnlBarChart.Size = new Size((this.Width / 2) - 15, 250);
            pnlBarChart.Location = new Point(pnlPieChart.Right + 10, pnlPieChart.Top);



            pnlBarChart.Controls.Clear();
            pnlBarChart.Controls.Add(cartesianChart);

            btnRefresh.Enabled = true;
        }











        private void lblPendingRequests_Click(object sender, EventArgs e)
        {

        }

        private void lblAvailableUnits_Click(object sender, EventArgs e)
        {

        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }

        private void lblTotalDonors_Click(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void groupBox3_Enter(object sender, EventArgs e)
        {

        }

        private void btnRefresh_Click(object sender, EventArgs e)
            => LoadDashboard();
      

        private void DashboardControl_Load(object sender, EventArgs e)
        {

        }
    }
}

















