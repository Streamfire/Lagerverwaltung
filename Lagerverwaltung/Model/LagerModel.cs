using Lagerverwaltung.Core;

namespace Lagerverwaltung.Model
{
    public static class LagerModel
    {
        // Funktioniert, aber Exception Handling fehlt!
        public static bool ErstelleLager(string name, short lagertyp, string standort ="", string beschreibung="")
        {
            var conn = DatabaseFactory.GetFactory().GetConnection();

            using (var cmd = new Npgsql.NpgsqlCommand())
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
    }
}
