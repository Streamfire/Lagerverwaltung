using Lagerverwaltung.Core;
using Npgsql;

namespace Lagerverwaltung.Model
{
    public static class HistorieModel
    {
        private static readonly NpgsqlConnection conn;

        static HistorieModel()
        {
            conn = DatabaseFactory.GetFactory().GetConnection();
        }

        public static bool HoleHistorie()
        {
            return true;
        }
        // nur lesende Funktionen, da Historie durch die Datenbank Trigger später erstellt werden!
    }
}
