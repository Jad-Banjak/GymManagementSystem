namespace GymManagementSystem
{
    partial class UC_Machines
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
            this.pnlHeaderMachines = new System.Windows.Forms.Panel();
            this.lblMachineSub = new System.Windows.Forms.Label();
            this.lblMachinesTitle = new System.Windows.Forms.Label();
            this.pnlMachinesBody = new System.Windows.Forms.Panel();
            this.pnlMachinesTable = new System.Windows.Forms.Panel();
            this.dgvMachines = new System.Windows.Forms.DataGridView();
            this.lblMachineListTitle = new System.Windows.Forms.Label();
            this.pnlMachineForm = new System.Windows.Forms.Panel();
            this.dtpPurchaseDate = new System.Windows.Forms.DateTimePicker();
            this.cmbCategory = new System.Windows.Forms.ComboBox();
            this.btnMachineClear = new System.Windows.Forms.Button();
            this.btnMachineDelete = new System.Windows.Forms.Button();
            this.btnMachineUpdate = new System.Windows.Forms.Button();
            this.btnMachineAdd = new System.Windows.Forms.Button();
            this.cmbMachineStatus = new System.Windows.Forms.ComboBox();
            this.lblMachineStatus = new System.Windows.Forms.Label();
            this.cmbCondition = new System.Windows.Forms.ComboBox();
            this.lblCondition = new System.Windows.Forms.Label();
            this.lblPurchaseDate = new System.Windows.Forms.Label();
            this.txtMachineName = new System.Windows.Forms.TextBox();
            this.lblCategory = new System.Windows.Forms.Label();
            this.lblMachineName = new System.Windows.Forms.Label();
            this.lblMachineFormTitle = new System.Windows.Forms.Label();
            this.pnlHeaderMachines.SuspendLayout();
            this.pnlMachinesBody.SuspendLayout();
            this.pnlMachinesTable.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMachines)).BeginInit();
            this.pnlMachineForm.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlHeaderMachines
            // 
            this.pnlHeaderMachines.Controls.Add(this.lblMachineSub);
            this.pnlHeaderMachines.Controls.Add(this.lblMachinesTitle);
            this.pnlHeaderMachines.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlHeaderMachines.Location = new System.Drawing.Point(0, 0);
            this.pnlHeaderMachines.Name = "pnlHeaderMachines";
            this.pnlHeaderMachines.Size = new System.Drawing.Size(1925, 70);
            this.pnlHeaderMachines.TabIndex = 1;
            // 
            // lblMachineSub
            // 
            this.lblMachineSub.AutoSize = true;
            this.lblMachineSub.ForeColor = System.Drawing.Color.DimGray;
            this.lblMachineSub.Location = new System.Drawing.Point(22, 48);
            this.lblMachineSub.Name = "lblMachineSub";
            this.lblMachineSub.Size = new System.Drawing.Size(258, 18);
            this.lblMachineSub.TabIndex = 2;
            this.lblMachineSub.Text = "Manage gym machines and availability";
            // 
            // lblMachinesTitle
            // 
            this.lblMachinesTitle.AutoSize = true;
            this.lblMachinesTitle.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMachinesTitle.Location = new System.Drawing.Point(20, 20);
            this.lblMachinesTitle.Name = "lblMachinesTitle";
            this.lblMachinesTitle.Size = new System.Drawing.Size(138, 37);
            this.lblMachinesTitle.TabIndex = 1;
            this.lblMachinesTitle.Text = "Machines";
            // 
            // pnlMachinesBody
            // 
            this.pnlMachinesBody.Controls.Add(this.pnlMachinesTable);
            this.pnlMachinesBody.Controls.Add(this.pnlMachineForm);
            this.pnlMachinesBody.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlMachinesBody.Location = new System.Drawing.Point(0, 70);
            this.pnlMachinesBody.Name = "pnlMachinesBody";
            this.pnlMachinesBody.Size = new System.Drawing.Size(1925, 968);
            this.pnlMachinesBody.TabIndex = 2;
            // 
            // pnlMachinesTable
            // 
            this.pnlMachinesTable.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pnlMachinesTable.BackColor = System.Drawing.Color.White;
            this.pnlMachinesTable.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlMachinesTable.Controls.Add(this.dgvMachines);
            this.pnlMachinesTable.Controls.Add(this.lblMachineListTitle);
            this.pnlMachinesTable.Location = new System.Drawing.Point(400, 10);
            this.pnlMachinesTable.Name = "pnlMachinesTable";
            this.pnlMachinesTable.Size = new System.Drawing.Size(1200, 798);
            this.pnlMachinesTable.TabIndex = 1;
            // 
            // dgvMachines
            // 
            this.dgvMachines.AllowUserToAddRows = false;
            this.dgvMachines.AllowUserToDeleteRows = false;
            this.dgvMachines.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvMachines.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvMachines.BackgroundColor = System.Drawing.Color.White;
            this.dgvMachines.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvMachines.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dgvMachines.ColumnHeadersHeight = 35;
            this.dgvMachines.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dgvMachines.Location = new System.Drawing.Point(15, 85);
            this.dgvMachines.MultiSelect = false;
            this.dgvMachines.Name = "dgvMachines";
            this.dgvMachines.ReadOnly = true;
            this.dgvMachines.RowHeadersVisible = false;
            this.dgvMachines.RowHeadersWidth = 51;
            this.dgvMachines.RowTemplate.Height = 30;
            this.dgvMachines.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvMachines.Size = new System.Drawing.Size(1160, 668);
            this.dgvMachines.TabIndex = 3;
            this.dgvMachines.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvMachines_CellClick);
            // 
            // lblMachineListTitle
            // 
            this.lblMachineListTitle.AutoSize = true;
            this.lblMachineListTitle.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMachineListTitle.Location = new System.Drawing.Point(15, 12);
            this.lblMachineListTitle.Name = "lblMachineListTitle";
            this.lblMachineListTitle.Size = new System.Drawing.Size(122, 25);
            this.lblMachineListTitle.TabIndex = 0;
            this.lblMachineListTitle.Text = "Machine List";
            // 
            // pnlMachineForm
            // 
            this.pnlMachineForm.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.pnlMachineForm.BackColor = System.Drawing.Color.White;
            this.pnlMachineForm.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlMachineForm.Controls.Add(this.dtpPurchaseDate);
            this.pnlMachineForm.Controls.Add(this.cmbCategory);
            this.pnlMachineForm.Controls.Add(this.btnMachineClear);
            this.pnlMachineForm.Controls.Add(this.btnMachineDelete);
            this.pnlMachineForm.Controls.Add(this.btnMachineUpdate);
            this.pnlMachineForm.Controls.Add(this.btnMachineAdd);
            this.pnlMachineForm.Controls.Add(this.cmbMachineStatus);
            this.pnlMachineForm.Controls.Add(this.lblMachineStatus);
            this.pnlMachineForm.Controls.Add(this.cmbCondition);
            this.pnlMachineForm.Controls.Add(this.lblCondition);
            this.pnlMachineForm.Controls.Add(this.lblPurchaseDate);
            this.pnlMachineForm.Controls.Add(this.txtMachineName);
            this.pnlMachineForm.Controls.Add(this.lblCategory);
            this.pnlMachineForm.Controls.Add(this.lblMachineName);
            this.pnlMachineForm.Controls.Add(this.lblMachineFormTitle);
            this.pnlMachineForm.Location = new System.Drawing.Point(20, 10);
            this.pnlMachineForm.Name = "pnlMachineForm";
            this.pnlMachineForm.Size = new System.Drawing.Size(360, 798);
            this.pnlMachineForm.TabIndex = 0;
            // 
            // dtpPurchaseDate
            // 
            this.dtpPurchaseDate.Location = new System.Drawing.Point(16, 185);
            this.dtpPurchaseDate.Name = "dtpPurchaseDate";
            this.dtpPurchaseDate.Size = new System.Drawing.Size(200, 24);
            this.dtpPurchaseDate.TabIndex = 40;
            // 
            // cmbCategory
            // 
            this.cmbCategory.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbCategory.FormattingEnabled = true;
            this.cmbCategory.Items.AddRange(new object[] {
            "Cardio",
            "Strength",
            "Free Weights"});
            this.cmbCategory.Location = new System.Drawing.Point(16, 125);
            this.cmbCategory.Name = "cmbCategory";
            this.cmbCategory.Size = new System.Drawing.Size(200, 26);
            this.cmbCategory.TabIndex = 39;
            // 
            // btnMachineClear
            // 
            this.btnMachineClear.BackColor = System.Drawing.Color.DimGray;
            this.btnMachineClear.FlatAppearance.BorderSize = 0;
            this.btnMachineClear.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMachineClear.Location = new System.Drawing.Point(181, 633);
            this.btnMachineClear.Name = "btnMachineClear";
            this.btnMachineClear.Size = new System.Drawing.Size(150, 36);
            this.btnMachineClear.TabIndex = 38;
            this.btnMachineClear.Text = "Clear";
            this.btnMachineClear.UseVisualStyleBackColor = false;
            this.btnMachineClear.Click += new System.EventHandler(this.btnMachineClear_Click);
            // 
            // btnMachineDelete
            // 
            this.btnMachineDelete.BackColor = System.Drawing.Color.Firebrick;
            this.btnMachineDelete.FlatAppearance.BorderSize = 0;
            this.btnMachineDelete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMachineDelete.Location = new System.Drawing.Point(25, 633);
            this.btnMachineDelete.Name = "btnMachineDelete";
            this.btnMachineDelete.Size = new System.Drawing.Size(150, 36);
            this.btnMachineDelete.TabIndex = 37;
            this.btnMachineDelete.Text = "Delete";
            this.btnMachineDelete.UseVisualStyleBackColor = false;
            this.btnMachineDelete.Click += new System.EventHandler(this.btnMachineDelete_Click);
            // 
            // btnMachineUpdate
            // 
            this.btnMachineUpdate.BackColor = System.Drawing.Color.Gainsboro;
            this.btnMachineUpdate.FlatAppearance.BorderSize = 0;
            this.btnMachineUpdate.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMachineUpdate.Location = new System.Drawing.Point(181, 572);
            this.btnMachineUpdate.Name = "btnMachineUpdate";
            this.btnMachineUpdate.Size = new System.Drawing.Size(150, 36);
            this.btnMachineUpdate.TabIndex = 36;
            this.btnMachineUpdate.Text = "Update";
            this.btnMachineUpdate.UseVisualStyleBackColor = false;
            this.btnMachineUpdate.Click += new System.EventHandler(this.btnMachineUpdate_Click);
            // 
            // btnMachineAdd
            // 
            this.btnMachineAdd.BackColor = System.Drawing.Color.RoyalBlue;
            this.btnMachineAdd.FlatAppearance.BorderSize = 0;
            this.btnMachineAdd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMachineAdd.Location = new System.Drawing.Point(25, 572);
            this.btnMachineAdd.Name = "btnMachineAdd";
            this.btnMachineAdd.Size = new System.Drawing.Size(150, 36);
            this.btnMachineAdd.TabIndex = 35;
            this.btnMachineAdd.Text = "Add";
            this.btnMachineAdd.UseVisualStyleBackColor = false;
            this.btnMachineAdd.Click += new System.EventHandler(this.btnMachineAdd_Click);
            // 
            // cmbMachineStatus
            // 
            this.cmbMachineStatus.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbMachineStatus.FormattingEnabled = true;
            this.cmbMachineStatus.Items.AddRange(new object[] {
            "Active",
            "Inactive",
            "Maintenance"});
            this.cmbMachineStatus.Location = new System.Drawing.Point(16, 307);
            this.cmbMachineStatus.Name = "cmbMachineStatus";
            this.cmbMachineStatus.Size = new System.Drawing.Size(200, 26);
            this.cmbMachineStatus.TabIndex = 29;
            // 
            // lblMachineStatus
            // 
            this.lblMachineStatus.AutoSize = true;
            this.lblMachineStatus.Location = new System.Drawing.Point(16, 287);
            this.lblMachineStatus.Name = "lblMachineStatus";
            this.lblMachineStatus.Size = new System.Drawing.Size(50, 18);
            this.lblMachineStatus.TabIndex = 28;
            this.lblMachineStatus.Text = "Status";
            // 
            // cmbCondition
            // 
            this.cmbCondition.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbCondition.FormattingEnabled = true;
            this.cmbCondition.Items.AddRange(new object[] {
            "Good",
            "Excellent",
            "Needs Maintenance",
            "Out of Order"});
            this.cmbCondition.Location = new System.Drawing.Point(16, 247);
            this.cmbCondition.Name = "cmbCondition";
            this.cmbCondition.Size = new System.Drawing.Size(200, 26);
            this.cmbCondition.TabIndex = 27;
            // 
            // lblCondition
            // 
            this.lblCondition.AutoSize = true;
            this.lblCondition.Location = new System.Drawing.Point(16, 227);
            this.lblCondition.Name = "lblCondition";
            this.lblCondition.Size = new System.Drawing.Size(71, 18);
            this.lblCondition.TabIndex = 26;
            this.lblCondition.Text = "Condition";
            // 
            // lblPurchaseDate
            // 
            this.lblPurchaseDate.AutoSize = true;
            this.lblPurchaseDate.Location = new System.Drawing.Point(16, 167);
            this.lblPurchaseDate.Name = "lblPurchaseDate";
            this.lblPurchaseDate.Size = new System.Drawing.Size(110, 18);
            this.lblPurchaseDate.TabIndex = 24;
            this.lblPurchaseDate.Text = "Purchase Date ";
            // 
            // txtMachineName
            // 
            this.txtMachineName.Location = new System.Drawing.Point(16, 67);
            this.txtMachineName.Name = "txtMachineName";
            this.txtMachineName.Size = new System.Drawing.Size(200, 24);
            this.txtMachineName.TabIndex = 23;
            // 
            // lblCategory
            // 
            this.lblCategory.AutoSize = true;
            this.lblCategory.Location = new System.Drawing.Point(16, 107);
            this.lblCategory.Name = "lblCategory";
            this.lblCategory.Size = new System.Drawing.Size(68, 18);
            this.lblCategory.TabIndex = 22;
            this.lblCategory.Text = "Category";
            // 
            // lblMachineName
            // 
            this.lblMachineName.AutoSize = true;
            this.lblMachineName.Location = new System.Drawing.Point(16, 47);
            this.lblMachineName.Name = "lblMachineName";
            this.lblMachineName.Size = new System.Drawing.Size(108, 18);
            this.lblMachineName.TabIndex = 21;
            this.lblMachineName.Text = "Machine Name";
            // 
            // lblMachineFormTitle
            // 
            this.lblMachineFormTitle.AutoSize = true;
            this.lblMachineFormTitle.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMachineFormTitle.Location = new System.Drawing.Point(15, 12);
            this.lblMachineFormTitle.Name = "lblMachineFormTitle";
            this.lblMachineFormTitle.Size = new System.Drawing.Size(151, 25);
            this.lblMachineFormTitle.TabIndex = 0;
            this.lblMachineFormTitle.Text = "Machine Details";
            // 
            // UC_Machines
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.Controls.Add(this.pnlMachinesBody);
            this.Controls.Add(this.pnlHeaderMachines);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.Name = "UC_Machines";
            this.Size = new System.Drawing.Size(1925, 1038);
            this.Load += new System.EventHandler(this.UC_Machines_Load);
            this.pnlHeaderMachines.ResumeLayout(false);
            this.pnlHeaderMachines.PerformLayout();
            this.pnlMachinesBody.ResumeLayout(false);
            this.pnlMachinesTable.ResumeLayout(false);
            this.pnlMachinesTable.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMachines)).EndInit();
            this.pnlMachineForm.ResumeLayout(false);
            this.pnlMachineForm.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlHeaderMachines;
        private System.Windows.Forms.Label lblMachineSub;
        private System.Windows.Forms.Label lblMachinesTitle;
        private System.Windows.Forms.Panel pnlMachinesBody;
        private System.Windows.Forms.Panel pnlMachineForm;
        private System.Windows.Forms.Label lblMachineFormTitle;
        private System.Windows.Forms.ComboBox cmbCategory;
        private System.Windows.Forms.Button btnMachineClear;
        private System.Windows.Forms.Button btnMachineDelete;
        private System.Windows.Forms.Button btnMachineUpdate;
        private System.Windows.Forms.Button btnMachineAdd;
        private System.Windows.Forms.ComboBox cmbMachineStatus;
        private System.Windows.Forms.Label lblMachineStatus;
        private System.Windows.Forms.ComboBox cmbCondition;
        private System.Windows.Forms.Label lblCondition;
        private System.Windows.Forms.Label lblPurchaseDate;
        private System.Windows.Forms.TextBox txtMachineName;
        private System.Windows.Forms.Label lblCategory;
        private System.Windows.Forms.Label lblMachineName;
        private System.Windows.Forms.DateTimePicker dtpPurchaseDate;
        private System.Windows.Forms.Panel pnlMachinesTable;
        private System.Windows.Forms.Label lblMachineListTitle;
        private System.Windows.Forms.DataGridView dgvMachines;
    }
}
