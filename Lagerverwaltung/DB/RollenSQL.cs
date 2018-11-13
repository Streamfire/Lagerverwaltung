using System.Collections.Generic;
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
                System.Console.WriteLine("Affected Rows: {0}", result.ToString()); //Testzwecken
                return result == 0 ? false : true;
            }
        }

        public static List<Rolle> HoleAlleRollen()
        {
            return HolleAlleRollen(short.MaxValue);
        }

        public static List<Rolle> HolleAlleRollen(short limit)
        {
            using (var cmd = new NpgsqlCommand())
            {
                cmd.Connection = conn;
                cmd.CommandText = "SELECT * FROM rolle LIMIT @limit;";
                cmd.Parameters.AddWithValue("limit", limit);

                // Prüfe noch auch irgendwelche Fehler etc.
                using (var reader = cmd.ExecuteReader())
                {
                    var _list = new List<Rolle>();
                    while (reader.Read())
                    {
                        _list.Add(new Rolle((ushort)reader.GetInt16(0), reader.GetString(1), reader.GetString(2), reader.GetDateTime(3), reader.GetDateTime(4)));
                    }
                    return _list;
                }
            }
        }

        public static Rolle HoleRolle(ushort rollen_id)
        {
            using (var cmd = new NpgsqlCommand())
            {
                cmd.Connection = conn;
                cmd.CommandText = "SELECT * FROM lagertyp WHERE rollen_id = @rollen_id;";
                cmd.Parameters.AddWithValue("rollen_id", rollen_id);

                // Prüfe noch auch irgendwelche Fehler etc.
                using (var reader = cmd.ExecuteReader())
                {
                    reader.Read();
                    return new Rolle((ushort)reader.GetInt16(0), reader.GetString(1), reader.GetString(2), reader.GetDateTime(3), reader.GetDateTime(4));
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
                System.Console.WriteLine("Affected Rows: {0}", result.ToString()); //Testzwecken
                return result == 0 ? false : true;
            }
        }
    }
}
