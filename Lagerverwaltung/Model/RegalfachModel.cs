using Lagerverwaltung.Core;
using Npgsql;

namespace Lagerverwaltung.Model
{
    public static class RegalfachModel
    {
        private static readonly NpgsqlConnection conn;

        static RegalfachModel()
        {
            conn = DatabaseFactory.GetFactory().GetConnection();
        }

        public static bool ErstelleRegalfach()
        {
            return true;
        }
    }
}
