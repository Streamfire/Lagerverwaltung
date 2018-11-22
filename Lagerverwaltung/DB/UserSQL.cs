using System.Diagnostics.Contracts;
using Lagerverwaltung.Core;
using Lagerverwaltung.Model;
using Npgsql;

namespace Lagerverwaltung.DB
{
    public static class UserSQL
    {
        private static readonly NpgsqlConnection conn;

        static UserSQL()
        {
            conn = DatabaseFactory.GetFactory().GetConnection();
        }

        public static bool ErstelleUser(string vorname, string nachname, string username, short rollen_id, string password, string salt)
        {
            using (var cmd = new NpgsqlCommand())
            {
                cmd.Connection = conn;
                cmd.CommandText = "INSERT INTO user (vorname, nachname,username,rollen_id,password,salt) VALUES (@vorname, @nachname,@username,@rollen_id,@password,@salt);";
                cmd.Parameters.AddWithValue("vorname", vorname);
                cmd.Parameters.AddWithValue("nachname", nachname);
                cmd.Parameters.AddWithValue("username", username);
                cmd.Parameters.AddWithValue("rollen_id", rollen_id);
                cmd.Parameters.AddWithValue("password", password);
                cmd.Parameters.AddWithValue("salt", salt);
                int result = cmd.ExecuteNonQuery();
                return result == 0 ? false : true;
            }
        }

        public static void HoleAlleUser()
        {
            HoleAlleUser(short.MaxValue);
        }

        public static void HoleAlleUser(short limit)
        {
            Contract.Requires(limit >= 1);

            using (var cmd = new NpgsqlCommand())
            {
                cmd.Connection = conn;
                cmd.CommandText = "SELECT * FROM \"user\" LIMIT @limit;";
                cmd.Parameters.AddWithValue("limit", limit);

                // Prüfe noch auch irgendwelche Fehler etc.
                using (var reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        // wenn feld null dann Exception!
                        new User((ushort)reader.GetInt16(0),(ushort)reader.GetInt16(6),reader.GetString(1),reader.GetString(2),reader.GetString(7),reader.GetDateTime(3), reader.GetDateTime(4), reader.GetDateTime(5));
                    }
                }
            }
        }

        public static void HoleUser(ushort user_id)
        {
            using (var cmd = new NpgsqlCommand())
            {
                cmd.Connection = conn;
                cmd.CommandText = "SELECT * FROM \"user\" WHERE user_id = @user_id;";
                cmd.Parameters.AddWithValue("user_id", user_id);

                // Prüfe noch auch irgendwelche Fehler etc.
                using (var reader = cmd.ExecuteReader())
                {
                    reader.Read();
                    new User((ushort)reader.GetInt16(0), (ushort)reader.GetInt16(6), reader.GetString(1), reader.GetString(2), reader.GetString(7), reader.GetDateTime(3), reader.GetDateTime(4), reader.GetDateTime(5));
                }
            }
        }

        public static bool LoescheUser(ushort user_id)
        {
            using (var cmd = new NpgsqlCommand())
            {
                cmd.Connection = conn;
                cmd.CommandText = "DELETE FROM user WHERE user_id = @user_id;";
                cmd.Parameters.AddWithValue("user_id", user_id);
                int result = cmd.ExecuteNonQuery();
                return result == 0 ? false : true;
            }
        }
    }
}