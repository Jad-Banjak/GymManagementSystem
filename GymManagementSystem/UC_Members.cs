using GymManagementSystem.Helpers;
using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace GymManagementSystem
{
    public partial class UC_Members : UserControl
    {
        readonly SqlConnection con = DatabaseHelper.CreateConnection();
        int memberId;

        public UC_Members()
        {
            InitializeComponent();
        }

        private void UC_Members_Load(object sender, EventArgs e)
        {
            dtpMemberEnd.Enabled = false;
            AutoUpdateMemberStatus();
            LoadPlans();
            LoadMembers();
        }

        void AutoUpdateMemberStatus()
        {
            try
            {
                using (var cmd = DatabaseHelper.CreateCommand(
                    "UPDATE Members SET Status = CASE WHEN EndDate < CAST(GETDATE() AS date) THEN 'Expired' ELSE 'Active' END",
                    con))
                {
                    if (con.State == ConnectionState.Closed)
                        con.Open();
                    cmd.ExecuteNonQuery();
                }
            }
            catch (Exception ex)
            {
                ErrorMessageHelper.ShowDatabaseError(this, "update member status", ex);
            }
            finally
            {
                if (con.State == ConnectionState.Open)
                    con.Close();
            }
        }

        void LoadPlans()
        {
            try
            {
                using (var cmd = DatabaseHelper.CreateCommand(
                    "SELECT PlanID, PlanName FROM MembershipPlans WHERE Status='Active'", con))
                {
                    if (con.State == ConnectionState.Closed)
                        con.Open();

                    var dt = new DataTable();
                    using (var reader = cmd.ExecuteReader())
                        dt.Load(reader);

                    cmbMemberPlan.DisplayMember = "PlanName";
                    cmbMemberPlan.ValueMember = "PlanID";
                    cmbMemberPlan.DataSource = dt;
                    cmbMemberPlan.SelectedIndex = -1;
                }
            }
            catch (Exception ex)
            {
                ErrorMessageHelper.ShowDatabaseError(this, "load membership plans", ex);
            }
            finally
            {
                if (con.State == ConnectionState.Open)
                    con.Close();
            }
        }

        void LoadMembers()
        {
            try
            {
                using (var cmd = DatabaseHelper.CreateCommand(
                    "SELECT m.MemberID, m.FullName, m.Phone, m.Gender, m.PlanID, p.PlanName, m.StartDate, m.EndDate, m.Status " +
                    "FROM Members m LEFT JOIN MembershipPlans p ON m.PlanID = p.PlanID ORDER BY m.MemberID DESC", con))
                {
                    if (con.State == ConnectionState.Closed)
                        con.Open();

                    var dt = new DataTable();
                    using (var reader = cmd.ExecuteReader())
                        dt.Load(reader);

                    dgvMembers.AutoGenerateColumns = true;
                    dgvMembers.DataSource = dt;
                    dgvMembers.ReadOnly = true;
                    dgvMembers.AllowUserToAddRows = false;
                    dgvMembers.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
                    dgvMembers.MultiSelect = false;
                    dgvMembers.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
                }
            }
            catch (Exception ex)
            {
                ErrorMessageHelper.ShowDatabaseError(this, "load members", ex);
            }
            finally
            {
                if (con.State == ConnectionState.Open)
                    con.Close();
            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtMemberName.Text) ||
                string.IsNullOrWhiteSpace(cmbMemberGender.Text) ||
                cmbMemberPlan.SelectedIndex == -1)
            {
                MessageBox.Show("Please fill all required fields");
                return;
            }

            int planId = Convert.ToInt32(cmbMemberPlan.SelectedValue);
            DateTime startDate = dtpMemberStart.Value.Date;

            try
            {
                using (var cmd = DatabaseHelper.CreateCommand(
                    "INSERT INTO Members (FullName, Phone, Gender, PlanID, StartDate, EndDate, Status) " +
                    "VALUES (@FullName, @Phone, @Gender, @PlanID, @StartDate, " +
                    "DATEADD(MONTH, (SELECT DurationMonths FROM MembershipPlans WHERE PlanID=@PlanID), @StartDate), 'Active')",
                    con))
                {
                    cmd.Parameters.Add(DatabaseHelper.Param("@FullName", txtMemberName.Text.Trim()));
                    cmd.Parameters.Add(DatabaseHelper.Param("@Phone", txtMemberPhone.Text.Trim()));
                    cmd.Parameters.Add(DatabaseHelper.Param("@Gender", cmbMemberGender.Text));
                    cmd.Parameters.Add(DatabaseHelper.Param("@PlanID", planId));
                    cmd.Parameters.Add(DatabaseHelper.Param("@StartDate", startDate));

                    if (con.State == ConnectionState.Closed)
                        con.Open();
                    cmd.ExecuteNonQuery();
                }

                MessageBox.Show("Member added successfully");
                ClearFields();
                AutoUpdateMemberStatus();
                LoadMembers();
            }
            catch (Exception ex)
            {
                ErrorMessageHelper.ShowDatabaseError(this, "add member", ex);
            }
            finally
            {
                if (con.State == ConnectionState.Open)
                    con.Close();
            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (memberId == 0)
            {
                MessageBox.Show("Please select a member to update");
                return;
            }

            if (cmbMemberPlan.SelectedIndex == -1)
            {
                MessageBox.Show("Please select a plan");
                return;
            }

            int planId = Convert.ToInt32(cmbMemberPlan.SelectedValue);
            DateTime startDate = dtpMemberStart.Value.Date;

            try
            {
                using (var cmd = DatabaseHelper.CreateCommand(
                    "UPDATE Members SET FullName=@FullName, Phone=@Phone, Gender=@Gender, PlanID=@PlanID, " +
                    "StartDate=@StartDate, EndDate=DATEADD(MONTH, (SELECT DurationMonths FROM MembershipPlans WHERE PlanID=@PlanID), @StartDate) " +
                    "WHERE MemberID=@MemberID", con))
                {
                    cmd.Parameters.Add(DatabaseHelper.Param("@FullName", txtMemberName.Text.Trim()));
                    cmd.Parameters.Add(DatabaseHelper.Param("@Phone", txtMemberPhone.Text.Trim()));
                    cmd.Parameters.Add(DatabaseHelper.Param("@Gender", cmbMemberGender.Text));
                    cmd.Parameters.Add(DatabaseHelper.Param("@PlanID", planId));
                    cmd.Parameters.Add(DatabaseHelper.Param("@StartDate", startDate));
                    cmd.Parameters.Add(DatabaseHelper.Param("@MemberID", memberId));

                    if (con.State == ConnectionState.Closed)
                        con.Open();
                    cmd.ExecuteNonQuery();
                }

                MessageBox.Show("Member updated successfully");
                ClearFields();
                AutoUpdateMemberStatus();
                LoadMembers();
            }
            catch (Exception ex)
            {
                ErrorMessageHelper.ShowDatabaseError(this, "update member", ex);
            }
            finally
            {
                if (con.State == ConnectionState.Open)
                    con.Close();
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (memberId == 0)
            {
                MessageBox.Show("Please select a member to delete");
                return;
            }

            if (MessageBox.Show("Delete this member?", "Confirm", MessageBoxButtons.YesNo, MessageBoxIcon.Question) != DialogResult.Yes)
                return;

            try
            {
                using (var cmd = DatabaseHelper.CreateCommand("DELETE FROM Members WHERE MemberID=@MemberID", con))
                {
                    cmd.Parameters.Add(DatabaseHelper.Param("@MemberID", memberId));

                    if (con.State == ConnectionState.Closed)
                        con.Open();
                    cmd.ExecuteNonQuery();
                }

                MessageBox.Show("Member deleted successfully");
                ClearFields();
                AutoUpdateMemberStatus();
                LoadMembers();
            }
            catch (Exception ex)
            {
                ErrorMessageHelper.ShowDatabaseError(this, "delete member", ex);
            }
            finally
            {
                if (con.State == ConnectionState.Open)
                    con.Close();
            }
        }

        private void dgvMembers_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0) return;

            memberId = Convert.ToInt32(dgvMembers.Rows[e.RowIndex].Cells["MemberID"].Value);
            txtMemberName.Text = dgvMembers.Rows[e.RowIndex].Cells["FullName"].Value.ToString();

            var phoneVal = dgvMembers.Rows[e.RowIndex].Cells["Phone"].Value;
            txtMemberPhone.Text = (phoneVal == DBNull.Value) ? "" : phoneVal.ToString();

            var genderVal = dgvMembers.Rows[e.RowIndex].Cells["Gender"].Value;
            cmbMemberGender.Text = (genderVal == DBNull.Value) ? "" : genderVal.ToString();

            var planVal = dgvMembers.Rows[e.RowIndex].Cells["PlanID"].Value;
            if (planVal == DBNull.Value)
                cmbMemberPlan.SelectedIndex = -1;
            else
                cmbMemberPlan.SelectedValue = Convert.ToInt32(planVal);

            dtpMemberStart.Value = Convert.ToDateTime(dgvMembers.Rows[e.RowIndex].Cells["StartDate"].Value);
            dtpMemberEnd.Value = Convert.ToDateTime(dgvMembers.Rows[e.RowIndex].Cells["EndDate"].Value);
            cmbMemberStatus.Text = dgvMembers.Rows[e.RowIndex].Cells["Status"].Value.ToString();
        }

        void ClearFields()
        {
            txtMemberName.Clear();
            txtMemberPhone.Clear();
            cmbMemberGender.Text = "";
            cmbMemberPlan.SelectedIndex = -1;
            dtpMemberStart.Value = DateTime.Today;
            dtpMemberEnd.Value = DateTime.Today;
            cmbMemberStatus.Text = "";
            memberId = 0;
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            ClearFields();
        }
    }
}
