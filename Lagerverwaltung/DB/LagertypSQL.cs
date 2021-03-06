﻿using System.Diagnostics.Contracts;
using Lagerverwaltung.Core;
using Lagerverwaltung.Model;
using Npgsql;

namespace Lagerverwaltung.DB
{
    public static class LagertypSQL
    {
        private static readonly NpgsqlConnection conn;

        static LagertypSQL()
        {
            conn = DatabaseFactory.GetFactory().GetConnection();
        }

        // Funktioniert, aber Exception Handling fehlt!
        public static bool ErstelleLagertyp(string name)
        {
            using (var cmd = new NpgsqlCommand())
            {
                cmd.Connection = conn;
                cmd.CommandText = "INSERT INTO lagertyp (name) VALUES (@name)";
                cmd.Parameters.AddWithValue("name",name);
                int result = cmd.ExecuteNonQuery();
                return result==0 ? false : true;
            }
        }

        public static void HoleAlleLagertyp()
        {
            HoleAlleLagertyp(short.MaxValue);
        }

        public static void HoleAlleLagertyp(short limit)
        {
            Contract.Requires(limit >= 1);

            using (var cmd = new NpgsqlCommand())
            {
                cmd.Connection = conn;
                cmd.CommandText = "SELECT * FROM lagertyp LIMIT @limit;";
                cmd.Parameters.AddWithValue("limit", limit);

                // Prüfe noch auch irgendwelche Fehler etc.
                using (var reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        // wenn feld null dann Exception!
                        new Lagertyp((ushort)reader.GetInt16(0),reader.GetString(1),reader.GetDateTime(2),reader.GetDateTime(3));
                    }
                }
            }
        }

        public static void HoleLagertyp(ushort lagertyp_id)
        {
            using (var cmd = new NpgsqlCommand())
            {
                cmd.Connection = conn;
                cmd.CommandText = "SELECT * FROM lagertyp WHERE lagertyp_id = @lagertyp_id;";
                cmd.Parameters.AddWithValue("lagertyp_id", lagertyp_id);

                // Prüfe noch auch irgendwelche Fehler etc.
                using (var reader = cmd.ExecuteReader())
                {
                    reader.Read();
                    new Lagertyp((ushort)reader.GetInt16(0), reader.GetString(1), reader.GetDateTime(2), reader.GetDateTime(3));
                }
            }
        }

        public static bool LoescheLagertyp(ushort lagertyp_id)
        {
            using (var cmd = new NpgsqlCommand())
            {
                cmd.Connection = conn;
                cmd.CommandText = "DELETE FROM lagertyp WHERE lagertyp_id = @lagertyp_id;";
                cmd.Parameters.AddWithValue("lagertyp_id", lagertyp_id);
                int result = cmd.ExecuteNonQuery();
                return result == 0 ? false : true;
            }
        }
    }
}
