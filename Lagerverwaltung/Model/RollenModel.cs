using Lagerverwaltung.Core;
using Npgsql;

namespace Lagerverwaltung.Model
{
    public static class RollenModel
    {
        private static readonly NpgsqlConnection conn;

        static RollenModel()
        {
            conn = DatabaseFactory.GetFactory().GetConnection();
        }

        public static bool ErstelleRolle(string name, string rechte)
        {
            using (var cmd = new NpgsqlCommand())
            {
                cmd.Connection = conn;
                cmd.CommandText = "INSERT INTO rolle (name, rechte) VALUES (@name, @rechte)";
                cmd.Parameters.AddWithValue("name", name);
                cmd.Parameters.AddWithValue("rechte", rechte);
                int result = cmd.ExecuteNonQuery();
                System.Console.WriteLine("Affected Rows: {0}", result.ToString()); //Testzwecken
                return result == 0 ? false : true;
            }
        }

        public static bool HoleAlleRollen()
        {
            return HolleAlleRollen(short.MaxValue);
        }

        public static bool HolleAlleRollen(short limit)
        {
            using (var cmd = new NpgsqlCommand())
            {
                cmd.Connection = conn;
                cmd.CommandText = "SELECT * FROM rolle LIMIT @limit;";
                cmd.Parameters.AddWithValue("limit", limit);
                int result = cmd.ExecuteNonQuery();
                System.Console.WriteLine("Affected Rows: {0}", result.ToString()); //Testzwecken
                return result == 0 ? false : true;
            }
        }

        public static bool HoleRolle(ushort rollen_id)
        {
            using (var cmd = new NpgsqlCommand())
            {
                cmd.Connection = conn;
                cmd.CommandText = "SELECT * FROM lagertyp WHERE rollen_id = @rollen_id;";
                cmd.Parameters.AddWithValue("rollen_id", rollen_id);
                int result = cmd.ExecuteNonQuery();
                System.Console.WriteLine("Affected Rows: {0}", result.ToString()); //Testzwecken
                return result == 0 ? false : true;
            }
        }

        public static bool LoescheRolle(ushort rollen_id)
        {
            using (var cmd = new NpgsqlCommand())
            {
                cmd.Connection = conn;
                cmd.CommandText = "DELETE FROM rolle WHERE rollen_id = @rollen_id;";
                cmd.Parameters.AddWithValue("rollen_id", rollen_id);
                int result = cmd.ExecuteNonQuery();
                System.Console.WriteLine("Affected Rows: {0}", result.ToString()); //Testzwecken
                return result == 0 ? false : true;
            }
        }
    }
}
