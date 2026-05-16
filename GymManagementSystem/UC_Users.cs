using GymManagementSystem.Helpers;
using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace GymManagementSystem
{
    public partial class UC_Users : UserControl
    {
        readonly SqlConnection con = DatabaseHelper.CreateConnection();
        readonly bool adminAccessGranted;
        int userId;

        public UC_Users(string currentUserRole)
        {
            InitializeComponent();
            adminAccessGranted = AuthRoles.IsAdmin(currentUserRole);

            if (!adminAccessGranted)
            {
                MessageBox.Show("Access denied. Admin privileges are required.", "Unauthorized",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                DisableAdminControls();
            }
        }

        private void UC_Users_Load(object sender, EventArgs e)
        {
            if (adminAccessGranted)
                LoadUsers();
        }

        void DisableAdminControls()
        {
            SetControlsEnabled(this, false);
        }

        static void SetControlsEnabled(Control parent, bool enabled)
        {
            foreach (Control control in parent.Controls)
            {
                control.Enabled = enabled;
                if (control.HasChildren)
                    SetControlsEnabled(control, enabled);
            }
        }

        void LoadUsers()
        {
            try
            {
                using (var cmd = DatabaseHelper.CreateCommand(
                    "SELECT UserID, FullName, Email, Role, Status, EmailVerified, CreatedAt FROM Users ORDER BY UserID DESC",
                    con))
                {
                    if (con.State == ConnectionState.Closed)
                        con.Open();

                    var dt = new DataTable();
                    using (var reader = cmd.ExecuteReader())
                        dt.Load(reader);

                    dgvUsers.AutoGenerateColumns = true;
                    dgvUsers.DataSource = dt;
                    dgvUsers.BringToFront();
                    DataGridHelper.ConfigureReadOnlyGrid(dgvUsers);
                }
            }
            catch (Exception ex)
            {
                ErrorMessageHelper.ShowDatabaseError(this, "load users", ex);
            }
            finally
            {
                if (con.State == ConnectionState.Open)
                    con.Close();
            }
        }

        private void btnUserAdd_Click(object sender, EventArgs e)
        {
            if (!adminAccessGranted) return;

            if (string.IsNullOrWhiteSpace(txtUserFullName.Text) ||
                string.IsNullOrWhiteSpace(txtUserEmail.Text) ||
                string.IsNullOrWhiteSpace(txtUserPassword.Text) ||
                string.IsNullOrWhiteSpace(cmbUserRole.Text) ||
                string.IsNullOrWhiteSpace(cmbUserStatus.Text))
            {
                MessageBox.Show("Please fill all required fields");
                return;
            }

            int verified = chkEmailVerified.Checked ? 1 : 0;

            try
            {
                using (var cmd = DatabaseHelper.CreateCommand(
                    "INSERT INTO Users (FullName, Email, PasswordHash, Role, Status, EmailVerified) " +
                    "VALUES (@FullName, @Email, @PasswordHash, @Role, @Status, @EmailVerified)", con))
                {
                    cmd.Parameters.Add(DatabaseHelper.Param("@FullName", txtUserFullName.Text.Trim()));
                    cmd.Parameters.Add(DatabaseHelper.Param("@Email", txtUserEmail.Text.Trim()));
                    cmd.Parameters.Add(DatabaseHelper.Param("@PasswordHash", PasswordHelper.HashPassword(txtUserPassword.Text)));
                    cmd.Parameters.Add(DatabaseHelper.Param("@Role", cmbUserRole.Text));
                    cmd.Parameters.Add(DatabaseHelper.Param("@Status", cmbUserStatus.Text));
                    cmd.Parameters.Add(DatabaseHelper.Param("@EmailVerified", verified));

                    con.Open();
                    cmd.ExecuteNonQuery();
                }

                MessageBox.Show("User added successfully");
                ClearFields();
                LoadUsers();
            }
            catch (Exception ex)
            {
                ErrorMessageHelper.ShowDatabaseError(this, "add user", ex);
            }
            finally
            {
                if (con.State == ConnectionState.Open)
                    con.Close();
            }
        }

        private void btnUserUpdate_Click(object sender, EventArgs e)
        {
            if (!adminAccessGranted) return;

            if (userId == 0)
            {
                MessageBox.Show("Please select a user to update");
                return;
            }

            if (string.IsNullOrWhiteSpace(txtUserFullName.Text) ||
                string.IsNullOrWhiteSpace(txtUserEmail.Text) ||
                string.IsNullOrWhiteSpace(cmbUserRole.Text) ||
                string.IsNullOrWhiteSpace(cmbUserStatus.Text))
            {
                MessageBox.Show("Please fill all required fields");
                return;
            }

            int verified = chkEmailVerified.Checked ? 1 : 0;

            try
            {
                string sql = string.IsNullOrWhiteSpace(txtUserPassword.Text)
                    ? "UPDATE Users SET FullName=@FullName, Email=@Email, Role=@Role, Status=@Status, EmailVerified=@EmailVerified WHERE UserID=@UserID"
                    : "UPDATE Users SET FullName=@FullName, Email=@Email, PasswordHash=@PasswordHash, Role=@Role, Status=@Status, EmailVerified=@EmailVerified WHERE UserID=@UserID";

                using (var cmd = DatabaseHelper.CreateCommand(sql, con))
                {
                    cmd.Parameters.Add(DatabaseHelper.Param("@FullName", txtUserFullName.Text.Trim()));
                    cmd.Parameters.Add(DatabaseHelper.Param("@Email", txtUserEmail.Text.Trim()));
                    cmd.Parameters.Add(DatabaseHelper.Param("@Role", cmbUserRole.Text));
                    cmd.Parameters.Add(DatabaseHelper.Param("@Status", cmbUserStatus.Text));
                    cmd.Parameters.Add(DatabaseHelper.Param("@EmailVerified", verified));
                    cmd.Parameters.Add(DatabaseHelper.Param("@UserID", userId));

                    if (!string.IsNullOrWhiteSpace(txtUserPassword.Text))
                        cmd.Parameters.Add(DatabaseHelper.Param("@PasswordHash", PasswordHelper.HashPassword(txtUserPassword.Text)));

                    con.Open();
                    cmd.ExecuteNonQuery();
                }

                MessageBox.Show("User updated successfully");
                ClearFields();
                LoadUsers();
            }
            catch (Exception ex)
            {
                ErrorMessageHelper.ShowDatabaseError(this, "update user", ex);
            }
            finally
            {
                if (con.State == ConnectionState.Open)
                    con.Close();
            }
        }

        private void btnUserDelete_Click(object sender, EventArgs e)
        {
            if (!adminAccessGranted) return;

            if (userId == 0)
            {
                MessageBox.Show("Please select a user to delete");
                return;
            }

            if (MessageBox.Show("Delete this user?", "Confirm", MessageBoxButtons.YesNo, MessageBoxIcon.Question) != DialogResult.Yes)
                return;

            try
            {
                using (var cmd = DatabaseHelper.CreateCommand("DELETE FROM Users WHERE UserID=@UserID", con))
                {
                    cmd.Parameters.Add(DatabaseHelper.Param("@UserID", userId));
                    con.Open();
                    cmd.ExecuteNonQuery();
                }

                MessageBox.Show("User deleted successfully");
                ClearFields();
                LoadUsers();
            }
            catch (Exception ex)
            {
                ErrorMessageHelper.ShowDatabaseError(this, "delete user", ex);
            }
            finally
            {
                if (con.State == ConnectionState.Open)
                    con.Close();
            }
        }

        private void dgvUsers_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (!adminAccessGranted || e.RowIndex < 0) return;

            userId = Convert.ToInt32(dgvUsers.Rows[e.RowIndex].Cells["UserID"].Value);
            txtUserFullName.Text = dgvUsers.Rows[e.RowIndex].Cells["FullName"].Value.ToString();
            txtUserEmail.Text = dgvUsers.Rows[e.RowIndex].Cells["Email"].Value.ToString();
            cmbUserRole.Text = dgvUsers.Rows[e.RowIndex].Cells["Role"].Value.ToString();
            cmbUserStatus.Text = dgvUsers.Rows[e.RowIndex].Cells["Status"].Value.ToString();
            chkEmailVerified.Checked = Convert.ToBoolean(dgvUsers.Rows[e.RowIndex].Cells["EmailVerified"].Value);
            txtUserPassword.Text = "";
        }

        void ClearFields()
        {
            txtUserFullName.Clear();
            txtUserEmail.Clear();
            txtUserPassword.Clear();
            cmbUserRole.Text = "";
            cmbUserStatus.Text = "";
            chkEmailVerified.Checked = false;
            userId = 0;
        }

        private void btnUserClear_Click(object sender, EventArgs e)
        {
            ClearFields();
        }
    }
}
