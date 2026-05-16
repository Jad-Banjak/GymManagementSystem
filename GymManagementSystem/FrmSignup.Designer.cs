namespace GymManagementSystem
{
    partial class FrmSignup
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmSignup));
            this.pnlLeftSignup = new System.Windows.Forms.Panel();
            this.lblTitleSignup = new System.Windows.Forms.Label();
            this.picLogoSignup = new System.Windows.Forms.PictureBox();
            this.lblSubSignup = new System.Windows.Forms.Label();
            this.pnlRightSignup = new System.Windows.Forms.Panel();
            this.lblPassError = new System.Windows.Forms.Label();
            this.lblEmailError = new System.Windows.Forms.Label();
            this.pnlCardSignup = new System.Windows.Forms.Panel();
            this.cmbRole = new System.Windows.Forms.ComboBox();
            this.lblRole = new System.Windows.Forms.Label();
            this.txtConfirmPassword = new System.Windows.Forms.TextBox();
            this.lblConfirmPassword = new System.Windows.Forms.Label();
            this.txtFullName = new System.Windows.Forms.TextBox();
            this.lblFullName = new System.Windows.Forms.Label();
            this.lnkGoLogin = new System.Windows.Forms.LinkLabel();
            this.btnSignup = new System.Windows.Forms.Button();
            this.chkShowPassword = new System.Windows.Forms.CheckBox();
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.lblEmailSignUp = new System.Windows.Forms.Label();
            this.lblSignup = new System.Windows.Forms.Label();
            this.lblPassword = new System.Windows.Forms.Label();
            this.pnlLeftSignup.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picLogoSignup)).BeginInit();
            this.pnlRightSignup.SuspendLayout();
            this.pnlCardSignup.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlLeftSignup
            // 
            this.pnlLeftSignup.BackColor = System.Drawing.Color.White;
            this.pnlLeftSignup.Controls.Add(this.lblTitleSignup);
            this.pnlLeftSignup.Controls.Add(this.picLogoSignup);
            this.pnlLeftSignup.Controls.Add(this.lblSubSignup);
            this.pnlLeftSignup.Dock = System.Windows.Forms.DockStyle.Left;
            this.pnlLeftSignup.Location = new System.Drawing.Point(0, 0);
            this.pnlLeftSignup.Name = "pnlLeftSignup";
            this.pnlLeftSignup.Size = new System.Drawing.Size(360, 581);
            this.pnlLeftSignup.TabIndex = 2;
            // 
            // lblTitleSignup
            // 
            this.lblTitleSignup.AutoSize = true;
            this.lblTitleSignup.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitleSignup.Location = new System.Drawing.Point(22, 198);
            this.lblTitleSignup.Name = "lblTitleSignup";
            this.lblTitleSignup.Size = new System.Drawing.Size(311, 32);
            this.lblTitleSignup.TabIndex = 0;
            this.lblTitleSignup.Text = "Gym Management System";
            // 
            // picLogoSignup
            // 
            this.picLogoSignup.Image = ((System.Drawing.Image)(resources.GetObject("picLogoSignup.Image")));
            this.picLogoSignup.Location = new System.Drawing.Point(-38, 12);
            this.picLogoSignup.Name = "picLogoSignup";
            this.picLogoSignup.Size = new System.Drawing.Size(395, 193);
            this.picLogoSignup.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picLogoSignup.TabIndex = 3;
            this.picLogoSignup.TabStop = false;
            // 
            // lblSubSignup
            // 
            this.lblSubSignup.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSubSignup.ForeColor = System.Drawing.Color.DimGray;
            this.lblSubSignup.Location = new System.Drawing.Point(25, 253);
            this.lblSubSignup.Name = "lblSubSignup";
            this.lblSubSignup.Size = new System.Drawing.Size(300, 60);
            this.lblSubSignup.TabIndex = 2;
            this.lblSubSignup.Text = "Login to manage members, memberships, payments, and machines.";
            // 
            // pnlRightSignup
            // 
            this.pnlRightSignup.Controls.Add(this.lblPassError);
            this.pnlRightSignup.Controls.Add(this.lblEmailError);
            this.pnlRightSignup.Controls.Add(this.pnlCardSignup);
            this.pnlRightSignup.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlRightSignup.Location = new System.Drawing.Point(360, 0);
            this.pnlRightSignup.Name = "pnlRightSignup";
            this.pnlRightSignup.Size = new System.Drawing.Size(684, 581);
            this.pnlRightSignup.TabIndex = 3;
            // 
            // lblPassError
            // 
            this.lblPassError.AutoSize = true;
            this.lblPassError.ForeColor = System.Drawing.Color.Firebrick;
            this.lblPassError.Location = new System.Drawing.Point(30, 197);
            this.lblPassError.Name = "lblPassError";
            this.lblPassError.Size = new System.Drawing.Size(0, 13);
            this.lblPassError.TabIndex = 2;
            // 
            // lblEmailError
            // 
            this.lblEmailError.AutoSize = true;
            this.lblEmailError.ForeColor = System.Drawing.Color.Firebrick;
            this.lblEmailError.Location = new System.Drawing.Point(30, 132);
            this.lblEmailError.Name = "lblEmailError";
            this.lblEmailError.Size = new System.Drawing.Size(0, 13);
            this.lblEmailError.TabIndex = 1;
            // 
            // pnlCardSignup
            // 
            this.pnlCardSignup.BackColor = System.Drawing.Color.White;
            this.pnlCardSignup.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlCardSignup.Controls.Add(this.cmbRole);
            this.pnlCardSignup.Controls.Add(this.lblRole);
            this.pnlCardSignup.Controls.Add(this.txtConfirmPassword);
            this.pnlCardSignup.Controls.Add(this.lblConfirmPassword);
            this.pnlCardSignup.Controls.Add(this.txtFullName);
            this.pnlCardSignup.Controls.Add(this.lblFullName);
            this.pnlCardSignup.Controls.Add(this.lnkGoLogin);
            this.pnlCardSignup.Controls.Add(this.btnSignup);
            this.pnlCardSignup.Controls.Add(this.chkShowPassword);
            this.pnlCardSignup.Controls.Add(this.txtPassword);
            this.pnlCardSignup.Controls.Add(this.txtEmail);
            this.pnlCardSignup.Controls.Add(this.lblEmailSignUp);
            this.pnlCardSignup.Controls.Add(this.lblSignup);
            this.pnlCardSignup.Controls.Add(this.lblPassword);
            this.pnlCardSignup.Location = new System.Drawing.Point(127, 12);
            this.pnlCardSignup.Name = "pnlCardSignup";
            this.pnlCardSignup.Size = new System.Drawing.Size(400, 520);
            this.pnlCardSignup.TabIndex = 0;
            // 
            // cmbRole
            // 
            this.cmbRole.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbRole.FormattingEnabled = true;
            this.cmbRole.Items.AddRange(new object[] {
            "Admin",
            "Staff"});
            this.cmbRole.Location = new System.Drawing.Point(30, 340);
            this.cmbRole.Name = "cmbRole";
            this.cmbRole.Size = new System.Drawing.Size(340, 21);
            this.cmbRole.TabIndex = 13;
            // 
            // lblRole
            // 
            this.lblRole.AutoSize = true;
            this.lblRole.Location = new System.Drawing.Point(27, 315);
            this.lblRole.Name = "lblRole";
            this.lblRole.Size = new System.Drawing.Size(29, 13);
            this.lblRole.TabIndex = 12;
            this.lblRole.Text = "Role";
            // 
            // txtConfirmPassword
            // 
            this.txtConfirmPassword.Location = new System.Drawing.Point(30, 246);
            this.txtConfirmPassword.Name = "txtConfirmPassword";
            this.txtConfirmPassword.Size = new System.Drawing.Size(340, 20);
            this.txtConfirmPassword.TabIndex = 11;
            this.txtConfirmPassword.UseSystemPasswordChar = true;
            // 
            // lblConfirmPassword
            // 
            this.lblConfirmPassword.AutoSize = true;
            this.lblConfirmPassword.Location = new System.Drawing.Point(27, 230);
            this.lblConfirmPassword.Name = "lblConfirmPassword";
            this.lblConfirmPassword.Size = new System.Drawing.Size(94, 13);
            this.lblConfirmPassword.TabIndex = 10;
            this.lblConfirmPassword.Text = " Confirm Password";
            // 
            // txtFullName
            // 
            this.txtFullName.Location = new System.Drawing.Point(30, 96);
            this.txtFullName.Name = "txtFullName";
            this.txtFullName.Size = new System.Drawing.Size(340, 20);
            this.txtFullName.TabIndex = 9;
            // 
            // lblFullName
            // 
            this.lblFullName.AutoSize = true;
            this.lblFullName.Location = new System.Drawing.Point(27, 80);
            this.lblFullName.Name = "lblFullName";
            this.lblFullName.Size = new System.Drawing.Size(54, 13);
            this.lblFullName.TabIndex = 8;
            this.lblFullName.Text = "Full Name";
            // 
            // lnkGoLogin
            // 
            this.lnkGoLogin.ActiveLinkColor = System.Drawing.Color.RoyalBlue;
            this.lnkGoLogin.AutoSize = true;
            this.lnkGoLogin.BackColor = System.Drawing.SystemColors.Window;
            this.lnkGoLogin.Location = new System.Drawing.Point(30, 461);
            this.lnkGoLogin.Name = "lnkGoLogin";
            this.lnkGoLogin.Size = new System.Drawing.Size(161, 13);
            this.lnkGoLogin.TabIndex = 1;
            this.lnkGoLogin.TabStop = true;
            this.lnkGoLogin.Text = "Already have an account? Login";
            this.lnkGoLogin.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lnkGoLogin_LinkClicked);
            // 
            // btnSignup
            // 
            this.btnSignup.BackColor = System.Drawing.Color.RoyalBlue;
            this.btnSignup.FlatAppearance.BorderSize = 0;
            this.btnSignup.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSignup.ForeColor = System.Drawing.Color.White;
            this.btnSignup.Location = new System.Drawing.Point(30, 411);
            this.btnSignup.Name = "btnSignup";
            this.btnSignup.Size = new System.Drawing.Size(340, 40);
            this.btnSignup.TabIndex = 1;
            this.btnSignup.Text = "Sign Up";
            this.btnSignup.UseVisualStyleBackColor = false;
            this.btnSignup.Click += new System.EventHandler(this.btnSignup_Click);
            // 
            // chkShowPassword
            // 
            this.chkShowPassword.AutoSize = true;
            this.chkShowPassword.Location = new System.Drawing.Point(33, 283);
            this.chkShowPassword.Name = "chkShowPassword";
            this.chkShowPassword.Size = new System.Drawing.Size(102, 17);
            this.chkShowPassword.TabIndex = 6;
            this.chkShowPassword.Text = "Show Password";
            this.chkShowPassword.UseVisualStyleBackColor = true;
            this.chkShowPassword.CheckedChanged += new System.EventHandler(this.chkShowPassword_CheckedChanged);
            // 
            // txtPassword
            // 
            this.txtPassword.Location = new System.Drawing.Point(30, 197);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.Size = new System.Drawing.Size(340, 20);
            this.txtPassword.TabIndex = 7;
            this.txtPassword.UseSystemPasswordChar = true;
            // 
            // txtEmail
            // 
            this.txtEmail.Location = new System.Drawing.Point(30, 146);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(340, 20);
            this.txtEmail.TabIndex = 6;
            // 
            // lblEmailSignUp
            // 
            this.lblEmailSignUp.AutoSize = true;
            this.lblEmailSignUp.Location = new System.Drawing.Point(27, 128);
            this.lblEmailSignUp.Name = "lblEmailSignUp";
            this.lblEmailSignUp.Size = new System.Drawing.Size(32, 13);
            this.lblEmailSignUp.TabIndex = 1;
            this.lblEmailSignUp.Text = "Email";
            // 
            // lblSignup
            // 
            this.lblSignup.AutoSize = true;
            this.lblSignup.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSignup.Location = new System.Drawing.Point(30, 25);
            this.lblSignup.Name = "lblSignup";
            this.lblSignup.Size = new System.Drawing.Size(93, 15);
            this.lblSignup.TabIndex = 1;
            this.lblSignup.Text = "Create Account";
            // 
            // lblPassword
            // 
            this.lblPassword.AutoSize = true;
            this.lblPassword.Location = new System.Drawing.Point(27, 179);
            this.lblPassword.Name = "lblPassword";
            this.lblPassword.Size = new System.Drawing.Size(53, 13);
            this.lblPassword.TabIndex = 2;
            this.lblPassword.Text = "Password";
            // 
            // FrmSignup
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1044, 581);
            this.Controls.Add(this.pnlRightSignup);
            this.Controls.Add(this.pnlLeftSignup);
            this.Name = "FrmSignup";
            this.Text = "FrmSignup";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.pnlLeftSignup.ResumeLayout(false);
            this.pnlLeftSignup.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picLogoSignup)).EndInit();
            this.pnlRightSignup.ResumeLayout(false);
            this.pnlRightSignup.PerformLayout();
            this.pnlCardSignup.ResumeLayout(false);
            this.pnlCardSignup.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlLeftSignup;
        private System.Windows.Forms.Label lblTitleSignup;
        private System.Windows.Forms.PictureBox picLogoSignup;
        private System.Windows.Forms.Label lblSubSignup;
        private System.Windows.Forms.Panel pnlRightSignup;
        private System.Windows.Forms.Label lblPassError;
        private System.Windows.Forms.Label lblEmailError;
        private System.Windows.Forms.Panel pnlCardSignup;
        private System.Windows.Forms.LinkLabel lnkGoLogin;
        private System.Windows.Forms.Button btnSignup;
        private System.Windows.Forms.CheckBox chkShowPassword;
        private System.Windows.Forms.TextBox txtPassword;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.Label lblEmailSignUp;
        private System.Windows.Forms.Label lblSignup;
        private System.Windows.Forms.Label lblPassword;
        private System.Windows.Forms.TextBox txtFullName;
        private System.Windows.Forms.Label lblFullName;
        private System.Windows.Forms.TextBox txtConfirmPassword;
        private System.Windows.Forms.Label lblConfirmPassword;
        private System.Windows.Forms.ComboBox cmbRole;
        private System.Windows.Forms.Label lblRole;
    }
}