using GymManagementSystem.Helpers;
using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace GymManagementSystem
{
    public partial class UC_Payments : UserControl
    {
        readonly SqlConnection con = DatabaseHelper.CreateConnection();

        public UC_Payments()
        {
            InitializeComponent();
        }

        private void UC_Payments_Load(object sender, EventArgs e)
        {
            LoadMembers();
            LoadPayments();
        }

        void LoadMembers()
        {
            try
            {
                using (var cmd = DatabaseHelper.CreateCommand(
                    "SELECT MemberID, FullName FROM Members ORDER BY FullName", con))
                {
                    if (con.State == ConnectionState.Closed)
                        con.Open();

                    var dt = new DataTable();
                    using (var reader = cmd.ExecuteReader())
                        dt.Load(reader);

                    cmbPayMember.DisplayMember = "FullName";
                    cmbPayMember.ValueMember = "MemberID";
                    cmbPayMember.DataSource = dt;
                    cmbPayMember.SelectedIndex = -1;
                    txtPayPlan.Text = "";
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

        private void cmbPayMember_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                if (cmbPayMember.SelectedIndex == -1 || cmbPayMember.SelectedValue == null)
                {
                    txtPayPlan.Text = "";
                    return;
                }

                int memberId = Convert.ToInt32(cmbPayMember.SelectedValue);

                using (var cmd = DatabaseHelper.CreateCommand(
                    "SELECT p.PlanName FROM Members m LEFT JOIN MembershipPlans p ON m.PlanID = p.PlanID WHERE m.MemberID=@MemberID",
                    con))
                {
                    cmd.Parameters.Add(DatabaseHelper.Param("@MemberID", memberId));

                    if (con.State == ConnectionState.Closed)
                        con.Open();

                    object planName = cmd.ExecuteScalar();
                    txtPayPlan.Text = (planName == null || planName == DBNull.Value) ? "" : planName.ToString();
                }
            }
            catch (Exception ex)
            {
                ErrorMessageHelper.ShowDatabaseError(this, "load member plan", ex);
            }
            finally
            {
                if (con.State == ConnectionState.Open)
                    con.Close();
            }
        }

        void LoadPayments()
        {
            try
            {
                using (var cmd = DatabaseHelper.CreateCommand(
                    "SELECT pay.PaymentID, pay.MemberID, m.FullName, pay.PlanID, p.PlanName, pay.Amount, pay.PaymentDate, pay.Status " +
                    "FROM Payments pay JOIN Members m ON pay.MemberID = m.MemberID " +
                    "LEFT JOIN MembershipPlans p ON pay.PlanID = p.PlanID ORDER BY pay.PaymentID DESC", con))
                {
                    if (con.State == ConnectionState.Closed)
                        con.Open();

                    var dt = new DataTable();
                    using (var reader = cmd.ExecuteReader())
                        dt.Load(reader);

                    dgvPayments.DataSource = dt;
                    dgvPayments.BringToFront();
                    DataGridHelper.ConfigureReadOnlyGrid(dgvPayments);
                }
            }
            catch (Exception ex)
            {
                ErrorMessageHelper.ShowDatabaseError(this, "load payments", ex);
            }
            finally
            {
                if (con.State == ConnectionState.Open)
                    con.Close();
            }
        }

        private void btnPayAdd_Click(object sender, EventArgs e)
        {
            if (cmbPayMember.SelectedIndex == -1 || string.IsNullOrWhiteSpace(cmbPayStatus.Text))
            {
                MessageBox.Show("Please select member and status");
                return;
            }

            int memberId = Convert.ToInt32(cmbPayMember.SelectedValue);
            int? planId = null;

            try
            {
                con.Open();

                using (var planCmd = DatabaseHelper.CreateCommand(
                    "SELECT PlanID FROM Members WHERE MemberID=@MemberID", con))
                {
                    planCmd.Parameters.Add(DatabaseHelper.Param("@MemberID", memberId));
                    object planObj = planCmd.ExecuteScalar();
                    if (planObj != null && planObj != DBNull.Value)
                        planId = Convert.ToInt32(planObj);
                }

                using (var insertCmd = DatabaseHelper.CreateCommand(
                    "INSERT INTO Payments (MemberID, PlanID, Amount, PaymentDate, Status) " +
                    "VALUES (@MemberID, @PlanID, @Amount, @PaymentDate, @Status)", con))
                {
                    insertCmd.Parameters.Add(DatabaseHelper.Param("@MemberID", memberId));
                    insertCmd.Parameters.Add(DatabaseHelper.Param("@PlanID", (object)planId ?? DBNull.Value));
                    insertCmd.Parameters.Add(DatabaseHelper.Param("@Amount", Convert.ToDecimal(numPayAmount.Value)));
                    insertCmd.Parameters.Add(DatabaseHelper.Param("@PaymentDate", dtpPayDate.Value.Date));
                    insertCmd.Parameters.Add(DatabaseHelper.Param("@Status", cmbPayStatus.Text));

                    insertCmd.ExecuteNonQuery();
                }

                MessageBox.Show("Payment recorded successfully");
                ClearFields();
                LoadPayments();
            }
            catch (Exception ex)
            {
                ErrorMessageHelper.ShowDatabaseError(this, "record payment", ex);
            }
            finally
            {
                if (con.State == ConnectionState.Open)
                    con.Close();
            }
        }

        void ClearFields()
        {
            cmbPayMember.SelectedIndex = -1;
            txtPayPlan.Text = "";
            numPayAmount.Value = 0;
            dtpPayDate.Value = DateTime.Today;
            cmbPayStatus.Text = "";
        }

        private void btnPayClear_Click(object sender, EventArgs e)
        {
            ClearFields();
        }
    }
}
