using Lagerverwaltung.Core;
using Npgsql;

namespace Lagerverwaltung.Model
{
    public static class ProduktModel
    {
        private static readonly NpgsqlConnection conn;

        static ProduktModel()
        {
            conn = DatabaseFactory.GetFactory().GetConnection();
        }

        public static bool ErstelleProdukt()
        {
            return true;
        }
    }
}
