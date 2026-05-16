using GymManagementSystem.Helpers;
using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace GymManagementSystem
{
    public partial class UC_Memberships : UserControl
    {
        readonly SqlConnection con = DatabaseHelper.CreateConnection();
        int planId;

        public UC_Memberships()
        {
            InitializeComponent();
        }

        private void UC_Memberships_Load(object sender, EventArgs e)
        {
            LoadPlans();
        }

        void LoadPlans()
        {
            try
            {
                using (var cmd = DatabaseHelper.CreateCommand(
                    "SELECT PlanID, PlanName, DurationMonths, Price, Description, Status FROM MembershipPlans", con))
                {
                    if (con.State == ConnectionState.Closed)
                        con.Open();

                    var dt = new DataTable();
                    using (var reader = cmd.ExecuteReader())
                        dt.Load(reader);

                    dgvMemberships.DataSource = dt;
                    dgvMemberships.BringToFront();
                    DataGridHelper.ConfigureReadOnlyGrid(dgvMemberships);
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

        private void btnPlanAdd_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtPlanName.Text) || string.IsNullOrWhiteSpace(cmbPlanStatus.Text))
            {
                MessageBox.Show("Please fill all required fields");
                return;
            }

            try
            {
                using (var cmd = DatabaseHelper.CreateCommand(
                    "INSERT INTO MembershipPlans (PlanName, DurationMonths, Price, Description, Status) " +
                    "VALUES (@PlanName, @DurationMonths, @Price, @Description, @Status)", con))
                {
                    cmd.Parameters.Add(DatabaseHelper.Param("@PlanName", txtPlanName.Text.Trim()));
                    cmd.Parameters.Add(DatabaseHelper.Param("@DurationMonths", Convert.ToInt32(numDurationMonths.Value)));
                    cmd.Parameters.Add(DatabaseHelper.Param("@Price", Convert.ToDecimal(numPlanPrice.Value)));
                    cmd.Parameters.Add(DatabaseHelper.Param("@Description", txtPlanDescription.Text.Trim()));
                    cmd.Parameters.Add(DatabaseHelper.Param("@Status", cmbPlanStatus.Text));

                    con.Open();
                    cmd.ExecuteNonQuery();
                }

                MessageBox.Show("Plan added successfully");
                ClearFields();
                LoadPlans();
            }
            catch (Exception ex)
            {
                ErrorMessageHelper.ShowDatabaseError(this, "add membership plan", ex);
            }
            finally
            {
                if (con.State == ConnectionState.Open)
                    con.Close();
            }
        }

        private void btnPlanUpdate_Click(object sender, EventArgs e)
        {
            if (planId == 0)
            {
                MessageBox.Show("Please select a plan to update");
                return;
            }

            try
            {
                using (var cmd = DatabaseHelper.CreateCommand(
                    "UPDATE MembershipPlans SET PlanName=@PlanName, DurationMonths=@DurationMonths, Price=@Price, " +
                    "Description=@Description, Status=@Status WHERE PlanID=@PlanID", con))
                {
                    cmd.Parameters.Add(DatabaseHelper.Param("@PlanName", txtPlanName.Text.Trim()));
                    cmd.Parameters.Add(DatabaseHelper.Param("@DurationMonths", Convert.ToInt32(numDurationMonths.Value)));
                    cmd.Parameters.Add(DatabaseHelper.Param("@Price", Convert.ToDecimal(numPlanPrice.Value)));
                    cmd.Parameters.Add(DatabaseHelper.Param("@Description", txtPlanDescription.Text.Trim()));
                    cmd.Parameters.Add(DatabaseHelper.Param("@Status", cmbPlanStatus.Text));
                    cmd.Parameters.Add(DatabaseHelper.Param("@PlanID", planId));

                    con.Open();
                    cmd.ExecuteNonQuery();
                }

                MessageBox.Show("Plan updated successfully");
                ClearFields();
                LoadPlans();
            }
            catch (Exception ex)
            {
                ErrorMessageHelper.ShowDatabaseError(this, "update membership plan", ex);
            }
            finally
            {
                if (con.State == ConnectionState.Open)
                    con.Close();
            }
        }

        private void btnPlanDelete_Click(object sender, EventArgs e)
        {
            if (planId == 0)
            {
                MessageBox.Show("Please select a plan to delete");
                return;
            }

            if (MessageBox.Show("Delete this plan?", "Confirm", MessageBoxButtons.YesNo, MessageBoxIcon.Question) != DialogResult.Yes)
                return;

            try
            {
                using (var cmd = DatabaseHelper.CreateCommand("DELETE FROM MembershipPlans WHERE PlanID=@PlanID", con))
                {
                    cmd.Parameters.Add(DatabaseHelper.Param("@PlanID", planId));
                    con.Open();
                    cmd.ExecuteNonQuery();
                }

                MessageBox.Show("Plan deleted successfully");
                ClearFields();
                LoadPlans();
            }
            catch (Exception ex)
            {
                ErrorMessageHelper.ShowDatabaseError(this, "delete membership plan", ex);
            }
            finally
            {
                if (con.State == ConnectionState.Open)
                    con.Close();
            }
        }

        private void dgvMemberships_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0) return;

            planId = Convert.ToInt32(dgvMemberships.Rows[e.RowIndex].Cells["PlanID"].Value);
            txtPlanName.Text = dgvMemberships.Rows[e.RowIndex].Cells["PlanName"].Value.ToString();
            numDurationMonths.Value = Convert.ToDecimal(dgvMemberships.Rows[e.RowIndex].Cells["DurationMonths"].Value);
            numPlanPrice.Value = Convert.ToDecimal(dgvMemberships.Rows[e.RowIndex].Cells["Price"].Value);

            var descVal = dgvMemberships.Rows[e.RowIndex].Cells["Description"].Value;
            txtPlanDescription.Text = (descVal == DBNull.Value) ? "" : descVal.ToString();
            cmbPlanStatus.Text = dgvMemberships.Rows[e.RowIndex].Cells["Status"].Value.ToString();
        }

        void ClearFields()
        {
            txtPlanName.Clear();
            txtPlanDescription.Clear();
            cmbPlanStatus.Text = "";
            numDurationMonths.Value = 1;
            numPlanPrice.Value = 0;
            planId = 0;
        }

        private void btnPlanClear_Click(object sender, EventArgs e)
        {
            ClearFields();
        }

    }
}
