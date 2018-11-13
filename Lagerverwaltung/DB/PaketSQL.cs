using System.Collections.Generic;
using System.Diagnostics.Contracts;
using Lagerverwaltung.Core;
using Lagerverwaltung.Model;
using Npgsql;

namespace Lagerverwaltung.DB
{
    public static class PaketSQL
    {
        private static readonly NpgsqlConnection conn;

        static PaketSQL()
        {
            conn = DatabaseFactory.GetFactory().GetConnection();
        }

        public static bool ErstellePaket()
        {
            return true;
        }

        public static List<Paket> HoleAllePakete()
        {
            return HoleAllePakete(int.MaxValue);
        }

        public static List<Paket> HoleAllePakete(int limit)
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
                    var _list = new List<Paket>();
                    while (reader.Read())
                    {
                        _list.Add(new Paket((uint)reader.GetInt32(0),(ushort)reader.GetInt16(1),reader.GetString(2),(ushort)reader.GetInt16(3),reader.GetDateTime(4),reader.GetDateTime(5),reader.GetDateTime(6),(uint)reader.GetInt32(7),reader.GetFloat(8), reader.GetFloat(9), reader.GetFloat(10),reader.GetString(11)));
                    }
                    return _list;
                }
            }
        }

        public static Paket HolePaket(int paket_id)
        {
            using (var cmd = new NpgsqlCommand())
            {
                cmd.Connection = conn;
                cmd.CommandText = "SELECT * FROM paket WHERE paket_id = @paket_id;";
                cmd.Parameters.AddWithValue("paket_id", paket_id);

                // Prüfe noch auch irgendwelche Fehler etc.
                using (var reader = cmd.ExecuteReader())
                {
                    reader.Read();
                    return new Paket((uint)reader.GetInt32(0), (ushort)reader.GetInt16(1), reader.GetString(2), (ushort)reader.GetInt16(3), reader.GetDateTime(4), reader.GetDateTime(5), reader.GetDateTime(6), (uint)reader.GetInt32(7), reader.GetFloat(8), reader.GetFloat(9), reader.GetFloat(10), reader.GetString(11));
                }
            }
        }

        public static bool LoeschePaket(int paket_id)
        {
            using (var cmd = new NpgsqlCommand())
            {
                cmd.Connection = conn;
                cmd.CommandText = "DELETE FROM paket WHERE paket_id = @paket_id;";
                cmd.Parameters.AddWithValue("paket_id", paket_id);
                int result = cmd.ExecuteNonQuery();
                System.Console.WriteLine("Affected Rows: {0}", result.ToString()); //Testzwecken
                return result == 0 ? false : true;
            }
        }
    }
}
