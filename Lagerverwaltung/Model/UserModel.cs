using System.Collections.Generic;
using System.Diagnostics.Contracts;
using Lagerverwaltung.Core;
using Npgsql;

namespace Lagerverwaltung.Model
{
    public static class UserModel
    {
        private static readonly NpgsqlConnection conn;

        static UserModel()
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
                System.Console.WriteLine("Affected Rows: {0}", result.ToString()); //Testzwecken
                return result == 0 ? false : true;
            }
        }

        // return typ ändern!
        public static List<User> HoleAlleUser()
        {
            return HoleAlleUser(short.MaxValue);
        }

        // return typ ändern!
        public static List<User> HoleAlleUser(short limit)
        {
            Contract.Requires(limit >= 1);

            using (var cmd = new NpgsqlCommand())
            {
                cmd.Connection = conn;
                cmd.CommandText = "SELECT * FROM user LIMIT @limit;";
                cmd.Parameters.AddWithValue("limit", limit);

                // Prüfe noch auch irgendwelche Fehler etc.
                using (var reader = cmd.ExecuteReader())
                {
                    var _list = new List<User>();
                    while (reader.Read())
                    {
                        _list.Add(new User((ushort)reader.GetInt16(0),(ushort)reader.GetInt16(1),reader.GetString(2),reader.GetString(3),reader.GetString(4),reader.GetTimeStamp(5).ToDateTime(), reader.GetTimeStamp(6).ToDateTime(), reader.GetTimeStamp(7).ToDateTime()));
                    }
                    return _list;
                }
            }
        }

        public static User HoleUser(ushort user_id)
        {
            using (var cmd = new NpgsqlCommand())
            {
                cmd.Connection = conn;
                cmd.CommandText = "SELECT * FROM user WHERE user_id = @user_id;";
                cmd.Parameters.AddWithValue("user_id", user_id);

                // Prüfe noch auch irgendwelche Fehler etc.
                using (var reader = cmd.ExecuteReader())
                {
                    reader.Read();
                    return new User((ushort)reader.GetInt16(0), (ushort)reader.GetInt16(1), reader.GetString(2), reader.GetString(3), reader.GetString(4), reader.GetDateTime(5), reader.GetDateTime(6), reader.GetDateTime(7));
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
                System.Console.WriteLine("Affected Rows: {0}", result.ToString()); //Testzwecken
                return result == 0 ? false : true;
            }
        }
    }
}