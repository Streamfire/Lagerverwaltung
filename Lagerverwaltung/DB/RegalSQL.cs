using System.Collections.Generic;
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

        public static bool ErstelleRegal()
        {
            return true;
        }

        public static List<Regal> HoleAlleRegale()
        {
            return HoleAlleRegale(int.MaxValue);
        }

        public static List<Regal> HoleAlleRegale(int limit)
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
                    var _list = new List<Regal>();
                    while (reader.Read())
                    {
                        _list.Add(new Regal((ushort)reader.GetInt16(0),(ushort)reader.GetInt16(1),reader.GetString(2),reader.GetByte(3), reader.GetByte(4), reader.GetDateTime(5),reader.GetDateTime(6),reader.GetFloat(7), reader.GetFloat(8), reader.GetFloat(9), reader.GetFloat(10), reader.GetFloat(11)));
                    }
                    return _list;
                }
            }
        }

        public static Regal HoleRegal(int regal_id)
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
                    return new Regal((ushort)reader.GetInt16(0), (ushort)reader.GetInt16(1), reader.GetString(2), reader.GetByte(3), reader.GetByte(4), reader.GetDateTime(5), reader.GetDateTime(6), reader.GetFloat(7), reader.GetFloat(8), reader.GetFloat(9), reader.GetFloat(10), reader.GetFloat(11));
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
                System.Console.WriteLine("Affected Rows: {0}", result.ToString()); //Testzwecken
                return result == 0 ? false : true;
            }
        }
    }
}
