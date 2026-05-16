namespace GymManagementSystem
{
    partial class UC_Memberships
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
            this.pnlHeaderMemberships = new System.Windows.Forms.Panel();
            this.lblMembershipsSub = new System.Windows.Forms.Label();
            this.lblMembershipsTitle = new System.Windows.Forms.Label();
            this.pnlMembershipsBody = new System.Windows.Forms.Panel();
            this.pnlPlansTable = new System.Windows.Forms.Panel();
            this.dgvMemberships = new System.Windows.Forms.DataGridView();
            this.pnlPlanForm = new System.Windows.Forms.Panel();
            this.btnPlanClear = new System.Windows.Forms.Button();
            this.btnPlanDelete = new System.Windows.Forms.Button();
            this.btnPlanUpdate = new System.Windows.Forms.Button();
            this.btnPlanAdd = new System.Windows.Forms.Button();
            this.cmbPlanStatus = new System.Windows.Forms.ComboBox();
            this.lblIsActive = new System.Windows.Forms.Label();
            this.txtPlanDescription = new System.Windows.Forms.TextBox();
            this.numPlanPrice = new System.Windows.Forms.NumericUpDown();
            this.lblDescription = new System.Windows.Forms.Label();
            this.lblPrice = new System.Windows.Forms.Label();
            this.numDurationMonths = new System.Windows.Forms.NumericUpDown();
            this.lblDurationMonths = new System.Windows.Forms.Label();
            this.txtPlanName = new System.Windows.Forms.TextBox();
            this.lblPlanName = new System.Windows.Forms.Label();
            this.lblPlanFormTitle = new System.Windows.Forms.Label();
            this.pnlHeaderMemberships.SuspendLayout();
            this.pnlMembershipsBody.SuspendLayout();
            this.pnlPlansTable.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMemberships)).BeginInit();
            this.pnlPlanForm.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numPlanPrice)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numDurationMonths)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlHeaderMemberships
            // 
            this.pnlHeaderMemberships.Controls.Add(this.lblMembershipsSub);
            this.pnlHeaderMemberships.Controls.Add(this.lblMembershipsTitle);
            this.pnlHeaderMemberships.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlHeaderMemberships.Location = new System.Drawing.Point(0, 0);
            this.pnlHeaderMemberships.Name = "pnlHeaderMemberships";
            this.pnlHeaderMemberships.Size = new System.Drawing.Size(1650, 70);
            this.pnlHeaderMemberships.TabIndex = 0;
            // 
            // lblMembershipsSub
            // 
            this.lblMembershipsSub.AutoSize = true;
            this.lblMembershipsSub.ForeColor = System.Drawing.Color.DimGray;
            this.lblMembershipsSub.Location = new System.Drawing.Point(22, 48);
            this.lblMembershipsSub.Name = "lblMembershipsSub";
            this.lblMembershipsSub.Size = new System.Drawing.Size(351, 20);
            this.lblMembershipsSub.TabIndex = 2;
            this.lblMembershipsSub.Text = "Create and manage membership plans and pricing. ";
            // 
            // lblMembershipsTitle
            // 
            this.lblMembershipsTitle.AutoSize = true;
            this.lblMembershipsTitle.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMembershipsTitle.Location = new System.Drawing.Point(20, 20);
            this.lblMembershipsTitle.Name = "lblMembershipsTitle";
            this.lblMembershipsTitle.Size = new System.Drawing.Size(254, 37);
            this.lblMembershipsTitle.TabIndex = 1;
            this.lblMembershipsTitle.Text = "Membership Plans";
            // 
            // pnlMembershipsBody
            // 
            this.pnlMembershipsBody.Controls.Add(this.pnlPlansTable);
            this.pnlMembershipsBody.Controls.Add(this.pnlPlanForm);
            this.pnlMembershipsBody.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlMembershipsBody.Location = new System.Drawing.Point(0, 70);
            this.pnlMembershipsBody.Name = "pnlMembershipsBody";
            this.pnlMembershipsBody.Size = new System.Drawing.Size(1650, 830);
            this.pnlMembershipsBody.TabIndex = 1;
            // 
            // pnlPlansTable
            // 
            this.pnlPlansTable.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pnlPlansTable.BackColor = System.Drawing.Color.White;
            this.pnlPlansTable.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlPlansTable.Controls.Add(this.dgvMemberships);
            this.pnlPlansTable.Location = new System.Drawing.Point(400, 10);
            this.pnlPlansTable.Name = "pnlPlansTable";
            this.pnlPlansTable.Size = new System.Drawing.Size(1200, 650);
            this.pnlPlansTable.TabIndex = 1;
            // 
            // dgvMemberships
            // 
            this.dgvMemberships.AllowUserToAddRows = false;
            this.dgvMemberships.AllowUserToDeleteRows = false;
            this.dgvMemberships.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvMemberships.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvMemberships.BackgroundColor = System.Drawing.Color.White;
            this.dgvMemberships.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvMemberships.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dgvMemberships.ColumnHeadersHeight = 35;
            this.dgvMemberships.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dgvMemberships.Location = new System.Drawing.Point(15, 85);
            this.dgvMemberships.MultiSelect = false;
            this.dgvMemberships.Name = "dgvMemberships";
            this.dgvMemberships.ReadOnly = true;
            this.dgvMemberships.RowHeadersVisible = false;
            this.dgvMemberships.RowHeadersWidth = 51;
            this.dgvMemberships.RowTemplate.Height = 30;
            this.dgvMemberships.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvMemberships.Size = new System.Drawing.Size(1160, 520);
            this.dgvMemberships.TabIndex = 2;
            this.dgvMemberships.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvMemberships_CellClick);
            // 
            // pnlPlanForm
            // 
            this.pnlPlanForm.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.pnlPlanForm.BackColor = System.Drawing.Color.White;
            this.pnlPlanForm.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlPlanForm.Controls.Add(this.btnPlanClear);
            this.pnlPlanForm.Controls.Add(this.btnPlanDelete);
            this.pnlPlanForm.Controls.Add(this.btnPlanUpdate);
            this.pnlPlanForm.Controls.Add(this.btnPlanAdd);
            this.pnlPlanForm.Controls.Add(this.cmbPlanStatus);
            this.pnlPlanForm.Controls.Add(this.lblIsActive);
            this.pnlPlanForm.Controls.Add(this.txtPlanDescription);
            this.pnlPlanForm.Controls.Add(this.numPlanPrice);
            this.pnlPlanForm.Controls.Add(this.lblDescription);
            this.pnlPlanForm.Controls.Add(this.lblPrice);
            this.pnlPlanForm.Controls.Add(this.numDurationMonths);
            this.pnlPlanForm.Controls.Add(this.lblDurationMonths);
            this.pnlPlanForm.Controls.Add(this.txtPlanName);
            this.pnlPlanForm.Controls.Add(this.lblPlanName);
            this.pnlPlanForm.Controls.Add(this.lblPlanFormTitle);
            this.pnlPlanForm.Location = new System.Drawing.Point(20, 10);
            this.pnlPlanForm.Name = "pnlPlanForm";
            this.pnlPlanForm.Size = new System.Drawing.Size(360, 650);
            this.pnlPlanForm.TabIndex = 0;
            // 
            // btnPlanClear
            // 
            this.btnPlanClear.BackColor = System.Drawing.Color.DimGray;
            this.btnPlanClear.FlatAppearance.BorderSize = 0;
            this.btnPlanClear.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPlanClear.Location = new System.Drawing.Point(175, 496);
            this.btnPlanClear.Name = "btnPlanClear";
            this.btnPlanClear.Size = new System.Drawing.Size(150, 36);
            this.btnPlanClear.TabIndex = 24;
            this.btnPlanClear.Text = "Clear";
            this.btnPlanClear.UseVisualStyleBackColor = false;
            this.btnPlanClear.Click += new System.EventHandler(this.btnPlanClear_Click);
            // 
            // btnPlanDelete
            // 
            this.btnPlanDelete.BackColor = System.Drawing.Color.Firebrick;
            this.btnPlanDelete.FlatAppearance.BorderSize = 0;
            this.btnPlanDelete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPlanDelete.Location = new System.Drawing.Point(19, 496);
            this.btnPlanDelete.Name = "btnPlanDelete";
            this.btnPlanDelete.Size = new System.Drawing.Size(150, 36);
            this.btnPlanDelete.TabIndex = 23;
            this.btnPlanDelete.Text = "Delete";
            this.btnPlanDelete.UseVisualStyleBackColor = false;
            this.btnPlanDelete.Click += new System.EventHandler(this.btnPlanDelete_Click);
            // 
            // btnPlanUpdate
            // 
            this.btnPlanUpdate.BackColor = System.Drawing.Color.Gainsboro;
            this.btnPlanUpdate.FlatAppearance.BorderSize = 0;
            this.btnPlanUpdate.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPlanUpdate.Location = new System.Drawing.Point(175, 435);
            this.btnPlanUpdate.Name = "btnPlanUpdate";
            this.btnPlanUpdate.Size = new System.Drawing.Size(150, 36);
            this.btnPlanUpdate.TabIndex = 22;
            this.btnPlanUpdate.Text = "Update";
            this.btnPlanUpdate.UseVisualStyleBackColor = false;
            this.btnPlanUpdate.Click += new System.EventHandler(this.btnPlanUpdate_Click);
            // 
            // btnPlanAdd
            // 
            this.btnPlanAdd.BackColor = System.Drawing.Color.RoyalBlue;
            this.btnPlanAdd.FlatAppearance.BorderSize = 0;
            this.btnPlanAdd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPlanAdd.Location = new System.Drawing.Point(19, 435);
            this.btnPlanAdd.Name = "btnPlanAdd";
            this.btnPlanAdd.Size = new System.Drawing.Size(150, 36);
            this.btnPlanAdd.TabIndex = 21;
            this.btnPlanAdd.Text = "Add";
            this.btnPlanAdd.UseVisualStyleBackColor = false;
            this.btnPlanAdd.Click += new System.EventHandler(this.btnPlanAdd_Click);
            // 
            // cmbPlanStatus
            // 
            this.cmbPlanStatus.FormattingEnabled = true;
            this.cmbPlanStatus.Items.AddRange(new object[] {
            "Active",
            "Inactive"});
            this.cmbPlanStatus.Location = new System.Drawing.Point(15, 390);
            this.cmbPlanStatus.Name = "cmbPlanStatus";
            this.cmbPlanStatus.Size = new System.Drawing.Size(121, 28);
            this.cmbPlanStatus.TabIndex = 15;
            // 
            // lblIsActive
            // 
            this.lblIsActive.AutoSize = true;
            this.lblIsActive.Location = new System.Drawing.Point(15, 370);
            this.lblIsActive.Name = "lblIsActive";
            this.lblIsActive.Size = new System.Drawing.Size(49, 20);
            this.lblIsActive.TabIndex = 13;
            this.lblIsActive.Text = "Status";
            // 
            // txtPlanDescription
            // 
            this.txtPlanDescription.Location = new System.Drawing.Point(15, 260);
            this.txtPlanDescription.Multiline = true;
            this.txtPlanDescription.Name = "txtPlanDescription";
            this.txtPlanDescription.Size = new System.Drawing.Size(320, 90);
            this.txtPlanDescription.TabIndex = 12;
            // 
            // numPlanPrice
            // 
            this.numPlanPrice.DecimalPlaces = 2;
            this.numPlanPrice.Location = new System.Drawing.Point(15, 200);
            this.numPlanPrice.Maximum = new decimal(new int[] {
            1000000,
            0,
            0,
            0});
            this.numPlanPrice.Name = "numPlanPrice";
            this.numPlanPrice.Size = new System.Drawing.Size(120, 27);
            this.numPlanPrice.TabIndex = 11;
            this.numPlanPrice.ThousandsSeparator = true;
            // 
            // lblDescription
            // 
            this.lblDescription.AutoSize = true;
            this.lblDescription.Location = new System.Drawing.Point(15, 240);
            this.lblDescription.Name = "lblDescription";
            this.lblDescription.Size = new System.Drawing.Size(85, 20);
            this.lblDescription.TabIndex = 10;
            this.lblDescription.Text = "Description";
            // 
            // lblPrice
            // 
            this.lblPrice.AutoSize = true;
            this.lblPrice.Location = new System.Drawing.Point(15, 180);
            this.lblPrice.Name = "lblPrice";
            this.lblPrice.Size = new System.Drawing.Size(41, 20);
            this.lblPrice.TabIndex = 9;
            this.lblPrice.Text = "Price";
            // 
            // numDurationMonths
            // 
            this.numDurationMonths.Location = new System.Drawing.Point(15, 140);
            this.numDurationMonths.Maximum = new decimal(new int[] {
            36,
            0,
            0,
            0});
            this.numDurationMonths.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numDurationMonths.Name = "numDurationMonths";
            this.numDurationMonths.Size = new System.Drawing.Size(120, 27);
            this.numDurationMonths.TabIndex = 8;
            this.numDurationMonths.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // lblDurationMonths
            // 
            this.lblDurationMonths.AutoSize = true;
            this.lblDurationMonths.Location = new System.Drawing.Point(15, 120);
            this.lblDurationMonths.Name = "lblDurationMonths";
            this.lblDurationMonths.Size = new System.Drawing.Size(130, 20);
            this.lblDurationMonths.TabIndex = 5;
            this.lblDurationMonths.Text = "Duration (Months)";
            // 
            // txtPlanName
            // 
            this.txtPlanName.Location = new System.Drawing.Point(15, 80);
            this.txtPlanName.Name = "txtPlanName";
            this.txtPlanName.Size = new System.Drawing.Size(120, 27);
            this.txtPlanName.TabIndex = 2;
            // 
            // lblPlanName
            // 
            this.lblPlanName.AutoSize = true;
            this.lblPlanName.Location = new System.Drawing.Point(15, 60);
            this.lblPlanName.Name = "lblPlanName";
            this.lblPlanName.Size = new System.Drawing.Size(81, 20);
            this.lblPlanName.TabIndex = 1;
            this.lblPlanName.Text = "Plan Name";
            // 
            // lblPlanFormTitle
            // 
            this.lblPlanFormTitle.AutoSize = true;
            this.lblPlanFormTitle.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPlanFormTitle.Location = new System.Drawing.Point(15, 12);
            this.lblPlanFormTitle.Name = "lblPlanFormTitle";
            this.lblPlanFormTitle.Size = new System.Drawing.Size(115, 25);
            this.lblPlanFormTitle.TabIndex = 0;
            this.lblPlanFormTitle.Text = "Plan Details";
            // 
            // UC_Memberships
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.Controls.Add(this.pnlMembershipsBody);
            this.Controls.Add(this.pnlHeaderMemberships);
            this.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.Name = "UC_Memberships";
            this.Size = new System.Drawing.Size(1650, 900);
            this.Load += new System.EventHandler(this.UC_Memberships_Load);
            this.pnlHeaderMemberships.ResumeLayout(false);
            this.pnlHeaderMemberships.PerformLayout();
            this.pnlMembershipsBody.ResumeLayout(false);
            this.pnlPlansTable.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvMemberships)).EndInit();
            this.pnlPlanForm.ResumeLayout(false);
            this.pnlPlanForm.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numPlanPrice)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numDurationMonths)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlHeaderMemberships;
        private System.Windows.Forms.Label lblMembershipsSub;
        private System.Windows.Forms.Label lblMembershipsTitle;
        private System.Windows.Forms.Panel pnlMembershipsBody;
        private System.Windows.Forms.Panel pnlPlanForm;
        private System.Windows.Forms.Label lblPlanName;
        private System.Windows.Forms.Label lblPlanFormTitle;
        private System.Windows.Forms.Label lblDurationMonths;
        private System.Windows.Forms.TextBox txtPlanName;
        private System.Windows.Forms.NumericUpDown numDurationMonths;
        private System.Windows.Forms.Label lblDescription;
        private System.Windows.Forms.Label lblPrice;
        private System.Windows.Forms.NumericUpDown numPlanPrice;
        private System.Windows.Forms.Label lblIsActive;
        private System.Windows.Forms.TextBox txtPlanDescription;
        private System.Windows.Forms.ComboBox cmbPlanStatus;
        private System.Windows.Forms.Button btnPlanClear;
        private System.Windows.Forms.Button btnPlanDelete;
        private System.Windows.Forms.Button btnPlanUpdate;
        private System.Windows.Forms.Button btnPlanAdd;
        private System.Windows.Forms.Panel pnlPlansTable;
        private System.Windows.Forms.DataGridView dgvMemberships;
    }
}
