using System;
using System.Diagnostics;
using System.Windows.Forms;

namespace GymManagementSystem.Helpers
{
    public static class ErrorMessageHelper
    {
        public static void ShowDatabaseError(IWin32Window owner, string actionDescription, Exception ex)
        {
            Debug.WriteLine($"[{actionDescription}] {ex}");

            string userMessage = "Unable to " + actionDescription + ". Please try again.";
#if DEBUG
            userMessage += Environment.NewLine + Environment.NewLine + ex.Message;
#endif
            MessageBox.Show(owner, userMessage, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
    }
}
