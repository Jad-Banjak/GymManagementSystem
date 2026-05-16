using GymManagementSystem.Helpers;
using GymManagementSystem.Main;
using System;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace GymManagementSystem
{
    public partial class FrmLogin : Form
    {
        readonly SqlConnection con = DatabaseHelper.CreateConnection();

        public FrmLogin()
        {
            InitializeComponent();
        }

        private void chkShowPassword_CheckedChanged(object sender, EventArgs e)
        {
            txtPassword.UseSystemPasswordChar = !chkShowPassword.Checked;
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtEmail.Text) || string.IsNullOrWhiteSpace(txtPassword.Text))
            {
                MessageBox.Show("Please enter email and password");
                return;
            }

            string passwordHash = PasswordHelper.HashPassword(txtPassword.Text);

            using (var cmd = DatabaseHelper.CreateCommand(
                "SELECT UserID, FullName, Role, Status, EmailVerified FROM Users " +
                "WHERE Email=@Email AND PasswordHash=@PasswordHash", con))
            {
                cmd.Parameters.Add(DatabaseHelper.Param("@Email", txtEmail.Text.Trim()));
                cmd.Parameters.Add(DatabaseHelper.Param("@PasswordHash", passwordHash));

                try
                {
                    con.Open();
                    using (var reader = cmd.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            string fullName = reader["FullName"].ToString();
                            string status = reader["Status"].ToString();
                            int verified = Convert.ToInt32(reader["EmailVerified"]);
                            string role = reader["Role"].ToString();

                            if (status != "Active")
                            {
                                MessageBox.Show("Account is inactive. Contact admin.");
                                return;
                            }

                            if (verified == 0)
                            {
                                MessageBox.Show("Email not verified. Please verify your email.");
                                return;
                            }

                            var main = new FrmMain(role, fullName);
                            main.Show();
                            Hide();
                        }
                        else
                        {
                            MessageBox.Show("Invalid email or password");
                        }
                    }
                }
                catch (Exception ex)
                {
                    ErrorMessageHelper.ShowDatabaseError(this, "sign in", ex);
                }
                finally
                {
                    if (con.State == System.Data.ConnectionState.Open)
                        con.Close();
                }
            }
        }

        private void lnkSignup_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            var signup = new FrmSignup();
            signup.Show();
            Hide();
        }
    }
}
