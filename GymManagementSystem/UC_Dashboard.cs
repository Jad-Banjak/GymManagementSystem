using GymManagementSystem.Helpers;
using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace GymManagementSystem
{
    public partial class UC_Dashboard : UserControl
    {
        readonly SqlConnection con = DatabaseHelper.CreateConnection();

        public UC_Dashboard()
        {
            InitializeComponent();
        }

        private void UC_Dashboard_Load(object sender, EventArgs e)
        {
            LoadCounts();
            LoadRecentPayments();
            LoadExpiringSoon();
        }

        void LoadCounts()
        {
            try
            {
                if (con.State == ConnectionState.Closed)
                    con.Open();

                using (var membersCmd = DatabaseHelper.CreateCommand("SELECT COUNT(*) FROM Members", con))
                    lblMembersValue.Text = membersCmd.ExecuteScalar().ToString();

                using (var activeCmd = DatabaseHelper.CreateCommand("SELECT COUNT(*) FROM Members WHERE Status='Active'", con))
                    lblActiveValue.Text = activeCmd.ExecuteScalar().ToString();

                using (var machinesCmd = DatabaseHelper.CreateCommand("SELECT COUNT(*) FROM Machines", con))
                    lblMachinesValue.Text = machinesCmd.ExecuteScalar().ToString();

                using (var revenueCmd = DatabaseHelper.CreateCommand(
                    "SELECT ISNULL(SUM(Amount),0) FROM Payments WHERE YEAR(PaymentDate)=YEAR(GETDATE()) AND MONTH(PaymentDate)=MONTH(GETDATE())",
                    con))
                {
                    decimal revenue = Convert.ToDecimal(revenueCmd.ExecuteScalar());
                    lblRevenueValue.Text = revenue.ToString("0.00");
                }
            }
            catch (Exception ex)
            {
                ErrorMessageHelper.ShowDatabaseError(this, "load dashboard statistics", ex);
            }
            finally
            {
                if (con.State == ConnectionState.Open)
                    con.Close();
            }
        }

        void LoadRecentPayments()
        {
            try
            {
                using (var cmd = DatabaseHelper.CreateCommand(
                    "SELECT TOP 10 p.PaymentID, m.FullName, p.Amount, p.PaymentDate, p.Status " +
                    "FROM Payments p JOIN Members m ON p.MemberID = m.MemberID ORDER BY p.PaymentDate DESC", con))
                {
                    if (con.State == ConnectionState.Closed)
                        con.Open();

                    var dt = new DataTable();
                    using (var reader = cmd.ExecuteReader())
                        dt.Load(reader);

                    dgvRecentPayments.AutoGenerateColumns = true;
                    dgvRecentPayments.DataSource = dt;
                    dgvRecentPayments.ReadOnly = true;
                    dgvRecentPayments.AllowUserToAddRows = false;
                    dgvRecentPayments.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
                    dgvRecentPayments.MultiSelect = false;
                    dgvRecentPayments.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
                }
            }
            catch (Exception ex)
            {
                ErrorMessageHelper.ShowDatabaseError(this, "load recent payments", ex);
            }
            finally
            {
                if (con.State == ConnectionState.Open)
                    con.Close();
            }
        }

        void LoadExpiringSoon()
        {
            try
            {
                using (var cmd = DatabaseHelper.CreateCommand(
                    "SELECT MemberID, FullName, Phone, EndDate, Status FROM Members " +
                    "WHERE TRY_CONVERT(date, EndDate) IS NOT NULL " +
                    "AND TRY_CONVERT(date, EndDate) >= CAST(GETDATE() AS date) " +
                    "AND TRY_CONVERT(date, EndDate) <= DATEADD(day, 7, CAST(GETDATE() AS date)) " +
                    "ORDER BY TRY_CONVERT(date, EndDate) ASC", con))
                {
                    if (con.State == ConnectionState.Closed)
                        con.Open();

                    var dt = new DataTable();
                    using (var reader = cmd.ExecuteReader())
                        dt.Load(reader);

                    dgvExpiringSoon.AutoGenerateColumns = true;
                    dgvExpiringSoon.DataSource = dt;
                    dgvExpiringSoon.ReadOnly = true;
                    dgvExpiringSoon.AllowUserToAddRows = false;
                    dgvExpiringSoon.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
                    dgvExpiringSoon.MultiSelect = false;
                    dgvExpiringSoon.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
                }
            }
            catch (Exception ex)
            {
                ErrorMessageHelper.ShowDatabaseError(this, "load expiring memberships", ex);
            }
            finally
            {
                if (con.State == ConnectionState.Open)
                    con.Close();
            }
        }
    }
}
