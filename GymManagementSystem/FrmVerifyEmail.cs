using GymManagementSystem.Helpers;
using System;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace GymManagementSystem
{
    public partial class FrmVerifyEmail : Form
    {
        readonly SqlConnection con = DatabaseHelper.CreateConnection();

        public FrmVerifyEmail()
        {
            InitializeComponent();
        }

        public FrmVerifyEmail(string email)
        {
            InitializeComponent();
            txtEmail.Text = email;
        }

        private void btnVerify_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtEmail.Text) || string.IsNullOrWhiteSpace(txtCode.Text))
            {
                MessageBox.Show("Enter email and code");
                return;
            }

            try
            {
                con.Open();

                using (var selectCmd = DatabaseHelper.CreateCommand(
                    "SELECT UserID FROM Users WHERE Email=@Email AND VerificationCode=@Code", con))
                {
                    selectCmd.Parameters.Add(DatabaseHelper.Param("@Email", txtEmail.Text.Trim()));
                    selectCmd.Parameters.Add(DatabaseHelper.Param("@Code", txtCode.Text.Trim()));

                    object result = selectCmd.ExecuteScalar();
                    if (result == null || result == DBNull.Value)
                    {
                        MessageBox.Show("Invalid code or email");
                        return;
                    }
                }

                using (var updateCmd = DatabaseHelper.CreateCommand(
                    "UPDATE Users SET EmailVerified=1, VerificationCode=NULL WHERE Email=@Email", con))
                {
                    updateCmd.Parameters.Add(DatabaseHelper.Param("@Email", txtEmail.Text.Trim()));
                    updateCmd.ExecuteNonQuery();
                }

                MessageBox.Show("Email verified successfully!");

                var login = new FrmLogin();
                login.Show();
                Hide();
            }
            catch (Exception ex)
            {
                ErrorMessageHelper.ShowDatabaseError(this, "verify your email", ex);
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
    }
}
