using Lagerverwaltung.Core;
using Npgsql;

namespace Lagerverwaltung.Model
{
    public static class LagerModel
    {
        private static readonly NpgsqlConnection conn;

        static LagerModel()
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
        
        public static bool HoleLager()
        {
            return false;
        }
    }
}
