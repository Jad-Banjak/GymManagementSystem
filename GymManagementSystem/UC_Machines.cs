using GymManagementSystem.Helpers;
using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace GymManagementSystem
{
    public partial class UC_Machines : UserControl
    {
        readonly SqlConnection con = DatabaseHelper.CreateConnection();
        int machineId;

        public UC_Machines()
        {
            InitializeComponent();
        }

        private void UC_Machines_Load(object sender, EventArgs e)
        {
            LoadMachines();
        }

        void ClearFields()
        {
            txtMachineName.Clear();
            cmbCategory.Text = "";
            cmbCondition.Text = "";
            cmbMachineStatus.Text = "";
            dtpPurchaseDate.Value = DateTime.Today;
            machineId = 0;
        }

        void LoadMachines()
        {
            try
            {
                using (var cmd = DatabaseHelper.CreateCommand(
                    "SELECT MachineID, MachineName, Category, PurchaseDate, [Condition], Status FROM Machines", con))
                {
                    if (con.State == ConnectionState.Closed)
                        con.Open();

                    var dt = new DataTable();
                    using (var reader = cmd.ExecuteReader())
                        dt.Load(reader);

                    dgvMachines.DataSource = dt;
                    dgvMachines.BringToFront();
                    DataGridHelper.ConfigureReadOnlyGrid(dgvMachines);
                }
            }
            catch (Exception ex)
            {
                ErrorMessageHelper.ShowDatabaseError(this, "load machines", ex);
            }
            finally
            {
                if (con.State == ConnectionState.Open)
                    con.Close();
            }
        }

        private void btnMachineAdd_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtMachineName.Text) ||
                string.IsNullOrWhiteSpace(cmbCategory.Text) ||
                string.IsNullOrWhiteSpace(cmbCondition.Text) ||
                string.IsNullOrWhiteSpace(cmbMachineStatus.Text))
            {
                MessageBox.Show("Please fill all fields");
                return;
            }

            try
            {
                using (var cmd = DatabaseHelper.CreateCommand(
                    "INSERT INTO Machines (MachineName, Category, PurchaseDate, [Condition], Status) " +
                    "VALUES (@MachineName, @Category, @PurchaseDate, @Condition, @Status)", con))
                {
                    cmd.Parameters.Add(DatabaseHelper.Param("@MachineName", txtMachineName.Text.Trim()));
                    cmd.Parameters.Add(DatabaseHelper.Param("@Category", cmbCategory.Text));
                    cmd.Parameters.Add(DatabaseHelper.Param("@PurchaseDate", dtpPurchaseDate.Value.Date));
                    cmd.Parameters.Add(DatabaseHelper.Param("@Condition", cmbCondition.Text));
                    cmd.Parameters.Add(DatabaseHelper.Param("@Status", cmbMachineStatus.Text));

                    con.Open();
                    cmd.ExecuteNonQuery();
                }

                MessageBox.Show("Machine added successfully");
                ClearFields();
                LoadMachines();
            }
            catch (Exception ex)
            {
                ErrorMessageHelper.ShowDatabaseError(this, "add machine", ex);
            }
            finally
            {
                if (con.State == ConnectionState.Open)
                    con.Close();
            }
        }

        private void btnMachineUpdate_Click(object sender, EventArgs e)
        {
            if (machineId == 0)
            {
                MessageBox.Show("Please select a machine to update");
                return;
            }

            try
            {
                using (var cmd = DatabaseHelper.CreateCommand(
                    "UPDATE Machines SET MachineName=@MachineName, Category=@Category, PurchaseDate=@PurchaseDate, " +
                    "[Condition]=@Condition, Status=@Status WHERE MachineID=@MachineID", con))
                {
                    cmd.Parameters.Add(DatabaseHelper.Param("@MachineName", txtMachineName.Text.Trim()));
                    cmd.Parameters.Add(DatabaseHelper.Param("@Category", cmbCategory.Text));
                    cmd.Parameters.Add(DatabaseHelper.Param("@PurchaseDate", dtpPurchaseDate.Value.Date));
                    cmd.Parameters.Add(DatabaseHelper.Param("@Condition", cmbCondition.Text));
                    cmd.Parameters.Add(DatabaseHelper.Param("@Status", cmbMachineStatus.Text));
                    cmd.Parameters.Add(DatabaseHelper.Param("@MachineID", machineId));

                    con.Open();
                    cmd.ExecuteNonQuery();
                }

                MessageBox.Show("Machine updated successfully");
                ClearFields();
                LoadMachines();
            }
            catch (Exception ex)
            {
                ErrorMessageHelper.ShowDatabaseError(this, "update machine", ex);
            }
            finally
            {
                if (con.State == ConnectionState.Open)
                    con.Close();
            }
        }

        private void btnMachineDelete_Click(object sender, EventArgs e)
        {
            if (machineId == 0)
            {
                MessageBox.Show("Please select a machine to delete");
                return;
            }

            if (MessageBox.Show("Delete this machine?", "Confirm", MessageBoxButtons.YesNo, MessageBoxIcon.Question) != DialogResult.Yes)
                return;

            try
            {
                using (var cmd = DatabaseHelper.CreateCommand("DELETE FROM Machines WHERE MachineID=@MachineID", con))
                {
                    cmd.Parameters.Add(DatabaseHelper.Param("@MachineID", machineId));
                    con.Open();
                    cmd.ExecuteNonQuery();
                }

                MessageBox.Show("Machine deleted successfully");
                ClearFields();
                LoadMachines();
            }
            catch (Exception ex)
            {
                ErrorMessageHelper.ShowDatabaseError(this, "delete machine", ex);
            }
            finally
            {
                if (con.State == ConnectionState.Open)
                    con.Close();
            }
        }

        private void dgvMachines_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0) return;

            machineId = Convert.ToInt32(dgvMachines.Rows[e.RowIndex].Cells["MachineID"].Value);
            txtMachineName.Text = dgvMachines.Rows[e.RowIndex].Cells["MachineName"].Value.ToString();
            cmbCategory.Text = dgvMachines.Rows[e.RowIndex].Cells["Category"].Value.ToString();
            cmbCondition.Text = dgvMachines.Rows[e.RowIndex].Cells["Condition"].Value.ToString();
            cmbMachineStatus.Text = dgvMachines.Rows[e.RowIndex].Cells["Status"].Value.ToString();

            if (dgvMachines.Rows[e.RowIndex].Cells["PurchaseDate"].Value != DBNull.Value)
                dtpPurchaseDate.Value = Convert.ToDateTime(dgvMachines.Rows[e.RowIndex].Cells["PurchaseDate"].Value);
        }

        private void btnMachineClear_Click(object sender, EventArgs e)
        {
            ClearFields();
        }
    }
}
