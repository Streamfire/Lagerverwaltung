using System.Diagnostics.Contracts;
using Lagerverwaltung.Core;
using Lagerverwaltung.Model;
using Npgsql;

namespace Lagerverwaltung.DB
{
    public static class RollenSQL
    {
        private static readonly NpgsqlConnection conn;

        static RollenSQL()
        {
            conn = DatabaseFactory.GetFactory().GetConnection();
        }

        public static bool ErstelleRolle(string name, string rechte)
        {
            using (var cmd = new NpgsqlCommand())
            {
                cmd.Connection = conn;
                cmd.CommandText = "INSERT INTO rolle (name, rechte) VALUES (@name, @rechte)";
                cmd.Parameters.AddWithValue("name", name);
                cmd.Parameters.AddWithValue("rechte", rechte);
                int result = cmd.ExecuteNonQuery();
                return result == 0 ? false : true;
            }
        }

        public static void HoleAlleRollen()
        {
            HoleAlleRollen(short.MaxValue);
        }

        public static void HoleAlleRollen(short limit)
        {
            Contract.Requires(limit >= 1);

            using (var cmd = new NpgsqlCommand())
            {
                cmd.Connection = conn;
                cmd.CommandText = "SELECT * FROM rolle LIMIT @limit;";
                cmd.Parameters.AddWithValue("limit", limit);

                // Prüfe noch auch irgendwelche Fehler etc.
                using (var reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        // wenn feld null dann Exception!
                        new Rolle((ushort)reader.GetInt16(0), reader.GetString(1), reader.GetString(4), reader.GetDateTime(2), reader.GetDateTime(3));
                    }
                }
            }
        }

        public static void HoleRolle(ushort rollen_id)
        {
            using (var cmd = new NpgsqlCommand())
            {
                cmd.Connection = conn;
                cmd.CommandText = "SELECT * FROM rolle WHERE rollen_id = @rollen_id;";
                cmd.Parameters.AddWithValue("rollen_id", rollen_id);

                // Prüfe noch auch irgendwelche Fehler etc.
                using (var reader = cmd.ExecuteReader())
                {
                    reader.Read();
                    new Rolle((ushort)reader.GetInt16(0), reader.GetString(1), reader.GetString(4), reader.GetDateTime(2), reader.GetDateTime(3));
                }
            }
        }

        public static bool LoescheRolle(ushort rollen_id)
        {
            using (var cmd = new NpgsqlCommand())
            {
                cmd.Connection = conn;
                cmd.CommandText = "DELETE FROM rolle WHERE rollen_id = @rollen_id;";
                cmd.Parameters.AddWithValue("rollen_id", rollen_id);
                int result = cmd.ExecuteNonQuery();
                return result == 0 ? false : true;
            }
        }
    }
}
