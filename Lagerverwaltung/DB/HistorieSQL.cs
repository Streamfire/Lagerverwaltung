using System.Diagnostics.Contracts;
using Lagerverwaltung.Core;
using Lagerverwaltung.Model;
using Npgsql;

namespace Lagerverwaltung.DB
{
    public static class HistorieSQL
    {
        private static readonly NpgsqlConnection conn;

        static HistorieSQL()
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
                        // wenn feld null dann Exception!
                        new Historie((ulong)reader.GetInt64(0), (ushort)reader.GetInt16(1), reader.GetString(2), reader.GetDateTime(3));
                    }
                }
            }
        }

        public static void HoleHistorie(ulong historie_id)
        {
            using (var cmd = new NpgsqlCommand())
            {
                cmd.Connection = conn;
                cmd.CommandText = "SELECT * FROM historie WHERE log_id = @log_id;";
                cmd.Parameters.AddWithValue("log_id", (long)historie_id);

                // Prüfe noch auch irgendwelche Fehler etc.
                using (var reader = cmd.ExecuteReader())
                {
                    reader.Read();
                    new Historie((ulong)reader.GetInt64(0),(ushort)reader.GetInt16(1),reader.GetString(2), reader.GetDateTime(3));
                }
            }
        }
    }
}
