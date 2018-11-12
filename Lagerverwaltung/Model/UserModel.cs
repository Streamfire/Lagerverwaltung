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
        public static bool HoleAlleUser()
        {
            return HoleAlleUser(short.MaxValue);
        }

        // return typ ändern!
        public static bool HoleAlleUser(short limit)
        {
            using (var cmd = new NpgsqlCommand())
            {
                cmd.Connection = conn;
                cmd.CommandText = "SELECT * FROM user LIMIT @limit;";
                cmd.Parameters.AddWithValue("limit", limit);
                int result = cmd.ExecuteNonQuery();
                System.Console.WriteLine("Affected Rows: {0}", result.ToString()); //Testzwecken
                return result == 0 ? false : true;
            }
        }

        // return typ ändern!
        public static bool HoleUser(ushort user_id)
        {
            using (var cmd = new NpgsqlCommand())
            {
                cmd.Connection = conn;
                cmd.CommandText = "SELECT * FROM user WHERE user_id = @user_id;";
                cmd.Parameters.AddWithValue("user_id", user_id);
                int result = cmd.ExecuteNonQuery();
                System.Console.WriteLine("Affected Rows: {0}", result.ToString()); //Testzwecken
                return result == 0 ? false : true;
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