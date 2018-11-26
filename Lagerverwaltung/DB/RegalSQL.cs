﻿using System.Diagnostics.Contracts;
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