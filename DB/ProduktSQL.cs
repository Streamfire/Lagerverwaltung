using System.Diagnostics.Contracts;
using Lagerverwaltung.Core;
using Lagerverwaltung.Model;
using Npgsql;

namespace Lagerverwaltung.DB
{
    public static class ProduktSQL
    {
        private static readonly NpgsqlConnection conn;

        static ProduktSQL()
        {
            conn = DatabaseFactory.GetFactory().GetConnection();
        }

        public static bool ErstelleProdukt()
        {
            return true;
        }

        public static void HoleAlleProdukte()
        {
            HoleAlleProdukte(int.MaxValue);
        }

        public static void HoleAlleProdukte(int limit)
        {
            Contract.Requires(limit >= 1);

            using (var cmd = new NpgsqlCommand())
            {
                cmd.Connection = conn;
                cmd.CommandText = "SELECT * FROM produkt LIMIT @num;";
                cmd.Parameters.AddWithValue("num", limit);

                // Prüfe noch auch irgendwelche Fehler etc.
                using (var reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        // wenn feld null dann Exception!
                        new Produkt((uint)reader.GetInt32(0), reader.GetString(1), reader.GetString(6),reader.GetFloat(4), reader.GetFloat(5),reader.GetDateTime(2), reader.GetDateTime(3),(ushort)reader.GetInt16(7), reader.GetFloat(8), reader.GetFloat(9), reader.GetFloat(10));
                    }
                }
            }
        }

        public static void HoleProdukt(int produkt_id)
        {
            using (var cmd = new NpgsqlCommand())
            {
                cmd.Connection = conn;
                cmd.CommandText = "SELECT * FROM produkt WHERE produkt_id = @produkt_id;";
                cmd.Parameters.AddWithValue("produkt_id", produkt_id);

                // Prüfe noch auch irgendwelche Fehler etc.
                using (var reader = cmd.ExecuteReader())
                {
                    reader.Read();
                    new Produkt((uint)reader.GetInt32(0), reader.GetString(1), reader.GetString(2), reader.GetFloat(3), reader.GetFloat(4), reader.GetDateTime(5), reader.GetDateTime(6), (ushort)reader.GetInt16(7), reader.GetFloat(8), reader.GetFloat(9), reader.GetFloat(10));
                }
            }
        }

        public static bool LoescheProdukt(int produkt_id)
        {
            using (var cmd = new NpgsqlCommand())
            {
                cmd.Connection = conn;
                cmd.CommandText = "DELETE FROM produkt WHERE produkt_id = @produkt_id;";
                cmd.Parameters.AddWithValue("produkt_id", produkt_id);
                int result = cmd.ExecuteNonQuery();
                return result == 0 ? false : true;
            }
        }
    }
}
