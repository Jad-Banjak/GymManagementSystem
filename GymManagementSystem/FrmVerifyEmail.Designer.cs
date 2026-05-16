namespace GymManagementSystem
{
    partial class FrmVerifyEmail
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
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.txtCode = new System.Windows.Forms.TextBox();
            this.btnVerify = new System.Windows.Forms.Button();
            this.lnkGoLogin = new System.Windows.Forms.LinkLabel();
            this.SuspendLayout();
            // 
            // txtEmail
            // 
            this.txtEmail.Location = new System.Drawing.Point(379, 84);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(100, 20);
            this.txtEmail.TabIndex = 0;
            // 
            // txtCode
            // 
            this.txtCode.Location = new System.Drawing.Point(379, 130);
            this.txtCode.Name = "txtCode";
            this.txtCode.Size = new System.Drawing.Size(100, 20);
            this.txtCode.TabIndex = 1;
            // 
            // btnVerify
            // 
            this.btnVerify.Location = new System.Drawing.Point(391, 175);
            this.btnVerify.Name = "btnVerify";
            this.btnVerify.Size = new System.Drawing.Size(75, 23);
            this.btnVerify.TabIndex = 2;
            this.btnVerify.Text = "Verify";
            this.btnVerify.UseVisualStyleBackColor = true;
            this.btnVerify.Click += new System.EventHandler(this.btnVerify_Click);
            // 
            // lnkGoLogin
            // 
            this.lnkGoLogin.AutoSize = true;
            this.lnkGoLogin.Location = new System.Drawing.Point(409, 215);
            this.lnkGoLogin.Name = "lnkGoLogin";
            this.lnkGoLogin.Size = new System.Drawing.Size(34, 13);
            this.lnkGoLogin.TabIndex = 3;
            this.lnkGoLogin.TabStop = true;
            this.lnkGoLogin.Text = "LogIn";
            this.lnkGoLogin.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lnkGoLogin_LinkClicked);
            // 
            // FrmVerifyEmail
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(912, 483);
            this.Controls.Add(this.lnkGoLogin);
            this.Controls.Add(this.btnVerify);
            this.Controls.Add(this.txtCode);
            this.Controls.Add(this.txtEmail);
            this.Name = "FrmVerifyEmail";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FrmVerifyEmail";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.TextBox txtCode;
        private System.Windows.Forms.Button btnVerify;
        private System.Windows.Forms.LinkLabel lnkGoLogin;
    }
}