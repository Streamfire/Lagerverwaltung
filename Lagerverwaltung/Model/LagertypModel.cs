using Lagerverwaltung.Core;
using Npgsql;

namespace Lagerverwaltung.Model
{
    public static class LagertypModel
    {
        private static readonly NpgsqlConnection conn;

        static LagertypModel()
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
                System.Console.WriteLine("Affected Rows: {0}", result.ToString()); //Testzwecken
                return result==0 ? false : true;
            }
        }

        public static bool HoleLagertyp()
        {
            return false;
        }
    }
}
