namespace GymManagementSystem
{
    partial class UC_Dashboard
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
            this.pnlHeader = new System.Windows.Forms.Panel();
            this.lblDashTitle = new System.Windows.Forms.Label();
            this.cardTotalMembers = new System.Windows.Forms.Panel();
            this.lblMembersValue = new System.Windows.Forms.Label();
            this.lblTotalMembersTitle = new System.Windows.Forms.Label();
            this.pnlCards = new System.Windows.Forms.Panel();
            this.cardMachines = new System.Windows.Forms.Panel();
            this.lblMachinesValue = new System.Windows.Forms.Label();
            this.lblMachineTitle = new System.Windows.Forms.Label();
            this.cardRevenue = new System.Windows.Forms.Panel();
            this.lblMonthlyRevenueTitle = new System.Windows.Forms.Label();
            this.lblRevenueValue = new System.Windows.Forms.Label();
            this.cardActive = new System.Windows.Forms.Panel();
            this.lblActiveValue = new System.Windows.Forms.Label();
            this.lblActiveMembershipsTitle = new System.Windows.Forms.Label();
            this.pnlBottom = new System.Windows.Forms.Panel();
            this.lblExpiringValue = new System.Windows.Forms.Panel();
            this.dgvExpiringSoon = new System.Windows.Forms.DataGridView();
            this.lblExpiring = new System.Windows.Forms.Label();
            this.pnlRecentPayments = new System.Windows.Forms.Panel();
            this.dgvRecentPayments = new System.Windows.Forms.DataGridView();
            this.lblRecentPayments = new System.Windows.Forms.Label();
            this.pnlHeader.SuspendLayout();
            this.cardTotalMembers.SuspendLayout();
            this.pnlCards.SuspendLayout();
            this.cardMachines.SuspendLayout();
            this.cardRevenue.SuspendLayout();
            this.cardActive.SuspendLayout();
            this.pnlBottom.SuspendLayout();
            this.lblExpiringValue.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvExpiringSoon)).BeginInit();
            this.pnlRecentPayments.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvRecentPayments)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlHeader
            // 
            this.pnlHeader.Controls.Add(this.lblDashTitle);
            this.pnlHeader.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlHeader.Location = new System.Drawing.Point(0, 0);
            this.pnlHeader.Name = "pnlHeader";
            this.pnlHeader.Size = new System.Drawing.Size(1650, 70);
            this.pnlHeader.TabIndex = 0;
            // 
            // lblDashTitle
            // 
            this.lblDashTitle.AutoSize = true;
            this.lblDashTitle.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDashTitle.Location = new System.Drawing.Point(20, 20);
            this.lblDashTitle.Name = "lblDashTitle";
            this.lblDashTitle.Size = new System.Drawing.Size(119, 30);
            this.lblDashTitle.TabIndex = 0;
            this.lblDashTitle.Text = "Dashboard";
            // 
            // cardTotalMembers
            // 
            this.cardTotalMembers.BackColor = System.Drawing.Color.White;
            this.cardTotalMembers.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.cardTotalMembers.Controls.Add(this.lblMembersValue);
            this.cardTotalMembers.Controls.Add(this.lblTotalMembersTitle);
            this.cardTotalMembers.Location = new System.Drawing.Point(166, 23);
            this.cardTotalMembers.Name = "cardTotalMembers";
            this.cardTotalMembers.Size = new System.Drawing.Size(240, 95);
            this.cardTotalMembers.TabIndex = 3;
            // 
            // lblMembersValue
            // 
            this.lblMembersValue.AutoSize = true;
            this.lblMembersValue.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMembersValue.Location = new System.Drawing.Point(103, 53);
            this.lblMembersValue.Name = "lblMembersValue";
            this.lblMembersValue.Size = new System.Drawing.Size(14, 15);
            this.lblMembersValue.TabIndex = 1;
            this.lblMembersValue.Text = "0";
            // 
            // lblTotalMembersTitle
            // 
            this.lblTotalMembersTitle.AutoSize = true;
            this.lblTotalMembersTitle.BackColor = System.Drawing.Color.Transparent;
            this.lblTotalMembersTitle.ForeColor = System.Drawing.Color.DimGray;
            this.lblTotalMembersTitle.Location = new System.Drawing.Point(67, 18);
            this.lblTotalMembersTitle.Name = "lblTotalMembersTitle";
            this.lblTotalMembersTitle.Size = new System.Drawing.Size(86, 15);
            this.lblTotalMembersTitle.TabIndex = 0;
            this.lblTotalMembersTitle.Text = "Total Members";
            // 
            // pnlCards
            // 
            this.pnlCards.Controls.Add(this.cardMachines);
            this.pnlCards.Controls.Add(this.cardRevenue);
            this.pnlCards.Controls.Add(this.cardActive);
            this.pnlCards.Controls.Add(this.cardTotalMembers);
            this.pnlCards.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlCards.Location = new System.Drawing.Point(0, 70);
            this.pnlCards.Name = "pnlCards";
            this.pnlCards.Size = new System.Drawing.Size(1650, 140);
            this.pnlCards.TabIndex = 2;
            // 
            // cardMachines
            // 
            this.cardMachines.BackColor = System.Drawing.Color.White;
            this.cardMachines.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.cardMachines.Controls.Add(this.lblMachinesValue);
            this.cardMachines.Controls.Add(this.lblMachineTitle);
            this.cardMachines.Location = new System.Drawing.Point(1279, 23);
            this.cardMachines.Name = "cardMachines";
            this.cardMachines.Size = new System.Drawing.Size(240, 95);
            this.cardMachines.TabIndex = 6;
            // 
            // lblMachinesValue
            // 
            this.lblMachinesValue.AutoSize = true;
            this.lblMachinesValue.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMachinesValue.Location = new System.Drawing.Point(107, 53);
            this.lblMachinesValue.Name = "lblMachinesValue";
            this.lblMachinesValue.Size = new System.Drawing.Size(14, 15);
            this.lblMachinesValue.TabIndex = 5;
            this.lblMachinesValue.Text = "0";
            // 
            // lblMachineTitle
            // 
            this.lblMachineTitle.AutoSize = true;
            this.lblMachineTitle.BackColor = System.Drawing.Color.Transparent;
            this.lblMachineTitle.Location = new System.Drawing.Point(88, 18);
            this.lblMachineTitle.Name = "lblMachineTitle";
            this.lblMachineTitle.Size = new System.Drawing.Size(58, 15);
            this.lblMachineTitle.TabIndex = 4;
            this.lblMachineTitle.Text = "Machines";
            // 
            // cardRevenue
            // 
            this.cardRevenue.BackColor = System.Drawing.Color.White;
            this.cardRevenue.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.cardRevenue.Controls.Add(this.lblMonthlyRevenueTitle);
            this.cardRevenue.Controls.Add(this.lblRevenueValue);
            this.cardRevenue.Location = new System.Drawing.Point(885, 23);
            this.cardRevenue.Name = "cardRevenue";
            this.cardRevenue.Size = new System.Drawing.Size(240, 95);
            this.cardRevenue.TabIndex = 5;
            // 
            // lblMonthlyRevenueTitle
            // 
            this.lblMonthlyRevenueTitle.AutoSize = true;
            this.lblMonthlyRevenueTitle.BackColor = System.Drawing.Color.Transparent;
            this.lblMonthlyRevenueTitle.Location = new System.Drawing.Point(52, 18);
            this.lblMonthlyRevenueTitle.Name = "lblMonthlyRevenueTitle";
            this.lblMonthlyRevenueTitle.Size = new System.Drawing.Size(124, 15);
            this.lblMonthlyRevenueTitle.TabIndex = 6;
            this.lblMonthlyRevenueTitle.Text = "Revenue (This Month)";
            // 
            // lblRevenueValue
            // 
            this.lblRevenueValue.AutoSize = true;
            this.lblRevenueValue.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRevenueValue.Location = new System.Drawing.Point(108, 53);
            this.lblRevenueValue.Name = "lblRevenueValue";
            this.lblRevenueValue.Size = new System.Drawing.Size(21, 15);
            this.lblRevenueValue.TabIndex = 7;
            this.lblRevenueValue.Text = "$0";
            // 
            // cardActive
            // 
            this.cardActive.BackColor = System.Drawing.Color.White;
            this.cardActive.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.cardActive.Controls.Add(this.lblActiveValue);
            this.cardActive.Controls.Add(this.lblActiveMembershipsTitle);
            this.cardActive.Location = new System.Drawing.Point(529, 23);
            this.cardActive.Name = "cardActive";
            this.cardActive.Size = new System.Drawing.Size(240, 95);
            this.cardActive.TabIndex = 4;
            // 
            // lblActiveValue
            // 
            this.lblActiveValue.AutoSize = true;
            this.lblActiveValue.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblActiveValue.Location = new System.Drawing.Point(105, 53);
            this.lblActiveValue.Name = "lblActiveValue";
            this.lblActiveValue.Size = new System.Drawing.Size(14, 15);
            this.lblActiveValue.TabIndex = 3;
            this.lblActiveValue.Text = "0";
            // 
            // lblActiveMembershipsTitle
            // 
            this.lblActiveMembershipsTitle.AutoSize = true;
            this.lblActiveMembershipsTitle.BackColor = System.Drawing.Color.Transparent;
            this.lblActiveMembershipsTitle.Location = new System.Drawing.Point(58, 18);
            this.lblActiveMembershipsTitle.Name = "lblActiveMembershipsTitle";
            this.lblActiveMembershipsTitle.Size = new System.Drawing.Size(115, 15);
            this.lblActiveMembershipsTitle.TabIndex = 2;
            this.lblActiveMembershipsTitle.Text = "Active Memberships";
            // 
            // pnlBottom
            // 
            this.pnlBottom.Controls.Add(this.lblExpiringValue);
            this.pnlBottom.Controls.Add(this.pnlRecentPayments);
            this.pnlBottom.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlBottom.Location = new System.Drawing.Point(0, 210);
            this.pnlBottom.Name = "pnlBottom";
            this.pnlBottom.Size = new System.Drawing.Size(1650, 690);
            this.pnlBottom.TabIndex = 3;
            // 
            // lblExpiringValue
            // 
            this.lblExpiringValue.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblExpiringValue.BackColor = System.Drawing.Color.White;
            this.lblExpiringValue.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblExpiringValue.Controls.Add(this.dgvExpiringSoon);
            this.lblExpiringValue.Controls.Add(this.lblExpiring);
            this.lblExpiringValue.Location = new System.Drawing.Point(885, 6);
            this.lblExpiringValue.Name = "lblExpiringValue";
            this.lblExpiringValue.Size = new System.Drawing.Size(717, 570);
            this.lblExpiringValue.TabIndex = 1;
            // 
            // dgvExpiringSoon
            // 
            this.dgvExpiringSoon.AllowUserToAddRows = false;
            this.dgvExpiringSoon.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvExpiringSoon.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvExpiringSoon.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvExpiringSoon.Location = new System.Drawing.Point(15, 45);
            this.dgvExpiringSoon.Name = "dgvExpiringSoon";
            this.dgvExpiringSoon.ReadOnly = true;
            this.dgvExpiringSoon.RowHeadersVisible = false;
            this.dgvExpiringSoon.RowHeadersWidth = 51;
            this.dgvExpiringSoon.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvExpiringSoon.Size = new System.Drawing.Size(687, 510);
            this.dgvExpiringSoon.TabIndex = 3;
            // 
            // lblExpiring
            // 
            this.lblExpiring.AutoSize = true;
            this.lblExpiring.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblExpiring.Location = new System.Drawing.Point(15, 12);
            this.lblExpiring.Name = "lblExpiring";
            this.lblExpiring.Size = new System.Drawing.Size(105, 20);
            this.lblExpiring.TabIndex = 2;
            this.lblExpiring.Text = "Expiring Soon";
            // 
            // pnlRecentPayments
            // 
            this.pnlRecentPayments.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.pnlRecentPayments.BackColor = System.Drawing.Color.White;
            this.pnlRecentPayments.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlRecentPayments.Controls.Add(this.dgvRecentPayments);
            this.pnlRecentPayments.Controls.Add(this.lblRecentPayments);
            this.pnlRecentPayments.Location = new System.Drawing.Point(52, 10);
            this.pnlRecentPayments.Name = "pnlRecentPayments";
            this.pnlRecentPayments.Size = new System.Drawing.Size(717, 570);
            this.pnlRecentPayments.TabIndex = 0;
            // 
            // dgvRecentPayments
            // 
            this.dgvRecentPayments.AllowUserToAddRows = false;
            this.dgvRecentPayments.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvRecentPayments.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvRecentPayments.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvRecentPayments.Location = new System.Drawing.Point(15, 45);
            this.dgvRecentPayments.Name = "dgvRecentPayments";
            this.dgvRecentPayments.ReadOnly = true;
            this.dgvRecentPayments.RowHeadersVisible = false;
            this.dgvRecentPayments.RowHeadersWidth = 51;
            this.dgvRecentPayments.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvRecentPayments.Size = new System.Drawing.Size(687, 510);
            this.dgvRecentPayments.TabIndex = 1;
            // 
            // lblRecentPayments
            // 
            this.lblRecentPayments.AutoSize = true;
            this.lblRecentPayments.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRecentPayments.Location = new System.Drawing.Point(15, 12);
            this.lblRecentPayments.Name = "lblRecentPayments";
            this.lblRecentPayments.Size = new System.Drawing.Size(130, 20);
            this.lblRecentPayments.TabIndex = 0;
            this.lblRecentPayments.Text = "Recent Payments";
            // 
            // UC_Dashboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.Controls.Add(this.pnlBottom);
            this.Controls.Add(this.pnlCards);
            this.Controls.Add(this.pnlHeader);
            this.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.Name = "UC_Dashboard";
            this.Size = new System.Drawing.Size(1650, 900);
            this.Load += new System.EventHandler(this.UC_Dashboard_Load);
            this.pnlHeader.ResumeLayout(false);
            this.pnlHeader.PerformLayout();
            this.cardTotalMembers.ResumeLayout(false);
            this.cardTotalMembers.PerformLayout();
            this.pnlCards.ResumeLayout(false);
            this.cardMachines.ResumeLayout(false);
            this.cardMachines.PerformLayout();
            this.cardRevenue.ResumeLayout(false);
            this.cardRevenue.PerformLayout();
            this.cardActive.ResumeLayout(false);
            this.cardActive.PerformLayout();
            this.pnlBottom.ResumeLayout(false);
            this.lblExpiringValue.ResumeLayout(false);
            this.lblExpiringValue.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvExpiringSoon)).EndInit();
            this.pnlRecentPayments.ResumeLayout(false);
            this.pnlRecentPayments.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvRecentPayments)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlHeader;
        private System.Windows.Forms.Label lblDashTitle;
        private System.Windows.Forms.Panel cardTotalMembers;
        private System.Windows.Forms.Panel pnlCards;
        private System.Windows.Forms.Panel cardMachines;
        private System.Windows.Forms.Panel cardRevenue;
        private System.Windows.Forms.Panel cardActive;
        private System.Windows.Forms.Label lblMembersValue;
        private System.Windows.Forms.Label lblTotalMembersTitle;
        private System.Windows.Forms.Label lblRevenueValue;
        private System.Windows.Forms.Label lblMonthlyRevenueTitle;
        private System.Windows.Forms.Label lblMachinesValue;
        private System.Windows.Forms.Label lblMachineTitle;
        private System.Windows.Forms.Label lblActiveValue;
        private System.Windows.Forms.Label lblActiveMembershipsTitle;
        private System.Windows.Forms.Panel pnlBottom;
        private System.Windows.Forms.Panel pnlRecentPayments;
        private System.Windows.Forms.Panel lblExpiringValue;
        private System.Windows.Forms.DataGridView dgvRecentPayments;
        private System.Windows.Forms.Label lblRecentPayments;
        private System.Windows.Forms.DataGridView dgvExpiringSoon;
        private System.Windows.Forms.Label lblExpiring;
    }
}
