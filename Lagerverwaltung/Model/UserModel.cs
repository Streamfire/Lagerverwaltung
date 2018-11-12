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
            /*
            using (var cmd = new NpgsqlCommand())
            {
                cmd.Connection = conn;
                cmd.CommandText = "INSERT INTO artikeltyp (name) VALUES (@name)";
                cmd.Parameters.AddWithValue("name", name);
                int result = cmd.ExecuteNonQuery();
                System.Console.WriteLine("Affected Rows: {0}", result.ToString()); //Testzwecken
                return result == 0 ? false : true;
            }
            */
            return false;
        }

        public static bool HoleUser()
        {
            return HoleUser(long.MaxValue);
        }

        public static bool HoleUser(long limit)
        {
            return false;
        }

        public static bool HoleUser(ushort user_id)
        {
            return false;
        }
    }
}