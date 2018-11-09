using Lagerverwaltung.Core;
using Npgsql;

namespace Lagerverwaltung.Model
{
    public static class RollenModel
    {
        private static readonly NpgsqlConnection conn;

        static RollenModel()
        {
            conn = DatabaseFactory.GetFactory().GetConnection();
        }

        public static bool ErstelleRolle(string name, string rechte)
        {
            return true;
        }
    }
}
