using Lagerverwaltung.Core;

namespace Lagerverwaltung.Model
{
    public static class ArtikeltypModel
    {
        // Funktioniert, aber Exception Handling fehlt!
        public static bool ErstelleArtikeltyp(string name)
        {
            var conn = DatabaseFactory.GetFactory().GetConnection();

            using (var cmd = new Npgsql.NpgsqlCommand())
            {
                cmd.Connection = conn;
                cmd.CommandText = "INSERT INTO artikeltyp (name) VALUES (@name)";
                cmd.Parameters.AddWithValue("name",name);
                int result = cmd.ExecuteNonQuery();
                System.Console.WriteLine("Affected Rows: {0}", result.ToString()); //Testzwecken
                return result==0 ? false : true;
            }
        }
    }
}
