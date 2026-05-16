namespace GymManagementSystem
{
    partial class UC_Members
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
            this.pnlHeaderMembers = new System.Windows.Forms.Panel();
            this.lblMembersSub = new System.Windows.Forms.Label();
            this.lblMembersTitle = new System.Windows.Forms.Label();
            this.pnlMembersBody = new System.Windows.Forms.Panel();
            this.pnlMemberTable = new System.Windows.Forms.Panel();
            this.dgvMembers = new System.Windows.Forms.DataGridView();
            this.lblListTitle = new System.Windows.Forms.Label();
            this.pnlMemberForm = new System.Windows.Forms.Panel();
            this.btnClear = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            this.txtMemberPhone = new System.Windows.Forms.TextBox();
            this.lblEndDate = new System.Windows.Forms.Label();
            this.dtpMemberEnd = new System.Windows.Forms.DateTimePicker();
            this.dtpMemberStart = new System.Windows.Forms.DateTimePicker();
            this.lblStartDate = new System.Windows.Forms.Label();
            this.cmbMemberStatus = new System.Windows.Forms.ComboBox();
            this.lblStatus = new System.Windows.Forms.Label();
            this.cmbMemberPlan = new System.Windows.Forms.ComboBox();
            this.lblMembershipPlan = new System.Windows.Forms.Label();
            this.cmbMemberGender = new System.Windows.Forms.ComboBox();
            this.lblGender = new System.Windows.Forms.Label();
            this.txtMemberName = new System.Windows.Forms.TextBox();
            this.lblPhone = new System.Windows.Forms.Label();
            this.lblFullName = new System.Windows.Forms.Label();
            this.lblFormTitle = new System.Windows.Forms.Label();
            this.pnlHeaderMembers.SuspendLayout();
            this.pnlMembersBody.SuspendLayout();
            this.pnlMemberTable.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMembers)).BeginInit();
            this.pnlMemberForm.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlHeaderMembers
            // 
            this.pnlHeaderMembers.Controls.Add(this.lblMembersSub);
            this.pnlHeaderMembers.Controls.Add(this.lblMembersTitle);
            this.pnlHeaderMembers.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlHeaderMembers.Location = new System.Drawing.Point(0, 0);
            this.pnlHeaderMembers.Name = "pnlHeaderMembers";
            this.pnlHeaderMembers.Size = new System.Drawing.Size(1650, 70);
            this.pnlHeaderMembers.TabIndex = 0;
            // 
            // lblMembersSub
            // 
            this.lblMembersSub.AutoSize = true;
            this.lblMembersSub.ForeColor = System.Drawing.Color.DimGray;
            this.lblMembersSub.Location = new System.Drawing.Point(22, 48);
            this.lblMembersSub.Name = "lblMembersSub";
            this.lblMembersSub.Size = new System.Drawing.Size(318, 20);
            this.lblMembersSub.TabIndex = 1;
            this.lblMembersSub.Text = "Manage gym members and their memberships";
            // 
            // lblMembersTitle
            // 
            this.lblMembersTitle.AutoSize = true;
            this.lblMembersTitle.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMembersTitle.Location = new System.Drawing.Point(20, 20);
            this.lblMembersTitle.Name = "lblMembersTitle";
            this.lblMembersTitle.Size = new System.Drawing.Size(138, 37);
            this.lblMembersTitle.TabIndex = 0;
            this.lblMembersTitle.Text = "Members";
            // 
            // pnlMembersBody
            // 
            this.pnlMembersBody.Controls.Add(this.pnlMemberTable);
            this.pnlMembersBody.Controls.Add(this.pnlMemberForm);
            this.pnlMembersBody.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlMembersBody.Location = new System.Drawing.Point(0, 70);
            this.pnlMembersBody.Name = "pnlMembersBody";
            this.pnlMembersBody.Size = new System.Drawing.Size(1650, 830);
            this.pnlMembersBody.TabIndex = 1;
            // 
            // pnlMemberTable
            // 
            this.pnlMemberTable.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pnlMemberTable.BackColor = System.Drawing.Color.White;
            this.pnlMemberTable.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlMemberTable.Controls.Add(this.dgvMembers);
            this.pnlMemberTable.Controls.Add(this.lblListTitle);
            this.pnlMemberTable.Location = new System.Drawing.Point(400, 10);
            this.pnlMemberTable.Name = "pnlMemberTable";
            this.pnlMemberTable.Size = new System.Drawing.Size(1200, 700);
            this.pnlMemberTable.TabIndex = 1;
            // 
            // dgvMembers
            // 
            this.dgvMembers.AllowUserToAddRows = false;
            this.dgvMembers.AllowUserToDeleteRows = false;
            this.dgvMembers.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvMembers.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvMembers.BackgroundColor = System.Drawing.Color.White;
            this.dgvMembers.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvMembers.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dgvMembers.ColumnHeadersHeight = 35;
            this.dgvMembers.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dgvMembers.Location = new System.Drawing.Point(15, 85);
            this.dgvMembers.MultiSelect = false;
            this.dgvMembers.Name = "dgvMembers";
            this.dgvMembers.ReadOnly = true;
            this.dgvMembers.RowHeadersVisible = false;
            this.dgvMembers.RowHeadersWidth = 51;
            this.dgvMembers.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvMembers.Size = new System.Drawing.Size(1160, 560);
            this.dgvMembers.TabIndex = 3;
            this.dgvMembers.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvMembers_CellClick);
            // 
            // lblListTitle
            // 
            this.lblListTitle.AutoSize = true;
            this.lblListTitle.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblListTitle.Location = new System.Drawing.Point(15, 12);
            this.lblListTitle.Name = "lblListTitle";
            this.lblListTitle.Size = new System.Drawing.Size(130, 25);
            this.lblListTitle.TabIndex = 0;
            this.lblListTitle.Text = "Members List";
            // 
            // pnlMemberForm
            // 
            this.pnlMemberForm.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.pnlMemberForm.BackColor = System.Drawing.Color.White;
            this.pnlMemberForm.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlMemberForm.Controls.Add(this.btnClear);
            this.pnlMemberForm.Controls.Add(this.btnDelete);
            this.pnlMemberForm.Controls.Add(this.btnUpdate);
            this.pnlMemberForm.Controls.Add(this.btnAdd);
            this.pnlMemberForm.Controls.Add(this.txtMemberPhone);
            this.pnlMemberForm.Controls.Add(this.lblEndDate);
            this.pnlMemberForm.Controls.Add(this.dtpMemberEnd);
            this.pnlMemberForm.Controls.Add(this.dtpMemberStart);
            this.pnlMemberForm.Controls.Add(this.lblStartDate);
            this.pnlMemberForm.Controls.Add(this.cmbMemberStatus);
            this.pnlMemberForm.Controls.Add(this.lblStatus);
            this.pnlMemberForm.Controls.Add(this.cmbMemberPlan);
            this.pnlMemberForm.Controls.Add(this.lblMembershipPlan);
            this.pnlMemberForm.Controls.Add(this.cmbMemberGender);
            this.pnlMemberForm.Controls.Add(this.lblGender);
            this.pnlMemberForm.Controls.Add(this.txtMemberName);
            this.pnlMemberForm.Controls.Add(this.lblPhone);
            this.pnlMemberForm.Controls.Add(this.lblFullName);
            this.pnlMemberForm.Controls.Add(this.lblFormTitle);
            this.pnlMemberForm.Location = new System.Drawing.Point(20, 10);
            this.pnlMemberForm.Name = "pnlMemberForm";
            this.pnlMemberForm.Size = new System.Drawing.Size(350, 700);
            this.pnlMemberForm.TabIndex = 0;
            // 
            // btnClear
            // 
            this.btnClear.BackColor = System.Drawing.Color.DimGray;
            this.btnClear.FlatAppearance.BorderSize = 0;
            this.btnClear.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClear.Location = new System.Drawing.Point(169, 549);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(150, 36);
            this.btnClear.TabIndex = 20;
            this.btnClear.Text = "Clear";
            this.btnClear.UseVisualStyleBackColor = false;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.BackColor = System.Drawing.Color.Firebrick;
            this.btnDelete.FlatAppearance.BorderSize = 0;
            this.btnDelete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDelete.Location = new System.Drawing.Point(13, 549);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(150, 36);
            this.btnDelete.TabIndex = 19;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = false;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnUpdate
            // 
            this.btnUpdate.BackColor = System.Drawing.Color.Gainsboro;
            this.btnUpdate.FlatAppearance.BorderSize = 0;
            this.btnUpdate.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnUpdate.Location = new System.Drawing.Point(169, 488);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(150, 36);
            this.btnUpdate.TabIndex = 18;
            this.btnUpdate.Text = "Update";
            this.btnUpdate.UseVisualStyleBackColor = false;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // btnAdd
            // 
            this.btnAdd.BackColor = System.Drawing.Color.RoyalBlue;
            this.btnAdd.FlatAppearance.BorderSize = 0;
            this.btnAdd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAdd.Location = new System.Drawing.Point(13, 488);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(150, 36);
            this.btnAdd.TabIndex = 17;
            this.btnAdd.Text = "Add";
            this.btnAdd.UseVisualStyleBackColor = false;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // txtMemberPhone
            // 
            this.txtMemberPhone.Location = new System.Drawing.Point(15, 140);
            this.txtMemberPhone.Name = "txtMemberPhone";
            this.txtMemberPhone.Size = new System.Drawing.Size(200, 27);
            this.txtMemberPhone.TabIndex = 16;
            // 
            // lblEndDate
            // 
            this.lblEndDate.AutoSize = true;
            this.lblEndDate.Location = new System.Drawing.Point(16, 360);
            this.lblEndDate.Name = "lblEndDate";
            this.lblEndDate.Size = new System.Drawing.Size(70, 20);
            this.lblEndDate.TabIndex = 15;
            this.lblEndDate.Text = "End Date";
            // 
            // dtpMemberEnd
            // 
            this.dtpMemberEnd.Location = new System.Drawing.Point(15, 380);
            this.dtpMemberEnd.Name = "dtpMemberEnd";
            this.dtpMemberEnd.Size = new System.Drawing.Size(200, 27);
            this.dtpMemberEnd.TabIndex = 14;
            // 
            // dtpMemberStart
            // 
            this.dtpMemberStart.Location = new System.Drawing.Point(15, 320);
            this.dtpMemberStart.Name = "dtpMemberStart";
            this.dtpMemberStart.Size = new System.Drawing.Size(200, 27);
            this.dtpMemberStart.TabIndex = 13;
            // 
            // lblStartDate
            // 
            this.lblStartDate.AutoSize = true;
            this.lblStartDate.Location = new System.Drawing.Point(15, 300);
            this.lblStartDate.Name = "lblStartDate";
            this.lblStartDate.Size = new System.Drawing.Size(76, 20);
            this.lblStartDate.TabIndex = 12;
            this.lblStartDate.Text = "Start Date";
            // 
            // cmbMemberStatus
            // 
            this.cmbMemberStatus.FormattingEnabled = true;
            this.cmbMemberStatus.Items.AddRange(new object[] {
            "Active",
            "Expired"});
            this.cmbMemberStatus.Location = new System.Drawing.Point(15, 440);
            this.cmbMemberStatus.Name = "cmbMemberStatus";
            this.cmbMemberStatus.Size = new System.Drawing.Size(200, 28);
            this.cmbMemberStatus.TabIndex = 11;
            // 
            // lblStatus
            // 
            this.lblStatus.AutoSize = true;
            this.lblStatus.Location = new System.Drawing.Point(15, 420);
            this.lblStatus.Name = "lblStatus";
            this.lblStatus.Size = new System.Drawing.Size(49, 20);
            this.lblStatus.TabIndex = 10;
            this.lblStatus.Text = "Status";
            // 
            // cmbMemberPlan
            // 
            this.cmbMemberPlan.FormattingEnabled = true;
            this.cmbMemberPlan.Location = new System.Drawing.Point(15, 260);
            this.cmbMemberPlan.Name = "cmbMemberPlan";
            this.cmbMemberPlan.Size = new System.Drawing.Size(200, 28);
            this.cmbMemberPlan.TabIndex = 9;
            // 
            // lblMembershipPlan
            // 
            this.lblMembershipPlan.AutoSize = true;
            this.lblMembershipPlan.Location = new System.Drawing.Point(15, 240);
            this.lblMembershipPlan.Name = "lblMembershipPlan";
            this.lblMembershipPlan.Size = new System.Drawing.Size(124, 20);
            this.lblMembershipPlan.TabIndex = 8;
            this.lblMembershipPlan.Text = "Membership Plan";
            // 
            // cmbMemberGender
            // 
            this.cmbMemberGender.FormattingEnabled = true;
            this.cmbMemberGender.Items.AddRange(new object[] {
            "Male ",
            "Female"});
            this.cmbMemberGender.Location = new System.Drawing.Point(15, 200);
            this.cmbMemberGender.Name = "cmbMemberGender";
            this.cmbMemberGender.Size = new System.Drawing.Size(200, 28);
            this.cmbMemberGender.TabIndex = 7;
            // 
            // lblGender
            // 
            this.lblGender.AutoSize = true;
            this.lblGender.Location = new System.Drawing.Point(15, 180);
            this.lblGender.Name = "lblGender";
            this.lblGender.Size = new System.Drawing.Size(57, 20);
            this.lblGender.TabIndex = 5;
            this.lblGender.Text = "Gender";
            // 
            // txtMemberName
            // 
            this.txtMemberName.Location = new System.Drawing.Point(15, 80);
            this.txtMemberName.Name = "txtMemberName";
            this.txtMemberName.Size = new System.Drawing.Size(200, 27);
            this.txtMemberName.TabIndex = 3;
            // 
            // lblPhone
            // 
            this.lblPhone.AutoSize = true;
            this.lblPhone.Location = new System.Drawing.Point(15, 120);
            this.lblPhone.Name = "lblPhone";
            this.lblPhone.Size = new System.Drawing.Size(50, 20);
            this.lblPhone.TabIndex = 2;
            this.lblPhone.Text = "Phone";
            // 
            // lblFullName
            // 
            this.lblFullName.AutoSize = true;
            this.lblFullName.Location = new System.Drawing.Point(15, 60);
            this.lblFullName.Name = "lblFullName";
            this.lblFullName.Size = new System.Drawing.Size(76, 20);
            this.lblFullName.TabIndex = 1;
            this.lblFullName.Text = "Full Name";
            // 
            // lblFormTitle
            // 
            this.lblFormTitle.AutoSize = true;
            this.lblFormTitle.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFormTitle.Location = new System.Drawing.Point(15, 12);
            this.lblFormTitle.Name = "lblFormTitle";
            this.lblFormTitle.Size = new System.Drawing.Size(151, 25);
            this.lblFormTitle.TabIndex = 0;
            this.lblFormTitle.Text = "Member Details";
            // 
            // UC_Members
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.Controls.Add(this.pnlMembersBody);
            this.Controls.Add(this.pnlHeaderMembers);
            this.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.Name = "UC_Members";
            this.Size = new System.Drawing.Size(1650, 900);
            this.Load += new System.EventHandler(this.UC_Members_Load);
            this.pnlHeaderMembers.ResumeLayout(false);
            this.pnlHeaderMembers.PerformLayout();
            this.pnlMembersBody.ResumeLayout(false);
            this.pnlMemberTable.ResumeLayout(false);
            this.pnlMemberTable.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMembers)).EndInit();
            this.pnlMemberForm.ResumeLayout(false);
            this.pnlMemberForm.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlHeaderMembers;
        private System.Windows.Forms.Label lblMembersSub;
        private System.Windows.Forms.Label lblMembersTitle;
        private System.Windows.Forms.Panel pnlMembersBody;
        private System.Windows.Forms.Panel pnlMemberForm;
        private System.Windows.Forms.Label lblPhone;
        private System.Windows.Forms.Label lblFullName;
        private System.Windows.Forms.Label lblFormTitle;
        private System.Windows.Forms.Label lblStartDate;
        private System.Windows.Forms.ComboBox cmbMemberStatus;
        private System.Windows.Forms.Label lblStatus;
        private System.Windows.Forms.ComboBox cmbMemberPlan;
        private System.Windows.Forms.Label lblMembershipPlan;
        private System.Windows.Forms.ComboBox cmbMemberGender;
        private System.Windows.Forms.Label lblGender;
        private System.Windows.Forms.TextBox txtMemberName;
        private System.Windows.Forms.Label lblEndDate;
        private System.Windows.Forms.DateTimePicker dtpMemberEnd;
        private System.Windows.Forms.DateTimePicker dtpMemberStart;
        private System.Windows.Forms.TextBox txtMemberPhone;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Panel pnlMemberTable;
        private System.Windows.Forms.DataGridView dgvMembers;
        private System.Windows.Forms.Label lblListTitle;
    }
}
