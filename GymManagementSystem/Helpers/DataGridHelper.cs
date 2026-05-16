using System.Windows.Forms;

namespace GymManagementSystem.Helpers
{
    public static class DataGridHelper
    {
        public static void ConfigureReadOnlyGrid(DataGridView grid)
        {
            grid.ReadOnly = true;
            grid.AllowUserToAddRows = false;
            grid.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            grid.MultiSelect = false;
            grid.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        }
    }
}
