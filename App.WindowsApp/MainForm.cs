using App.Core.Services;
using System;
using System.Drawing;
using System.Windows.Forms;

namespace App.WindowsApp
{

    public partial class MainForm : Form
    {
        private readonly DonorService _donorSvc = new DonorService();
        private readonly BloodUnitService _unitSvc = new BloodUnitService();
        private readonly BloodRequestService _reqSvc = new BloodRequestService();

        public MainForm()
        {
            InitializeComponent();
            SetActiveButton(btnDashboard);
            LoadView(new Views.DashboardControl(_donorSvc, _unitSvc, _reqSvc));
        }
        

        


        private void LoadView(UserControl view)
        {
            pnlContent.Controls.Clear();
            view.Dock = DockStyle.Fill;
            pnlContent.Controls.Add(view);
            statusLabel.Text = $"{view.GetType().Name} | {DateTime.Now:HH:mm}";
        }

        private void SetActiveButton(Button active)
        {
            foreach (Control c in pnlSidebar.Controls)
            {
                if (c is Button b)
                {
                    b.BackColor = Color.WhiteSmoke;
                    b.ForeColor = Color.Black;
                }
            }
            active.BackColor = Color.FromArgb(200, 220, 240);
            active.ForeColor = Color.Black;
        }




        private void btnDashboard_Click(object sender, EventArgs e)
        {
            SetActiveButton(btnDashboard);
            LoadView(new Views.DashboardControl(_donorSvc, _unitSvc, _reqSvc)); 
            
        }


        

        private void btnDonors_Click(object sender, EventArgs e)
        {
            SetActiveButton(btnDonors);
            LoadView(new Views.DonorsControl(_donorSvc)); 
            
            
        }


        

        private void btnInventory_Click(object sender, EventArgs e)
        {
          

            SetActiveButton(btnInventory);
            LoadView(new Views.BloodInventoryControl(_unitSvc));
        }


        

        private void btnRequests_Click(object sender, EventArgs e)
        {
            SetActiveButton(btnRequests);
            LoadView(new Views.BloodRequestsControl(_reqSvc));
        }

        
        



        public void SetStatus(string message)
        {
            statusLabel.Text = $"{message} | {DateTime.Now:HH:mm}";
        }


    }

}
    