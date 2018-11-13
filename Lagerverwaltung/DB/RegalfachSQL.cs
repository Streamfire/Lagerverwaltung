using System.Collections.Generic;
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

        public static List<Regalfach> HoleAlleRegalfach()
        {
            return HoleAlleRegalfach(short.MaxValue);
        }

        public static List<Regalfach> HoleAlleRegalfach(short limit)
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
                    var _list = new List<Regalfach>();
                    while (reader.Read())
                    {
                        _list.Add(new Regalfach((ushort)reader.GetInt16(0),(ushort)reader.GetInt16(1),reader.GetString(2),reader.GetDateTime(3), reader.GetDateTime(4),reader.GetFloat(5), reader.GetFloat(6), reader.GetFloat(7),reader.GetString(8)));
                    }
                    return _list;
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
                    return new Regalfach((ushort)reader.GetInt16(0), (ushort)reader.GetInt16(1), reader.GetString(2), reader.GetDateTime(3), reader.GetDateTime(4), reader.GetFloat(5), reader.GetFloat(6), reader.GetFloat(7), reader.GetString(8));
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
                System.Console.WriteLine("Affected Rows: {0}", result.ToString()); //Testzwecken
                return result == 0 ? false : true;
            }
        }
    }
}
