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

        public static void HoleAllePakete()
        {
            HoleAllePakete(int.MaxValue);
        }

        public static void HoleAllePakete(int limit)
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
                    while (reader.Read())
                    {
                        new Paket((uint)reader.GetInt32(0),(ushort)reader.GetInt16(4),reader.GetString(1),(ushort)reader.GetInt16(6),reader.GetDateTime(2),reader.GetDateTime(3),reader.GetDateTime(7),(uint)reader.GetInt32(5),reader.GetFloat(9), reader.GetFloat(10), reader.GetFloat(11),reader.GetString(8));
                    }
                }
            }
        }

        public static void HolePaket(int paket_id)
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
                    new Paket((uint)reader.GetInt32(0), (ushort)reader.GetInt16(4), reader.GetString(1), (ushort)reader.GetInt16(6), reader.GetDateTime(2), reader.GetDateTime(3), reader.GetDateTime(7), (uint)reader.GetInt32(5), reader.GetFloat(9), reader.GetFloat(10), reader.GetFloat(11), reader.GetString(8));
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
                return result == 0 ? false : true;
            }
        }
    }
}
