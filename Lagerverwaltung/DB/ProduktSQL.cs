using System.Collections.Generic;
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

        public static List<Produkt> HoleAlleProdukte()
        {
            return HoleAlleProdukte(int.MaxValue);
        }

        public static List<Produkt> HoleAlleProdukte(int limit)
        {
            Contract.Requires(limit >= 1);

            using (var cmd = new NpgsqlCommand())
            {
                cmd.Connection = conn;
                cmd.CommandText = "SELECT * FROM paket LIMIT @num;";
                cmd.Parameters.AddWithValue("num", limit);

                // Prüfe noch auch irgendwelche Fehler etc.
                using (var reader = cmd.ExecuteReader())
                {
                    var _list = new List<Produkt>();
                    while (reader.Read())
                    {
                        _list.Add(new Produkt((uint)reader.GetInt32(0), reader.GetString(1), reader.GetString(2),reader.GetFloat(3), reader.GetFloat(4),reader.GetDateTime(5), reader.GetDateTime(6),(ushort)reader.GetInt16(7), reader.GetFloat(8), reader.GetFloat(9), reader.GetFloat(10)));
                    }
                    return _list;
                }
            }
        }

        public static Produkt HoleProdukt(int produkt_id)
        {
            using (var cmd = new NpgsqlCommand())
            {
                cmd.Connection = conn;
                cmd.CommandText = "SELECT * FROM paket WHERE produkt_id = @produkt_id;";
                cmd.Parameters.AddWithValue("produkt_id", produkt_id);

                // Prüfe noch auch irgendwelche Fehler etc.
                using (var reader = cmd.ExecuteReader())
                {
                    reader.Read();
                    return new Produkt((uint)reader.GetInt32(0), reader.GetString(1), reader.GetString(2), reader.GetFloat(3), reader.GetFloat(4), reader.GetDateTime(5), reader.GetDateTime(6), (ushort)reader.GetInt16(7), reader.GetFloat(8), reader.GetFloat(9), reader.GetFloat(10));
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
                System.Console.WriteLine("Affected Rows: {0}", result.ToString()); //Testzwecken
                return result == 0 ? false : true;
            }
        }
    }
}
