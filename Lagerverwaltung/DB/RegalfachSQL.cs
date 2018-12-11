using System.Diagnostics.Contracts;
using Lagerverwaltung.Core;
using Lagerverwaltung.Model;
using Npgsql;

namespace Lagerverwaltung.DB
{
    public static class RegalfachSQL
    {
        private static readonly NpgsqlConnection conn;

        static RegalfachSQL()
        {
            conn = DatabaseFactory.GetFactory().GetConnection();
        }

        public static bool ErstelleRegalfach(string name, short regalID, string bemerkung, float hoehe, float breite, float laenge)
        {
            using (var cmd = new NpgsqlCommand())
            {
                cmd.Connection = conn;
                cmd.CommandText = "INSERT INTO regalfach (name, regal_id,bemerkung, hoehe, breite, laenge) VALUES (@name,@regalID,@bemerkung,@hoehe,@breite,@laenge)";
                cmd.Parameters.AddWithValue("name", name);
                cmd.Parameters.AddWithValue("regalID", regalID);
                cmd.Parameters.AddWithValue("bemerkung", bemerkung);
                cmd.Parameters.AddWithValue("hoehe", hoehe);
                cmd.Parameters.AddWithValue("breite", breite);
                cmd.Parameters.AddWithValue("laenge", laenge);
                int result = cmd.ExecuteNonQuery();
                return result == 0 ? false : true;
            }
        }

        public static void HoleAlleRegalfach()
        {
            HoleAlleRegalfach(short.MaxValue);
        }

        public static void HoleAlleRegalfach(short limit)
        {
            Contract.Requires(limit >= 1);

            using (var cmd = new NpgsqlCommand())
            {
                cmd.Connection = conn;
                cmd.CommandText = "SELECT * FROM regalfach LIMIT @num;";
                cmd.Parameters.AddWithValue("num", limit);

                // Prüfe noch auch irgendwelche Fehler etc.
                using (var reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        // wenn feld null dann Exception!
                        new Regalfach((ushort)reader.GetInt16(0),(ushort)reader.GetInt16(4),reader.GetString(1),reader.GetDateTime(2), reader.GetDateTime(3),reader.GetFloat(6), reader.GetFloat(8), reader.GetFloat(7),reader.GetString(5));
                    }
                }
            }
        }

        public static Regalfach HoleRegalfach(short regalfach_id)
        {
            using (var cmd = new NpgsqlCommand())
            {
                cmd.Connection = conn;
                cmd.CommandText = "SELECT * FROM regalfach WHERE regalfach_id = @regalfach_id;";
                cmd.Parameters.AddWithValue("regalfach_id", regalfach_id);

                // Prüfe noch auch irgendwelche Fehler etc.
                using (var reader = cmd.ExecuteReader())
                {
                    reader.Read();
                    var ret =new Regalfach((ushort)reader.GetInt16(0), (ushort)reader.GetInt16(4), reader.GetString(1), reader.GetDateTime(2), reader.GetDateTime(3), reader.GetFloat(5), reader.GetFloat(6), reader.GetFloat(7), reader.GetString(8));
					return ret;
                }
            }
        }

        public static void HoleLastXRegalfach(int anzahl)
        {
            using (var cmd = new NpgsqlCommand())
            {
                cmd.Connection = conn;
                cmd.CommandText = "SELECT * FROM regalfach ORDER BY erstellt_am DESC LIMIT @limit;";
                cmd.Parameters.AddWithValue("limit", anzahl);

                // Prüfe noch auch irgendwelche Fehler etc.
                using (var reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        // wenn feld null dann Exception!
                        new Regalfach((ushort)reader.GetInt16(0), (ushort)reader.GetInt16(4), reader.GetString(1), reader.GetDateTime(2), reader.GetDateTime(3), reader.GetFloat(6), reader.GetFloat(8), reader.GetFloat(7), reader.GetString(5));
                    }
                }
            }
        }

        public static bool LoescheRegalfach(int regalfach_id)
        {
            using (var cmd = new NpgsqlCommand())
            {
                cmd.Connection = conn;
                cmd.CommandText = "DELETE FROM regalfach WHERE regalfach_id = @regalfach_id;";
                cmd.Parameters.AddWithValue("regalfach_id", regalfach_id);
                int result = cmd.ExecuteNonQuery();
                return result == 0 ? false : true;
            }
        }
    }
}
