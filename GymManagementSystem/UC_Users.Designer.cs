namespace GymManagementSystem
{
    partial class UC_Users
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
            this.pnlHeaderUsers = new System.Windows.Forms.Panel();
            this.lblUsersSub = new System.Windows.Forms.Label();
            this.lblUsersTitle = new System.Windows.Forms.Label();
            this.pnlUsersBody = new System.Windows.Forms.Panel();
            this.pnlUsersTable = new System.Windows.Forms.Panel();
            this.dgvUsers = new System.Windows.Forms.DataGridView();
            this.lblUserListTitle = new System.Windows.Forms.Label();
            this.pnlUsersForm = new System.Windows.Forms.Panel();
            this.chkEmailVerified = new System.Windows.Forms.CheckBox();
            this.txtUserPassword = new System.Windows.Forms.TextBox();
            this.btnUserClear = new System.Windows.Forms.Button();
            this.btnUserDelete = new System.Windows.Forms.Button();
            this.btnUserUpdate = new System.Windows.Forms.Button();
            this.btnUserAdd = new System.Windows.Forms.Button();
            this.txtUserEmail = new System.Windows.Forms.TextBox();
            this.cmbUserStatus = new System.Windows.Forms.ComboBox();
            this.lblUserStatus = new System.Windows.Forms.Label();
            this.cmbUserRole = new System.Windows.Forms.ComboBox();
            this.lblUserRole = new System.Windows.Forms.Label();
            this.lblUserPassword = new System.Windows.Forms.Label();
            this.txtUserFullName = new System.Windows.Forms.TextBox();
            this.lblUserEmail = new System.Windows.Forms.Label();
            this.lblUserFullName = new System.Windows.Forms.Label();
            this.lblUserFormTitle = new System.Windows.Forms.Label();
            this.pnlHeaderUsers.SuspendLayout();
            this.pnlUsersBody.SuspendLayout();
            this.pnlUsersTable.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvUsers)).BeginInit();
            this.pnlUsersForm.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlHeaderUsers
            // 
            this.pnlHeaderUsers.Controls.Add(this.lblUsersSub);
            this.pnlHeaderUsers.Controls.Add(this.lblUsersTitle);
            this.pnlHeaderUsers.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlHeaderUsers.Location = new System.Drawing.Point(0, 0);
            this.pnlHeaderUsers.Name = "pnlHeaderUsers";
            this.pnlHeaderUsers.Size = new System.Drawing.Size(1650, 70);
            this.pnlHeaderUsers.TabIndex = 1;
            // 
            // lblUsersSub
            // 
            this.lblUsersSub.AutoSize = true;
            this.lblUsersSub.ForeColor = System.Drawing.Color.DimGray;
            this.lblUsersSub.Location = new System.Drawing.Point(22, 48);
            this.lblUsersSub.Name = "lblUsersSub";
            this.lblUsersSub.Size = new System.Drawing.Size(233, 20);
            this.lblUsersSub.TabIndex = 1;
            this.lblUsersSub.Text = "Manage admin and staff accounts";
            // 
            // lblUsersTitle
            // 
            this.lblUsersTitle.AutoSize = true;
            this.lblUsersTitle.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUsersTitle.Location = new System.Drawing.Point(19, 11);
            this.lblUsersTitle.Name = "lblUsersTitle";
            this.lblUsersTitle.Size = new System.Drawing.Size(87, 37);
            this.lblUsersTitle.TabIndex = 0;
            this.lblUsersTitle.Text = "Users";
            // 
            // pnlUsersBody
            // 
            this.pnlUsersBody.BackColor = System.Drawing.Color.WhiteSmoke;
            this.pnlUsersBody.Controls.Add(this.pnlUsersTable);
            this.pnlUsersBody.Controls.Add(this.pnlUsersForm);
            this.pnlUsersBody.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlUsersBody.Location = new System.Drawing.Point(0, 70);
            this.pnlUsersBody.Name = "pnlUsersBody";
            this.pnlUsersBody.Size = new System.Drawing.Size(1650, 830);
            this.pnlUsersBody.TabIndex = 2;
            // 
            // pnlUsersTable
            // 
            this.pnlUsersTable.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pnlUsersTable.BackColor = System.Drawing.Color.White;
            this.pnlUsersTable.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlUsersTable.Controls.Add(this.dgvUsers);
            this.pnlUsersTable.Controls.Add(this.lblUserListTitle);
            this.pnlUsersTable.Location = new System.Drawing.Point(400, 10);
            this.pnlUsersTable.Name = "pnlUsersTable";
            this.pnlUsersTable.Size = new System.Drawing.Size(1200, 650);
            this.pnlUsersTable.TabIndex = 2;
            // 
            // dgvUsers
            // 
            this.dgvUsers.AllowUserToAddRows = false;
            this.dgvUsers.AllowUserToDeleteRows = false;
            this.dgvUsers.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvUsers.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvUsers.BackgroundColor = System.Drawing.Color.White;
            this.dgvUsers.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvUsers.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dgvUsers.ColumnHeadersHeight = 35;
            this.dgvUsers.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dgvUsers.Location = new System.Drawing.Point(15, 85);
            this.dgvUsers.MultiSelect = false;
            this.dgvUsers.Name = "dgvUsers";
            this.dgvUsers.ReadOnly = true;
            this.dgvUsers.RowHeadersVisible = false;
            this.dgvUsers.RowHeadersWidth = 51;
            this.dgvUsers.RowTemplate.Height = 30;
            this.dgvUsers.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvUsers.Size = new System.Drawing.Size(1160, 520);
            this.dgvUsers.TabIndex = 3;
            this.dgvUsers.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvUsers_CellClick);
            // 
            // lblUserListTitle
            // 
            this.lblUserListTitle.AutoSize = true;
            this.lblUserListTitle.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUserListTitle.Location = new System.Drawing.Point(15, 12);
            this.lblUserListTitle.Name = "lblUserListTitle";
            this.lblUserListTitle.Size = new System.Drawing.Size(116, 25);
            this.lblUserListTitle.TabIndex = 0;
            this.lblUserListTitle.Text = "User Details";
            // 
            // pnlUsersForm
            // 
            this.pnlUsersForm.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.pnlUsersForm.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlUsersForm.Controls.Add(this.chkEmailVerified);
            this.pnlUsersForm.Controls.Add(this.txtUserPassword);
            this.pnlUsersForm.Controls.Add(this.btnUserClear);
            this.pnlUsersForm.Controls.Add(this.btnUserDelete);
            this.pnlUsersForm.Controls.Add(this.btnUserUpdate);
            this.pnlUsersForm.Controls.Add(this.btnUserAdd);
            this.pnlUsersForm.Controls.Add(this.txtUserEmail);
            this.pnlUsersForm.Controls.Add(this.cmbUserStatus);
            this.pnlUsersForm.Controls.Add(this.lblUserStatus);
            this.pnlUsersForm.Controls.Add(this.cmbUserRole);
            this.pnlUsersForm.Controls.Add(this.lblUserRole);
            this.pnlUsersForm.Controls.Add(this.lblUserPassword);
            this.pnlUsersForm.Controls.Add(this.txtUserFullName);
            this.pnlUsersForm.Controls.Add(this.lblUserEmail);
            this.pnlUsersForm.Controls.Add(this.lblUserFullName);
            this.pnlUsersForm.Controls.Add(this.lblUserFormTitle);
            this.pnlUsersForm.Location = new System.Drawing.Point(20, 10);
            this.pnlUsersForm.Name = "pnlUsersForm";
            this.pnlUsersForm.Size = new System.Drawing.Size(374, 650);
            this.pnlUsersForm.TabIndex = 0;
            // 
            // chkEmailVerified
            // 
            this.chkEmailVerified.AutoSize = true;
            this.chkEmailVerified.Enabled = false;
            this.chkEmailVerified.Location = new System.Drawing.Point(21, 370);
            this.chkEmailVerified.Name = "chkEmailVerified";
            this.chkEmailVerified.Size = new System.Drawing.Size(123, 24);
            this.chkEmailVerified.TabIndex = 41;
            this.chkEmailVerified.Text = "Email Verified";
            this.chkEmailVerified.UseVisualStyleBackColor = true;
            // 
            // txtUserPassword
            // 
            this.txtUserPassword.Location = new System.Drawing.Point(24, 208);
            this.txtUserPassword.Name = "txtUserPassword";
            this.txtUserPassword.Size = new System.Drawing.Size(200, 27);
            this.txtUserPassword.TabIndex = 40;
            this.txtUserPassword.UseSystemPasswordChar = true;
            // 
            // btnUserClear
            // 
            this.btnUserClear.BackColor = System.Drawing.Color.DimGray;
            this.btnUserClear.FlatAppearance.BorderSize = 0;
            this.btnUserClear.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnUserClear.Location = new System.Drawing.Point(181, 462);
            this.btnUserClear.Name = "btnUserClear";
            this.btnUserClear.Size = new System.Drawing.Size(150, 36);
            this.btnUserClear.TabIndex = 39;
            this.btnUserClear.Text = "Clear";
            this.btnUserClear.UseVisualStyleBackColor = false;
            this.btnUserClear.Click += new System.EventHandler(this.btnUserClear_Click);
            // 
            // btnUserDelete
            // 
            this.btnUserDelete.BackColor = System.Drawing.Color.Firebrick;
            this.btnUserDelete.FlatAppearance.BorderSize = 0;
            this.btnUserDelete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnUserDelete.Location = new System.Drawing.Point(25, 462);
            this.btnUserDelete.Name = "btnUserDelete";
            this.btnUserDelete.Size = new System.Drawing.Size(150, 36);
            this.btnUserDelete.TabIndex = 38;
            this.btnUserDelete.Text = "Delete";
            this.btnUserDelete.UseVisualStyleBackColor = false;
            this.btnUserDelete.Click += new System.EventHandler(this.btnUserDelete_Click);
            // 
            // btnUserUpdate
            // 
            this.btnUserUpdate.BackColor = System.Drawing.Color.Gainsboro;
            this.btnUserUpdate.FlatAppearance.BorderSize = 0;
            this.btnUserUpdate.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnUserUpdate.Location = new System.Drawing.Point(181, 401);
            this.btnUserUpdate.Name = "btnUserUpdate";
            this.btnUserUpdate.Size = new System.Drawing.Size(150, 36);
            this.btnUserUpdate.TabIndex = 37;
            this.btnUserUpdate.Text = "Update";
            this.btnUserUpdate.UseVisualStyleBackColor = false;
            this.btnUserUpdate.Click += new System.EventHandler(this.btnUserUpdate_Click);
            // 
            // btnUserAdd
            // 
            this.btnUserAdd.BackColor = System.Drawing.Color.RoyalBlue;
            this.btnUserAdd.FlatAppearance.BorderSize = 0;
            this.btnUserAdd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnUserAdd.Location = new System.Drawing.Point(25, 401);
            this.btnUserAdd.Name = "btnUserAdd";
            this.btnUserAdd.Size = new System.Drawing.Size(150, 36);
            this.btnUserAdd.TabIndex = 36;
            this.btnUserAdd.Text = "Add";
            this.btnUserAdd.UseVisualStyleBackColor = false;
            this.btnUserAdd.Click += new System.EventHandler(this.btnUserAdd_Click);
            // 
            // txtUserEmail
            // 
            this.txtUserEmail.Location = new System.Drawing.Point(24, 150);
            this.txtUserEmail.Name = "txtUserEmail";
            this.txtUserEmail.Size = new System.Drawing.Size(200, 27);
            this.txtUserEmail.TabIndex = 35;
            // 
            // cmbUserStatus
            // 
            this.cmbUserStatus.FormattingEnabled = true;
            this.cmbUserStatus.Items.AddRange(new object[] {
            "Active",
            "Inactive"});
            this.cmbUserStatus.Location = new System.Drawing.Point(21, 329);
            this.cmbUserStatus.Name = "cmbUserStatus";
            this.cmbUserStatus.Size = new System.Drawing.Size(200, 28);
            this.cmbUserStatus.TabIndex = 30;
            // 
            // lblUserStatus
            // 
            this.lblUserStatus.AutoSize = true;
            this.lblUserStatus.Location = new System.Drawing.Point(21, 309);
            this.lblUserStatus.Name = "lblUserStatus";
            this.lblUserStatus.Size = new System.Drawing.Size(49, 20);
            this.lblUserStatus.TabIndex = 29;
            this.lblUserStatus.Text = "Status";
            // 
            // cmbUserRole
            // 
            this.cmbUserRole.FormattingEnabled = true;
            this.cmbUserRole.Items.AddRange(new object[] {
            "Admin",
            "Staff"});
            this.cmbUserRole.Location = new System.Drawing.Point(24, 270);
            this.cmbUserRole.Name = "cmbUserRole";
            this.cmbUserRole.Size = new System.Drawing.Size(200, 28);
            this.cmbUserRole.TabIndex = 28;
            // 
            // lblUserRole
            // 
            this.lblUserRole.AutoSize = true;
            this.lblUserRole.Location = new System.Drawing.Point(24, 250);
            this.lblUserRole.Name = "lblUserRole";
            this.lblUserRole.Size = new System.Drawing.Size(39, 20);
            this.lblUserRole.TabIndex = 27;
            this.lblUserRole.Text = "Role";
            // 
            // lblUserPassword
            // 
            this.lblUserPassword.AutoSize = true;
            this.lblUserPassword.Location = new System.Drawing.Point(24, 190);
            this.lblUserPassword.Name = "lblUserPassword";
            this.lblUserPassword.Size = new System.Drawing.Size(70, 20);
            this.lblUserPassword.TabIndex = 25;
            this.lblUserPassword.Text = "Password";
            // 
            // txtUserFullName
            // 
            this.txtUserFullName.Location = new System.Drawing.Point(24, 90);
            this.txtUserFullName.Name = "txtUserFullName";
            this.txtUserFullName.Size = new System.Drawing.Size(200, 27);
            this.txtUserFullName.TabIndex = 24;
            // 
            // lblUserEmail
            // 
            this.lblUserEmail.AutoSize = true;
            this.lblUserEmail.Location = new System.Drawing.Point(24, 130);
            this.lblUserEmail.Name = "lblUserEmail";
            this.lblUserEmail.Size = new System.Drawing.Size(46, 20);
            this.lblUserEmail.TabIndex = 23;
            this.lblUserEmail.Text = "Email";
            // 
            // lblUserFullName
            // 
            this.lblUserFullName.AutoSize = true;
            this.lblUserFullName.Location = new System.Drawing.Point(24, 70);
            this.lblUserFullName.Name = "lblUserFullName";
            this.lblUserFullName.Size = new System.Drawing.Size(76, 20);
            this.lblUserFullName.TabIndex = 22;
            this.lblUserFullName.Text = "Full Name";
            // 
            // lblUserFormTitle
            // 
            this.lblUserFormTitle.AutoSize = true;
            this.lblUserFormTitle.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUserFormTitle.Location = new System.Drawing.Point(24, 22);
            this.lblUserFormTitle.Name = "lblUserFormTitle";
            this.lblUserFormTitle.Size = new System.Drawing.Size(108, 25);
            this.lblUserFormTitle.TabIndex = 21;
            this.lblUserFormTitle.Text = "User Detail";
            // 
            // UC_Users
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.pnlUsersBody);
            this.Controls.Add(this.pnlHeaderUsers);
            this.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.Name = "UC_Users";
            this.Size = new System.Drawing.Size(1650, 900);
            this.Load += new System.EventHandler(this.UC_Users_Load);
            this.pnlHeaderUsers.ResumeLayout(false);
            this.pnlHeaderUsers.PerformLayout();
            this.pnlUsersBody.ResumeLayout(false);
            this.pnlUsersTable.ResumeLayout(false);
            this.pnlUsersTable.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvUsers)).EndInit();
            this.pnlUsersForm.ResumeLayout(false);
            this.pnlUsersForm.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlHeaderUsers;
        private System.Windows.Forms.Label lblUsersSub;
        private System.Windows.Forms.Label lblUsersTitle;
        private System.Windows.Forms.Panel pnlUsersBody;
        private System.Windows.Forms.Panel pnlUsersForm;
        private System.Windows.Forms.TextBox txtUserPassword;
        private System.Windows.Forms.Button btnUserClear;
        private System.Windows.Forms.Button btnUserDelete;
        private System.Windows.Forms.Button btnUserUpdate;
        private System.Windows.Forms.Button btnUserAdd;
        private System.Windows.Forms.TextBox txtUserEmail;
        private System.Windows.Forms.ComboBox cmbUserStatus;
        private System.Windows.Forms.Label lblUserStatus;
        private System.Windows.Forms.ComboBox cmbUserRole;
        private System.Windows.Forms.Label lblUserRole;
        private System.Windows.Forms.Label lblUserPassword;
        private System.Windows.Forms.TextBox txtUserFullName;
        private System.Windows.Forms.Label lblUserEmail;
        private System.Windows.Forms.Label lblUserFullName;
        private System.Windows.Forms.Label lblUserFormTitle;
        private System.Windows.Forms.CheckBox chkEmailVerified;
        private System.Windows.Forms.Panel pnlUsersTable;
        private System.Windows.Forms.DataGridView dgvUsers;
        private System.Windows.Forms.Label lblUserListTitle;
    }
}
