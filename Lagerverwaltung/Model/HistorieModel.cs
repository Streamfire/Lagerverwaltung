using System.Diagnostics.Contracts;
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

        public static void HoleHistorie()
        {
            HoleHistorie(long.MaxValue);
        }

        public static void HoleHistorie(long limit)
        {
            Contract.Requires(limit >= 1);

            using (var cmd = new NpgsqlCommand())
            {
                cmd.Connection = conn;
                cmd.CommandText = "SELECT * FROM historie LIMIT @num;";
                cmd.Parameters.AddWithValue("num", limit);

                // Prüfe noch auch irgendwelche Fehler etc.
                using (var reader = cmd.ExecuteReader())
                {
                    while(reader.Read())
                    {
                        System.Console.WriteLine("Historie: {0}, {1}, {2}, {3}", reader.GetInt64(0), reader.GetInt16(1), reader.GetString(2), reader.GetTimeStamp(3));
                    }
                }
            }
        }
        // nur lesende Funktionen, da Historie durch die Datenbank Trigger später erstellt werden!
    }
}
