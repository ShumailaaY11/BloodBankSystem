using System.Windows.Forms;

namespace App.WindowsApp.Views
{
    public partial class DashboardControl : UserControl
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
            this.pnlStats = new System.Windows.Forms.Panel();
            this.btnRefresh = new System.Windows.Forms.Button();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.lblPendingRequests = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.lblAvailableUnits = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lblTotalDonors = new System.Windows.Forms.Label();
            this.pnlPieChart = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.pnlBarChart = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.pnlStats.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.pnlPieChart.SuspendLayout();
            this.pnlBarChart.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlStats
            // 
            this.pnlStats.BackColor = System.Drawing.Color.White;
            this.pnlStats.Controls.Add(this.btnRefresh);
            this.pnlStats.Controls.Add(this.groupBox3);
            this.pnlStats.Controls.Add(this.groupBox2);
            this.pnlStats.Controls.Add(this.groupBox1);
            this.pnlStats.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlStats.Location = new System.Drawing.Point(0, 0);
            this.pnlStats.Name = "pnlStats";
            this.pnlStats.Size = new System.Drawing.Size(748, 150);
            this.pnlStats.TabIndex = 0;
            // 
            // btnRefresh
            // 
            this.btnRefresh.Location = new System.Drawing.Point(576, 8);
            this.btnRefresh.Name = "btnRefresh";
            this.btnRefresh.Size = new System.Drawing.Size(150, 30);
            this.btnRefresh.TabIndex = 1;
            this.btnRefresh.Text = "Refresh Dashboard";
            this.btnRefresh.UseVisualStyleBackColor = true;
            //this.btnRefresh.Click += new System.EventHandler(this.btnRefresh_Click);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.lblPendingRequests);
            this.groupBox3.Location = new System.Drawing.Point(390, 8);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(180, 130);
            this.groupBox3.TabIndex = 2;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Pending Requests";
            //this.groupBox3.Enter += new System.EventHandler(this.groupBox3_Enter);
            // 
            // lblPendingRequests
            // 
            this.lblPendingRequests.AutoSize = true;
            this.lblPendingRequests.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPendingRequests.ForeColor = System.Drawing.Color.Firebrick;
            this.lblPendingRequests.Location = new System.Drawing.Point(70, 30);
            this.lblPendingRequests.Name = "lblPendingRequests";
            this.lblPendingRequests.Size = new System.Drawing.Size(92, 31);
            this.lblPendingRequests.TabIndex = 2;
            this.lblPendingRequests.Text = "label3";
            this.lblPendingRequests.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            //this.lblPendingRequests.Click += new System.EventHandler(this.lblPendingRequests_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.lblAvailableUnits);
            this.groupBox2.Location = new System.Drawing.Point(200, 8);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(180, 130);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Available Units";
            //this.groupBox2.Enter += new System.EventHandler(this.groupBox2_Enter);
            // 
            // lblAvailableUnits
            // 
            this.lblAvailableUnits.AutoSize = true;
            this.lblAvailableUnits.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAvailableUnits.ForeColor = System.Drawing.Color.ForestGreen;
            this.lblAvailableUnits.Location = new System.Drawing.Point(70, 30);
            this.lblAvailableUnits.Name = "lblAvailableUnits";
            this.lblAvailableUnits.Size = new System.Drawing.Size(92, 31);
            this.lblAvailableUnits.TabIndex = 1;
            this.lblAvailableUnits.Text = "label2";
            this.lblAvailableUnits.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            //this.lblAvailableUnits.Click += new System.EventHandler(this.lblAvailableUnits_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.lblTotalDonors);
            this.groupBox1.Location = new System.Drawing.Point(10, 8);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(180, 130);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Total Donors";
            //this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // lblTotalDonors
            // 
            this.lblTotalDonors.AutoSize = true;
            this.lblTotalDonors.BackColor = System.Drawing.Color.Transparent;
            this.lblTotalDonors.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotalDonors.ForeColor = System.Drawing.Color.MidnightBlue;
            this.lblTotalDonors.Location = new System.Drawing.Point(70, 30);
            this.lblTotalDonors.Name = "lblTotalDonors";
            this.lblTotalDonors.Size = new System.Drawing.Size(92, 31);
            this.lblTotalDonors.TabIndex = 0;
            this.lblTotalDonors.Text = "label1";
            this.lblTotalDonors.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            //this.lblTotalDonors.Click += new System.EventHandler(this.lblTotalDonors_Click);
            // 
            // pnlPieChart
            // 
            this.pnlPieChart.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlPieChart.Controls.Add(this.label1);
            this.pnlPieChart.Location = new System.Drawing.Point(10, 180);
            this.pnlPieChart.Name = "pnlPieChart";
            this.pnlPieChart.Size = new System.Drawing.Size(360, 220);
            this.pnlPieChart.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(5, 5);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(127, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Inventory by Blood Group";
            // 
            // pnlBarChart
            // 
            this.pnlBarChart.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlBarChart.Controls.Add(this.label2);
            this.pnlBarChart.Location = new System.Drawing.Point(376, 180);
            this.pnlBarChart.Name = "pnlBarChart";
            this.pnlBarChart.Size = new System.Drawing.Size(360, 220);
            this.pnlBarChart.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(5, 5);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(99, 13);
            this.label2.TabIndex = 0;
            this.label2.Text = "Requests by Status";
            // 
            // DashboardControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.pnlBarChart);
            this.Controls.Add(this.pnlPieChart);
            this.Controls.Add(this.pnlStats);
            this.Name = "DashboardControl";
            this.Size = new System.Drawing.Size(748, 428);
            //this.Load += new System.EventHandler(this.DashboardControl_Load);
            this.pnlStats.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.pnlPieChart.ResumeLayout(false);
            this.pnlPieChart.PerformLayout();
            this.pnlBarChart.ResumeLayout(false);
            this.pnlBarChart.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private Panel pnlStats;
        private GroupBox groupBox3;
        private GroupBox groupBox2;
        private GroupBox groupBox1;
        private Label lblPendingRequests;
        private Label lblAvailableUnits;
        private Label lblTotalDonors;
        private Button btnRefresh;
        private Panel pnlPieChart;
        private Panel pnlBarChart;
        private Label label1;
        private Label label2;
    }
}
