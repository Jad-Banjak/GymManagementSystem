using System;

namespace GymManagementSystem.Helpers
{
    public static class AuthRoles
    {
        public const string Admin = "Admin";
        public const string Staff = "Staff";

        public static bool IsAdmin(string role)
        {
            return string.Equals(role, Admin, StringComparison.OrdinalIgnoreCase);
        }
    }
}
