﻿using Lagerverwaltung.Core;

namespace Lagerverwaltung.Model
{
    static class UserModel
    {
        public static bool ErstelleUser(string vorname, string nachname, string username, short rollen_id, string password, string salt)
        {
            var conn = DatabaseFactory.GetFactory().GetConnection();
            /*
            using (var cmd = new Npgsql.NpgsqlCommand())
            {
                cmd.Connection = conn;
                cmd.CommandText = "INSERT INTO artikeltyp (name) VALUES (@name)";
                cmd.Parameters.AddWithValue("name", name);
                int result = cmd.ExecuteNonQuery();
                System.Console.WriteLine("Affected Rows: {0}", result.ToString()); //Testzwecken
                return result == 0 ? false : true;
            }
            */
            return true;
        }


        // Spätere Datenbank-Abfragen zu userspezifischen Zeug
        public static bool HoleAlleUser()
        {
            return true;
        }

        public static bool HoleUserDurchID(int uid)
        {
            return true;
        }
    }
}