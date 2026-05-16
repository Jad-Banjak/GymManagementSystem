using GymManagementSystem.Helpers;
using System;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace GymManagementSystem
{
    public partial class FrmSignup : Form
    {
        readonly SqlConnection con = DatabaseHelper.CreateConnection();

        public FrmSignup()
        {
            InitializeComponent();
            cmbRole.Visible = false;
            lblRole.Visible = false;
        }

        private void btnSignup_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtFullName.Text) ||
                string.IsNullOrWhiteSpace(txtEmail.Text) ||
                string.IsNullOrWhiteSpace(txtPassword.Text) ||
                string.IsNullOrWhiteSpace(txtConfirmPassword.Text))
            {
                MessageBox.Show("Please fill all fields");
                return;
            }

            string pass1 = txtPassword.Text.Trim();
            string pass2 = txtConfirmPassword.Text.Trim();

            if (pass1 != pass2)
            {
                MessageBox.Show("Passwords do not match");
                return;
            }

            try
            {
                con.Open();

                using (var checkCmd = DatabaseHelper.CreateCommand(
                    "SELECT COUNT(*) FROM Users WHERE Email=@Email", con))
                {
                    checkCmd.Parameters.Add(DatabaseHelper.Param("@Email", txtEmail.Text.Trim()));
                    int exists = (int)checkCmd.ExecuteScalar();
                    if (exists > 0)
                    {
                        MessageBox.Show("Email already exists. Please login instead.");
                        return;
                    }
                }

                string code = new Random().Next(100000, 999999).ToString();

                using (var insertCmd = DatabaseHelper.CreateCommand(
                    "INSERT INTO Users (FullName, Email, PasswordHash, Role, Status, EmailVerified, VerificationCode) " +
                    "VALUES (@FullName, @Email, @PasswordHash, @Role, 'Active', 0, @VerificationCode)", con))
                {
                    insertCmd.Parameters.Add(DatabaseHelper.Param("@FullName", txtFullName.Text.Trim()));
                    insertCmd.Parameters.Add(DatabaseHelper.Param("@Email", txtEmail.Text.Trim()));
                    insertCmd.Parameters.Add(DatabaseHelper.Param("@PasswordHash", PasswordHelper.HashPassword(pass1)));
                    insertCmd.Parameters.Add(DatabaseHelper.Param("@Role", AuthRoles.Staff));
                    insertCmd.Parameters.Add(DatabaseHelper.Param("@VerificationCode", code));

                    insertCmd.ExecuteNonQuery();
                }

                MessageBox.Show("Verification code (simulate email): " + code);

                var verify = new FrmVerifyEmail(txtEmail.Text.Trim());
                verify.Show();
                Hide();
            }
            catch (Exception ex)
            {
                ErrorMessageHelper.ShowDatabaseError(this, "create your account", ex);
            }
            finally
            {
                if (con.State == System.Data.ConnectionState.Open)
                    con.Close();
            }
        }

        private void lnkGoLogin_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            var login = new FrmLogin();
            login.Show();
            Hide();
        }

        private void chkShowPassword_CheckedChanged(object sender, EventArgs e)
        {
            bool show = chkShowPassword.Checked;
            txtPassword.UseSystemPasswordChar = !show;
            txtConfirmPassword.UseSystemPasswordChar = !show;
        }
    }
}
