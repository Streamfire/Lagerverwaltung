using Lagerverwaltung.Core;
using Npgsql;

namespace Lagerverwaltung.Model
{
    public static class RegalModel
    {
        private static readonly NpgsqlConnection conn;

        static RegalModel()
        {
            conn = DatabaseFactory.GetFactory().GetConnection();
        }

        public static bool ErstelleRegal()
        {
            return true;
        }
    }
}
