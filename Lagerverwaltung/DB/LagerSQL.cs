﻿using System.Collections.Generic;
using Lagerverwaltung.Core;
using Lagerverwaltung.Model;
using Npgsql;

namespace Lagerverwaltung.DB
{
    public static class LagerSQL
    {
        private static readonly NpgsqlConnection conn;

        static LagerSQL()
        {
            conn = DatabaseFactory.GetFactory().GetConnection();
        }

        // Funktioniert, aber Exception Handling fehlt!
        public static bool ErstelleLager(string name, short lagertyp, string standort ="", string beschreibung="")
        {
            using (var cmd = new NpgsqlCommand())
            {
                cmd.Connection = conn;
                cmd.CommandText = "INSERT INTO lager (name, standort, beschreibung,lagertyp_id) VALUES (@name,@standort,@beschreibung,@lagertyp)";
                cmd.Parameters.AddWithValue("name", name);
                cmd.Parameters.AddWithValue("standort", standort);
                cmd.Parameters.AddWithValue("beschreibung", beschreibung);
                cmd.Parameters.AddWithValue("lagertyp", lagertyp);
                int result = cmd.ExecuteNonQuery();
                System.Console.WriteLine("Affected Rows: {0}", result.ToString()); //Testzwecken
                return result == 0 ? false : true;
            }
        }

        // return typ ändern!
        public static List<Lager> HoleAlleLager()
        {
            return HoleAlleLager(short.MaxValue);
        }

        // return typ ändern!
        public static List<Lager> HoleAlleLager(short limit)
        {
            using (var cmd = new NpgsqlCommand())
            {
                cmd.Connection = conn;
                cmd.CommandText = "SELECT * FROM lager LIMIT @limit;";
                cmd.Parameters.AddWithValue("limit", limit);

                // Prüfe noch auch irgendwelche Fehler etc.
                using (var reader = cmd.ExecuteReader())
                {
                    var _list = new List<Lager>();
                    while (reader.Read())
                    {
                        // wenn feld null dann Exception!
                        _list.Add(new Lager((ushort)reader.GetInt16(0),reader.GetString(1),new System.DateTime(3), new System.DateTime(4), (ushort)reader.GetInt16(6),reader.GetString(2),reader.GetString(5)));
                    }
                    return _list;
                }
            }
        }

        // return typ ändern!
        public static Lager HoleLager(ushort lager_id)
        {
            using (var cmd = new NpgsqlCommand())
            {
                cmd.Connection = conn;
                cmd.CommandText = "SELECT * FROM lager WHERE lager_id = @lager_id;";
                cmd.Parameters.AddWithValue("lager_id", lager_id);

                // Prüfe noch auch irgendwelche Fehler etc.
                using (var reader = cmd.ExecuteReader())
                {
                    reader.Read();
                    return new Lager((ushort)reader.GetInt16(0), reader.GetString(1), new System.DateTime(3), new System.DateTime(4), (ushort)reader.GetInt16(6), reader.GetString(2), reader.GetString(5));
                }
            }
        }

        public static bool LoescheLager(ushort lager_id)
        {
            using (var cmd = new NpgsqlCommand())
            {
                cmd.Connection = conn;
                cmd.CommandText = "DELETE FROM lager WHERE lager_id = @lager_id;";
                cmd.Parameters.AddWithValue("lager_id", lager_id);
                int result = cmd.ExecuteNonQuery();
                System.Console.WriteLine("Affected Rows: {0}", result.ToString()); //Testzwecken
                return result == 0 ? false : true;
            }
        }
    }
}
