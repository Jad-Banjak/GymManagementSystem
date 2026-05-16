namespace GymManagementSystem
{
    partial class UC_Payments
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
            this.pnlHeaderPayments = new System.Windows.Forms.Panel();
            this.lblPaymentsSub = new System.Windows.Forms.Label();
            this.lblPaymentsTitle = new System.Windows.Forms.Label();
            this.pnlPaymentsBody = new System.Windows.Forms.Panel();
            this.pnlPaymentsTable = new System.Windows.Forms.Panel();
            this.dgvPayments = new System.Windows.Forms.DataGridView();
            this.lblPaymentsListTitle = new System.Windows.Forms.Label();
            this.pnlPaymentEntry = new System.Windows.Forms.Panel();
            this.btnPayClear = new System.Windows.Forms.Button();
            this.btnPayAdd = new System.Windows.Forms.Button();
            this.cmbPayStatus = new System.Windows.Forms.ComboBox();
            this.lblPayStatus = new System.Windows.Forms.Label();
            this.numPayAmount = new System.Windows.Forms.NumericUpDown();
            this.lblPayAmount = new System.Windows.Forms.Label();
            this.dtpPayDate = new System.Windows.Forms.DateTimePicker();
            this.lblPayDate = new System.Windows.Forms.Label();
            this.txtPayPlan = new System.Windows.Forms.TextBox();
            this.lblPayPlan = new System.Windows.Forms.Label();
            this.cmbPayMember = new System.Windows.Forms.ComboBox();
            this.lblPayMember = new System.Windows.Forms.Label();
            this.lblPaymentEntryTitle = new System.Windows.Forms.Label();
            this.pnlHeaderPayments.SuspendLayout();
            this.pnlPaymentsBody.SuspendLayout();
            this.pnlPaymentsTable.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPayments)).BeginInit();
            this.pnlPaymentEntry.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numPayAmount)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlHeaderPayments
            // 
            this.pnlHeaderPayments.Controls.Add(this.lblPaymentsSub);
            this.pnlHeaderPayments.Controls.Add(this.lblPaymentsTitle);
            this.pnlHeaderPayments.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlHeaderPayments.Location = new System.Drawing.Point(0, 0);
            this.pnlHeaderPayments.Name = "pnlHeaderPayments";
            this.pnlHeaderPayments.Size = new System.Drawing.Size(1650, 70);
            this.pnlHeaderPayments.TabIndex = 1;
            // 
            // lblPaymentsSub
            // 
            this.lblPaymentsSub.AutoSize = true;
            this.lblPaymentsSub.ForeColor = System.Drawing.Color.DimGray;
            this.lblPaymentsSub.Location = new System.Drawing.Point(22, 48);
            this.lblPaymentsSub.Name = "lblPaymentsSub";
            this.lblPaymentsSub.Size = new System.Drawing.Size(387, 20);
            this.lblPaymentsSub.TabIndex = 2;
            this.lblPaymentsSub.Text = "Record membership payments and view payment history.";
            // 
            // lblPaymentsTitle
            // 
            this.lblPaymentsTitle.AutoSize = true;
            this.lblPaymentsTitle.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPaymentsTitle.Location = new System.Drawing.Point(20, 20);
            this.lblPaymentsTitle.Name = "lblPaymentsTitle";
            this.lblPaymentsTitle.Size = new System.Drawing.Size(142, 37);
            this.lblPaymentsTitle.TabIndex = 1;
            this.lblPaymentsTitle.Text = "Payments";
            // 
            // pnlPaymentsBody
            // 
            this.pnlPaymentsBody.Controls.Add(this.pnlPaymentsTable);
            this.pnlPaymentsBody.Controls.Add(this.pnlPaymentEntry);
            this.pnlPaymentsBody.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlPaymentsBody.Location = new System.Drawing.Point(0, 70);
            this.pnlPaymentsBody.Name = "pnlPaymentsBody";
            this.pnlPaymentsBody.Size = new System.Drawing.Size(1650, 830);
            this.pnlPaymentsBody.TabIndex = 3;
            // 
            // pnlPaymentsTable
            // 
            this.pnlPaymentsTable.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pnlPaymentsTable.BackColor = System.Drawing.Color.White;
            this.pnlPaymentsTable.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlPaymentsTable.Controls.Add(this.dgvPayments);
            this.pnlPaymentsTable.Controls.Add(this.lblPaymentsListTitle);
            this.pnlPaymentsTable.Location = new System.Drawing.Point(20, 240);
            this.pnlPaymentsTable.Name = "pnlPaymentsTable";
            this.pnlPaymentsTable.Size = new System.Drawing.Size(1580, 580);
            this.pnlPaymentsTable.TabIndex = 4;
            // 
            // dgvPayments
            // 
            this.dgvPayments.AllowUserToAddRows = false;
            this.dgvPayments.AllowUserToDeleteRows = false;
            this.dgvPayments.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvPayments.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvPayments.BackgroundColor = System.Drawing.Color.White;
            this.dgvPayments.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvPayments.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dgvPayments.ColumnHeadersHeight = 35;
            this.dgvPayments.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dgvPayments.Location = new System.Drawing.Point(15, 85);
            this.dgvPayments.MultiSelect = false;
            this.dgvPayments.Name = "dgvPayments";
            this.dgvPayments.ReadOnly = true;
            this.dgvPayments.RowHeadersVisible = false;
            this.dgvPayments.RowHeadersWidth = 51;
            this.dgvPayments.RowTemplate.Height = 30;
            this.dgvPayments.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvPayments.Size = new System.Drawing.Size(1550, 475);
            this.dgvPayments.TabIndex = 3;
            // 
            // lblPaymentsListTitle
            // 
            this.lblPaymentsListTitle.AutoSize = true;
            this.lblPaymentsListTitle.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPaymentsListTitle.Location = new System.Drawing.Point(15, 12);
            this.lblPaymentsListTitle.Name = "lblPaymentsListTitle";
            this.lblPaymentsListTitle.Size = new System.Drawing.Size(169, 25);
            this.lblPaymentsListTitle.TabIndex = 0;
            this.lblPaymentsListTitle.Text = "Payments History";
            // 
            // pnlPaymentEntry
            // 
            this.pnlPaymentEntry.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pnlPaymentEntry.BackColor = System.Drawing.Color.White;
            this.pnlPaymentEntry.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlPaymentEntry.Controls.Add(this.btnPayClear);
            this.pnlPaymentEntry.Controls.Add(this.btnPayAdd);
            this.pnlPaymentEntry.Controls.Add(this.cmbPayStatus);
            this.pnlPaymentEntry.Controls.Add(this.lblPayStatus);
            this.pnlPaymentEntry.Controls.Add(this.numPayAmount);
            this.pnlPaymentEntry.Controls.Add(this.lblPayAmount);
            this.pnlPaymentEntry.Controls.Add(this.dtpPayDate);
            this.pnlPaymentEntry.Controls.Add(this.lblPayDate);
            this.pnlPaymentEntry.Controls.Add(this.txtPayPlan);
            this.pnlPaymentEntry.Controls.Add(this.lblPayPlan);
            this.pnlPaymentEntry.Controls.Add(this.cmbPayMember);
            this.pnlPaymentEntry.Controls.Add(this.lblPayMember);
            this.pnlPaymentEntry.Controls.Add(this.lblPaymentEntryTitle);
            this.pnlPaymentEntry.Location = new System.Drawing.Point(20, 10);
            this.pnlPaymentEntry.Name = "pnlPaymentEntry";
            this.pnlPaymentEntry.Size = new System.Drawing.Size(1580, 220);
            this.pnlPaymentEntry.TabIndex = 3;
            // 
            // btnPayClear
            // 
            this.btnPayClear.BackColor = System.Drawing.Color.DimGray;
            this.btnPayClear.FlatAppearance.BorderSize = 0;
            this.btnPayClear.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPayClear.Location = new System.Drawing.Point(1390, 117);
            this.btnPayClear.Name = "btnPayClear";
            this.btnPayClear.Size = new System.Drawing.Size(150, 36);
            this.btnPayClear.TabIndex = 25;
            this.btnPayClear.Text = "Clear";
            this.btnPayClear.UseVisualStyleBackColor = false;
            this.btnPayClear.Click += new System.EventHandler(this.btnPayClear_Click);
            // 
            // btnPayAdd
            // 
            this.btnPayAdd.BackColor = System.Drawing.Color.RoyalBlue;
            this.btnPayAdd.FlatAppearance.BorderSize = 0;
            this.btnPayAdd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPayAdd.Location = new System.Drawing.Point(1390, 57);
            this.btnPayAdd.Name = "btnPayAdd";
            this.btnPayAdd.Size = new System.Drawing.Size(150, 36);
            this.btnPayAdd.TabIndex = 22;
            this.btnPayAdd.Text = "Add";
            this.btnPayAdd.UseVisualStyleBackColor = false;
            this.btnPayAdd.Click += new System.EventHandler(this.btnPayAdd_Click);
            // 
            // cmbPayStatus
            // 
            this.cmbPayStatus.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbPayStatus.FormattingEnabled = true;
            this.cmbPayStatus.Items.AddRange(new object[] {
            "Paid",
            "Pending",
            "Cancelled"});
            this.cmbPayStatus.Location = new System.Drawing.Point(820, 125);
            this.cmbPayStatus.Name = "cmbPayStatus";
            this.cmbPayStatus.Size = new System.Drawing.Size(320, 28);
            this.cmbPayStatus.TabIndex = 11;
            // 
            // lblPayStatus
            // 
            this.lblPayStatus.AutoSize = true;
            this.lblPayStatus.Location = new System.Drawing.Point(820, 105);
            this.lblPayStatus.Name = "lblPayStatus";
            this.lblPayStatus.Size = new System.Drawing.Size(49, 20);
            this.lblPayStatus.TabIndex = 10;
            this.lblPayStatus.Text = "Status";
            // 
            // numPayAmount
            // 
            this.numPayAmount.DecimalPlaces = 2;
            this.numPayAmount.Location = new System.Drawing.Point(820, 65);
            this.numPayAmount.Maximum = new decimal(new int[] {
            1000000,
            0,
            0,
            0});
            this.numPayAmount.Name = "numPayAmount";
            this.numPayAmount.Size = new System.Drawing.Size(320, 27);
            this.numPayAmount.TabIndex = 9;
            this.numPayAmount.ThousandsSeparator = true;
            // 
            // lblPayAmount
            // 
            this.lblPayAmount.AutoSize = true;
            this.lblPayAmount.Location = new System.Drawing.Point(820, 45);
            this.lblPayAmount.Name = "lblPayAmount";
            this.lblPayAmount.Size = new System.Drawing.Size(62, 20);
            this.lblPayAmount.TabIndex = 7;
            this.lblPayAmount.Text = "Amount";
            // 
            // dtpPayDate
            // 
            this.dtpPayDate.Location = new System.Drawing.Point(15, 185);
            this.dtpPayDate.Name = "dtpPayDate";
            this.dtpPayDate.Size = new System.Drawing.Size(320, 27);
            this.dtpPayDate.TabIndex = 6;
            // 
            // lblPayDate
            // 
            this.lblPayDate.AutoSize = true;
            this.lblPayDate.Location = new System.Drawing.Point(15, 165);
            this.lblPayDate.Name = "lblPayDate";
            this.lblPayDate.Size = new System.Drawing.Size(101, 20);
            this.lblPayDate.TabIndex = 5;
            this.lblPayDate.Text = "Payment Date";
            // 
            // txtPayPlan
            // 
            this.txtPayPlan.Location = new System.Drawing.Point(15, 125);
            this.txtPayPlan.Name = "txtPayPlan";
            this.txtPayPlan.ReadOnly = true;
            this.txtPayPlan.Size = new System.Drawing.Size(320, 27);
            this.txtPayPlan.TabIndex = 4;
            // 
            // lblPayPlan
            // 
            this.lblPayPlan.AutoSize = true;
            this.lblPayPlan.Location = new System.Drawing.Point(15, 105);
            this.lblPayPlan.Name = "lblPayPlan";
            this.lblPayPlan.Size = new System.Drawing.Size(37, 20);
            this.lblPayPlan.TabIndex = 3;
            this.lblPayPlan.Text = "Plan";
            // 
            // cmbPayMember
            // 
            this.cmbPayMember.FormattingEnabled = true;
            this.cmbPayMember.Location = new System.Drawing.Point(15, 65);
            this.cmbPayMember.Name = "cmbPayMember";
            this.cmbPayMember.Size = new System.Drawing.Size(320, 28);
            this.cmbPayMember.TabIndex = 2;
            this.cmbPayMember.SelectedIndexChanged += new System.EventHandler(this.cmbPayMember_SelectedIndexChanged);
            // 
            // lblPayMember
            // 
            this.lblPayMember.AutoSize = true;
            this.lblPayMember.Location = new System.Drawing.Point(15, 45);
            this.lblPayMember.Name = "lblPayMember";
            this.lblPayMember.Size = new System.Drawing.Size(65, 20);
            this.lblPayMember.TabIndex = 1;
            this.lblPayMember.Text = "Member";
            // 
            // lblPaymentEntryTitle
            // 
            this.lblPaymentEntryTitle.AutoSize = true;
            this.lblPaymentEntryTitle.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPaymentEntryTitle.Location = new System.Drawing.Point(15, 12);
            this.lblPaymentEntryTitle.Name = "lblPaymentEntryTitle";
            this.lblPaymentEntryTitle.Size = new System.Drawing.Size(158, 25);
            this.lblPaymentEntryTitle.TabIndex = 0;
            this.lblPaymentEntryTitle.Text = "Record Payment";
            // 
            // UC_Payments
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.Controls.Add(this.pnlPaymentsBody);
            this.Controls.Add(this.pnlHeaderPayments);
            this.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.Name = "UC_Payments";
            this.Size = new System.Drawing.Size(1650, 900);
            this.Load += new System.EventHandler(this.UC_Payments_Load);
            this.pnlHeaderPayments.ResumeLayout(false);
            this.pnlHeaderPayments.PerformLayout();
            this.pnlPaymentsBody.ResumeLayout(false);
            this.pnlPaymentsTable.ResumeLayout(false);
            this.pnlPaymentsTable.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPayments)).EndInit();
            this.pnlPaymentEntry.ResumeLayout(false);
            this.pnlPaymentEntry.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numPayAmount)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlHeaderPayments;
        private System.Windows.Forms.Label lblPaymentsSub;
        private System.Windows.Forms.Label lblPaymentsTitle;
        private System.Windows.Forms.Panel pnlPaymentsBody;
        private System.Windows.Forms.Panel pnlPaymentEntry;
        private System.Windows.Forms.Label lblPayMember;
        private System.Windows.Forms.Label lblPaymentEntryTitle;
        private System.Windows.Forms.Label lblPayPlan;
        private System.Windows.Forms.ComboBox cmbPayMember;
        private System.Windows.Forms.DateTimePicker dtpPayDate;
        private System.Windows.Forms.Label lblPayDate;
        private System.Windows.Forms.TextBox txtPayPlan;
        private System.Windows.Forms.ComboBox cmbPayStatus;
        private System.Windows.Forms.Label lblPayStatus;
        private System.Windows.Forms.NumericUpDown numPayAmount;
        private System.Windows.Forms.Label lblPayAmount;
        private System.Windows.Forms.Button btnPayAdd;
        private System.Windows.Forms.Button btnPayClear;
        private System.Windows.Forms.Panel pnlPaymentsTable;
        private System.Windows.Forms.Label lblPaymentsListTitle;
        private System.Windows.Forms.DataGridView dgvPayments;
    }
}
