namespace GymManagementSystem.Main
{
    partial class FrmMain
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmMain));
            this.pnlSidebar = new System.Windows.Forms.Panel();
            this.pnlNav = new System.Windows.Forms.Panel();
            this.btnUsers = new System.Windows.Forms.Button();
            this.btnMachines = new System.Windows.Forms.Button();
            this.btnPayments = new System.Windows.Forms.Button();
            this.btnMemberships = new System.Windows.Forms.Button();
            this.btnMembers = new System.Windows.Forms.Button();
            this.btnDashboard = new System.Windows.Forms.Button();
            this.pnlBrand = new System.Windows.Forms.Panel();
            this.picLogo = new System.Windows.Forms.PictureBox();
            this.lblRole = new System.Windows.Forms.Label();
            this.lblBrand = new System.Windows.Forms.Label();
            this.pnlTopbar = new System.Windows.Forms.Panel();
            this.btnLogout = new System.Windows.Forms.Button();
            this.lblUserName = new System.Windows.Forms.Label();
            this.lblPageTitle = new System.Windows.Forms.Label();
            this.pnlContent = new System.Windows.Forms.Panel();
            this.pnlSidebar.SuspendLayout();
            this.pnlNav.SuspendLayout();
            this.pnlBrand.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picLogo)).BeginInit();
            this.pnlTopbar.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlSidebar
            // 
            this.pnlSidebar.BackColor = System.Drawing.Color.White;
            this.pnlSidebar.Controls.Add(this.pnlNav);
            this.pnlSidebar.Controls.Add(this.pnlBrand);
            this.pnlSidebar.Dock = System.Windows.Forms.DockStyle.Left;
            this.pnlSidebar.Location = new System.Drawing.Point(0, 0);
            this.pnlSidebar.Name = "pnlSidebar";
            this.pnlSidebar.Size = new System.Drawing.Size(230, 1041);
            this.pnlSidebar.TabIndex = 0;
            // 
            // pnlNav
            // 
            this.pnlNav.Controls.Add(this.btnUsers);
            this.pnlNav.Controls.Add(this.btnMachines);
            this.pnlNav.Controls.Add(this.btnPayments);
            this.pnlNav.Controls.Add(this.btnMemberships);
            this.pnlNav.Controls.Add(this.btnMembers);
            this.pnlNav.Controls.Add(this.btnDashboard);
            this.pnlNav.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlNav.Location = new System.Drawing.Point(0, 80);
            this.pnlNav.Name = "pnlNav";
            this.pnlNav.Size = new System.Drawing.Size(230, 961);
            this.pnlNav.TabIndex = 3;
            // 
            // btnUsers
            // 
            this.btnUsers.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnUsers.FlatAppearance.BorderSize = 0;
            this.btnUsers.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnUsers.ForeColor = System.Drawing.Color.DimGray;
            this.btnUsers.Location = new System.Drawing.Point(0, 225);
            this.btnUsers.Name = "btnUsers";
            this.btnUsers.Padding = new System.Windows.Forms.Padding(12, 0, 0, 0);
            this.btnUsers.Size = new System.Drawing.Size(230, 45);
            this.btnUsers.TabIndex = 8;
            this.btnUsers.Text = "Users";
            this.btnUsers.UseVisualStyleBackColor = true;
            this.btnUsers.Click += new System.EventHandler(this.btnUsers_Click);
            // 
            // btnMachines
            // 
            this.btnMachines.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnMachines.FlatAppearance.BorderSize = 0;
            this.btnMachines.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMachines.ForeColor = System.Drawing.Color.DimGray;
            this.btnMachines.Location = new System.Drawing.Point(0, 180);
            this.btnMachines.Name = "btnMachines";
            this.btnMachines.Padding = new System.Windows.Forms.Padding(12, 0, 0, 0);
            this.btnMachines.Size = new System.Drawing.Size(230, 45);
            this.btnMachines.TabIndex = 7;
            this.btnMachines.Text = "Machines";
            this.btnMachines.UseVisualStyleBackColor = true;
            this.btnMachines.Click += new System.EventHandler(this.btnMachines_Click);
            // 
            // btnPayments
            // 
            this.btnPayments.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnPayments.FlatAppearance.BorderSize = 0;
            this.btnPayments.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPayments.ForeColor = System.Drawing.Color.DimGray;
            this.btnPayments.Location = new System.Drawing.Point(0, 135);
            this.btnPayments.Name = "btnPayments";
            this.btnPayments.Padding = new System.Windows.Forms.Padding(12, 0, 0, 0);
            this.btnPayments.Size = new System.Drawing.Size(230, 45);
            this.btnPayments.TabIndex = 6;
            this.btnPayments.Text = "Payments";
            this.btnPayments.UseVisualStyleBackColor = true;
            this.btnPayments.Click += new System.EventHandler(this.btnPayments_Click);
            // 
            // btnMemberships
            // 
            this.btnMemberships.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnMemberships.FlatAppearance.BorderSize = 0;
            this.btnMemberships.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMemberships.ForeColor = System.Drawing.Color.DimGray;
            this.btnMemberships.Location = new System.Drawing.Point(0, 90);
            this.btnMemberships.Name = "btnMemberships";
            this.btnMemberships.Padding = new System.Windows.Forms.Padding(12, 0, 0, 0);
            this.btnMemberships.Size = new System.Drawing.Size(230, 45);
            this.btnMemberships.TabIndex = 5;
            this.btnMemberships.Text = "Memberships";
            this.btnMemberships.UseVisualStyleBackColor = true;
            this.btnMemberships.Click += new System.EventHandler(this.btnMemberships_Click);
            // 
            // btnMembers
            // 
            this.btnMembers.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnMembers.FlatAppearance.BorderSize = 0;
            this.btnMembers.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMembers.ForeColor = System.Drawing.Color.DimGray;
            this.btnMembers.Location = new System.Drawing.Point(0, 45);
            this.btnMembers.Name = "btnMembers";
            this.btnMembers.Padding = new System.Windows.Forms.Padding(12, 0, 0, 0);
            this.btnMembers.Size = new System.Drawing.Size(230, 45);
            this.btnMembers.TabIndex = 4;
            this.btnMembers.Text = "Members";
            this.btnMembers.UseVisualStyleBackColor = true;
            this.btnMembers.Click += new System.EventHandler(this.btnMembers_Click);
            // 
            // btnDashboard
            // 
            this.btnDashboard.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnDashboard.FlatAppearance.BorderSize = 0;
            this.btnDashboard.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDashboard.ForeColor = System.Drawing.Color.DimGray;
            this.btnDashboard.Location = new System.Drawing.Point(0, 0);
            this.btnDashboard.Name = "btnDashboard";
            this.btnDashboard.Padding = new System.Windows.Forms.Padding(12, 0, 0, 0);
            this.btnDashboard.Size = new System.Drawing.Size(230, 45);
            this.btnDashboard.TabIndex = 3;
            this.btnDashboard.Text = "Dashboard";
            this.btnDashboard.UseVisualStyleBackColor = true;
            this.btnDashboard.Click += new System.EventHandler(this.btnDashboard_Click);
            // 
            // pnlBrand
            // 
            this.pnlBrand.Controls.Add(this.picLogo);
            this.pnlBrand.Controls.Add(this.lblRole);
            this.pnlBrand.Controls.Add(this.lblBrand);
            this.pnlBrand.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlBrand.Location = new System.Drawing.Point(0, 0);
            this.pnlBrand.Name = "pnlBrand";
            this.pnlBrand.Size = new System.Drawing.Size(230, 80);
            this.pnlBrand.TabIndex = 0;
            // 
            // picLogo
            // 
            this.picLogo.Image = ((System.Drawing.Image)(resources.GetObject("picLogo.Image")));
            this.picLogo.Location = new System.Drawing.Point(0, 3);
            this.picLogo.Name = "picLogo";
            this.picLogo.Size = new System.Drawing.Size(112, 74);
            this.picLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picLogo.TabIndex = 0;
            this.picLogo.TabStop = false;
            // 
            // lblRole
            // 
            this.lblRole.AutoSize = true;
            this.lblRole.ForeColor = System.Drawing.Color.DimGray;
            this.lblRole.Location = new System.Drawing.Point(118, 39);
            this.lblRole.Name = "lblRole";
            this.lblRole.Size = new System.Drawing.Size(75, 15);
            this.lblRole.TabIndex = 2;
            this.lblRole.Text = "Admin Panel";
            // 
            // lblBrand
            // 
            this.lblBrand.AutoSize = true;
            this.lblBrand.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBrand.ForeColor = System.Drawing.Color.Black;
            this.lblBrand.Location = new System.Drawing.Point(118, 18);
            this.lblBrand.Name = "lblBrand";
            this.lblBrand.Size = new System.Drawing.Size(104, 21);
            this.lblBrand.TabIndex = 1;
            this.lblBrand.Text = "Gym System";
            // 
            // pnlTopbar
            // 
            this.pnlTopbar.BackColor = System.Drawing.Color.White;
            this.pnlTopbar.Controls.Add(this.btnLogout);
            this.pnlTopbar.Controls.Add(this.lblUserName);
            this.pnlTopbar.Controls.Add(this.lblPageTitle);
            this.pnlTopbar.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlTopbar.Location = new System.Drawing.Point(230, 0);
            this.pnlTopbar.Name = "pnlTopbar";
            this.pnlTopbar.Size = new System.Drawing.Size(1674, 60);
            this.pnlTopbar.TabIndex = 0;
            // 
            // btnLogout
            // 
            this.btnLogout.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnLogout.BackColor = System.Drawing.Color.Gainsboro;
            this.btnLogout.FlatAppearance.BorderSize = 0;
            this.btnLogout.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLogout.Location = new System.Drawing.Point(1575, 27);
            this.btnLogout.Name = "btnLogout";
            this.btnLogout.Size = new System.Drawing.Size(90, 32);
            this.btnLogout.TabIndex = 1;
            this.btnLogout.Text = "Logout";
            this.btnLogout.UseVisualStyleBackColor = false;
            this.btnLogout.Click += new System.EventHandler(this.btnLogout_Click);
            // 
            // lblUserName
            // 
            this.lblUserName.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblUserName.AutoSize = true;
            this.lblUserName.ForeColor = System.Drawing.Color.DimGray;
            this.lblUserName.Location = new System.Drawing.Point(1572, 9);
            this.lblUserName.Name = "lblUserName";
            this.lblUserName.Size = new System.Drawing.Size(99, 15);
            this.lblUserName.TabIndex = 0;
            this.lblUserName.Text = "Welcome, Admin";
            // 
            // lblPageTitle
            // 
            this.lblPageTitle.AutoSize = true;
            this.lblPageTitle.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPageTitle.Location = new System.Drawing.Point(20, 18);
            this.lblPageTitle.Name = "lblPageTitle";
            this.lblPageTitle.Size = new System.Drawing.Size(93, 21);
            this.lblPageTitle.TabIndex = 0;
            this.lblPageTitle.Text = "Dashboard";
            // 
            // pnlContent
            // 
            this.pnlContent.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlContent.Location = new System.Drawing.Point(230, 60);
            this.pnlContent.Name = "pnlContent";
            this.pnlContent.Size = new System.Drawing.Size(1674, 981);
            this.pnlContent.TabIndex = 0;
            // 
            // FrmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.ClientSize = new System.Drawing.Size(1904, 1041);
            this.Controls.Add(this.pnlContent);
            this.Controls.Add(this.pnlTopbar);
            this.Controls.Add(this.pnlSidebar);
            this.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.Name = "FrmMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Gym Management System";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.FrmMain_Load);
            this.pnlSidebar.ResumeLayout(false);
            this.pnlNav.ResumeLayout(false);
            this.pnlBrand.ResumeLayout(false);
            this.pnlBrand.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picLogo)).EndInit();
            this.pnlTopbar.ResumeLayout(false);
            this.pnlTopbar.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlSidebar;
        private System.Windows.Forms.Panel pnlTopbar;
        private System.Windows.Forms.Panel pnlBrand;
        private System.Windows.Forms.PictureBox picLogo;
        private System.Windows.Forms.Label lblBrand;
        private System.Windows.Forms.Panel pnlNav;
        private System.Windows.Forms.Button btnDashboard;
        private System.Windows.Forms.Label lblRole;
        private System.Windows.Forms.Button btnUsers;
        private System.Windows.Forms.Button btnMachines;
        private System.Windows.Forms.Button btnPayments;
        private System.Windows.Forms.Button btnMemberships;
        private System.Windows.Forms.Button btnMembers;
        private System.Windows.Forms.Label lblPageTitle;
        private System.Windows.Forms.Panel pnlContent;
        private System.Windows.Forms.Button btnLogout;
        private System.Windows.Forms.Label lblUserName;
    }
}