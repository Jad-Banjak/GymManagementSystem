using GymManagementSystem.Helpers;
using System;
using System.Windows.Forms;

namespace GymManagementSystem.Main
{
    public partial class FrmMain : Form
    {
        readonly string userRole;
        readonly string userName;

        public FrmMain(string role, string fullName)
        {
            InitializeComponent();
            userRole = role ?? string.Empty;
            userName = fullName ?? string.Empty;
        }

        private void FrmMain_Load(object sender, EventArgs e)
        {
            if (!AuthRoles.IsAdmin(userRole))
            {
                btnUsers.Visible = false;
            }

            LoadDashboard();
        }

        bool EnsureAdminAccess()
        {
            if (AuthRoles.IsAdmin(userRole))
                return true;

            MessageBox.Show("Access denied. Admin privileges are required.", "Unauthorized",
                MessageBoxButtons.OK, MessageBoxIcon.Warning);
            return false;
        }

        void LoadDashboard() { LoadPage(new UC_Dashboard()); }
        void LoadMembers() { LoadPage(new UC_Members()); }
        void LoadMemberships() { LoadPage(new UC_Memberships()); }
        void LoadPayments() { LoadPage(new UC_Payments()); }
        void LoadMachines() { LoadPage(new UC_Machines()); }
        void LoadUsers()
        {
            if (!EnsureAdminAccess())
                return;

            LoadPage(new UC_Users(userRole));
        }

        private void btnDashboard_Click(object sender, EventArgs e) { LoadDashboard(); }
        private void btnMembers_Click(object sender, EventArgs e) { LoadMembers(); }
        private void btnMemberships_Click(object sender, EventArgs e) { LoadMemberships(); }
        private void btnPayments_Click(object sender, EventArgs e) { LoadPayments(); }
        private void btnMachines_Click(object sender, EventArgs e) { LoadMachines(); }
        private void btnUsers_Click(object sender, EventArgs e) { LoadUsers(); }

        void LoadPage(UserControl uc)
        {
            pnlContent.Controls.Clear();
            uc.Dock = DockStyle.Fill;
            pnlContent.Controls.Add(uc);
        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            var login = new FrmLogin();
            login.Show();
            Hide();
        }
    }
}
