using System.Diagnostics.Contracts;
using Lagerverwaltung.Core;
using Lagerverwaltung.Model;
using Npgsql;

namespace Lagerverwaltung.DB
{
    public static class RegalSQL
    {
        private static readonly NpgsqlConnection conn;

        static RegalSQL()
        {
            conn = DatabaseFactory.GetFactory().GetConnection();
        }

        public static int ErstelleRegal(string name, short lagerID, short zeilen, short spalten, float hoehe, float breite, float laenge, float wandH, float wandV)
        {
            using (var cmd = new NpgsqlCommand())
            {
                cmd.Connection = conn;
                cmd.CommandText = "INSERT INTO regal (name, lager_id, zeilen, spalten, höhe, breite, länge, v_wandstärke, h_wandstärke) VALUES (@name,@lagerID,@zeilen,@spalten,@hoehe,@breite,@laenge,@wandV,@wandH) RETURNING regal_id;";

                cmd.Parameters.AddWithValue("name", name);
                cmd.Parameters.AddWithValue("lagerID", lagerID);
                cmd.Parameters.AddWithValue("zeilen", zeilen);
                cmd.Parameters.AddWithValue("spalten", spalten);
                cmd.Parameters.AddWithValue("hoehe", hoehe);
                cmd.Parameters.AddWithValue("breite", breite);
                cmd.Parameters.AddWithValue("laenge", laenge);
                cmd.Parameters.AddWithValue("wandV", wandV);
                cmd.Parameters.AddWithValue("wandH", wandH);
                int id = (short)cmd.ExecuteScalar();
                return id;
            }
        }

        public static void HoleAlleRegale()
        {
            HoleAlleRegale(int.MaxValue);
        }

        public static void HoleAlleRegale(int limit)
        {
            Contract.Requires(limit >= 1);

            using (var cmd = new NpgsqlCommand())
            {
                cmd.Connection = conn;
                cmd.CommandText = "SELECT * FROM regal LIMIT @num;";
                cmd.Parameters.AddWithValue("num", limit);

                // Prüfe noch auch irgendwelche Fehler etc.
                using (var reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        // wenn feld null dann Exception!
                        new Regal((ushort)reader.GetInt16(0),(ushort)reader.GetInt16(4),reader.GetString(1),reader.GetByte(5), reader.GetByte(6), reader.GetDateTime(2),reader.GetDateTime(3),reader.GetFloat(7), reader.GetFloat(8), reader.GetFloat(9), reader.GetFloat(10), reader.GetFloat(11));
                    }
                }
            }
        }

        public static void HoleRegal(int regal_id)
        {
            using (var cmd = new NpgsqlCommand())
            {
                cmd.Connection = conn;
                cmd.CommandText = "SELECT * FROM regal WHERE regal_id = @regal_id;";
                cmd.Parameters.AddWithValue("regal_id", regal_id);

                // Prüfe noch auch irgendwelche Fehler etc.
                using (var reader = cmd.ExecuteReader())
                {
                    reader.Read();
                    new Regal((ushort)reader.GetInt16(0), (ushort)reader.GetInt16(4), reader.GetString(1), reader.GetByte(5), reader.GetByte(6), reader.GetDateTime(2), reader.GetDateTime(3), reader.GetFloat(7), reader.GetFloat(8), reader.GetFloat(9), reader.GetFloat(10), reader.GetFloat(11));
                }
            }
        }

        public static bool LoescheRegal(int regal_id)
        {
            using (var cmd = new NpgsqlCommand())
            {
                cmd.Connection = conn;
                cmd.CommandText = "DELETE FROM regal WHERE regal_id = @regal_id;";
                cmd.Parameters.AddWithValue("regal_id", regal_id);
                int result = cmd.ExecuteNonQuery();
                return result == 0 ? false : true;
            }
        }
    }
}
