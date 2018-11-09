using Lagerverwaltung.Core;
using Npgsql;

namespace Lagerverwaltung.Model
{
    public static class PaketModel
    {
        private static readonly NpgsqlConnection conn;

        static PaketModel()
        {
            conn = DatabaseFactory.GetFactory().GetConnection();
        }

        public static bool ErstellePaket()
        {
            return true;
        }
    }
}
