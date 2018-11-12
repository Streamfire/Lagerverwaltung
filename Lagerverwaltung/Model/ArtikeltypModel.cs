using Lagerverwaltung.Core;
using Npgsql;

namespace Lagerverwaltung.Model
{
    public static class ArtikeltypModel
    {
        private static readonly NpgsqlConnection conn;

        static ArtikeltypModel()
        {
            conn = DatabaseFactory.GetFactory().GetConnection();
        }

        // Funktioniert, aber Exception Handling fehlt!
        public static bool ErstelleArtikeltyp(string name)
        {
            using (var cmd = new NpgsqlCommand())
            {
                cmd.Connection = conn;
                cmd.CommandText = "INSERT INTO artikeltyp (name) VALUES (@name)";
                cmd.Parameters.AddWithValue("name",name);
                int result = cmd.ExecuteNonQuery();
                System.Console.WriteLine("Affected Rows: {0}", result.ToString()); //Testzwecken
                return result==0 ? false : true;
            }
        }

        // return typ ändern!
        public static bool HoleAlleArtikeltyp()
        {
            return HoleAlleArtikeltyp(short.MaxValue);
        }

        // return typ ändern!
        public static bool HoleAlleArtikeltyp(short limit)
        {
            using (var cmd = new NpgsqlCommand())
            {
                cmd.Connection = conn;
                cmd.CommandText = "SELECT * FROM artikeltyp LIMIT @limit;";
                cmd.Parameters.AddWithValue("limit", limit);
                int result = cmd.ExecuteNonQuery();
                System.Console.WriteLine("Affected Rows: {0}", result.ToString()); //Testzwecken
                return result == 0 ? false : true;
            }
        }

        // return typ ändern!
        public static bool HoleArtikeltyp(ushort artikeltyp_id)
        {
            using (var cmd = new NpgsqlCommand())
            {
                cmd.Connection = conn;
                cmd.CommandText = "SELECT * FROM artikeltyp WHERE artikeltyp_id = @artikeltyp_id;";
                cmd.Parameters.AddWithValue("artikeltyp_id", artikeltyp_id);
                int result = cmd.ExecuteNonQuery();
                System.Console.WriteLine("Affected Rows: {0}", result.ToString()); //Testzwecken
                return result == 0 ? false : true;
            }
        }

        public static bool LoescheArtikeltyp(ushort artikeltyp_id)
        {
            using (var cmd = new NpgsqlCommand())
            {
                cmd.Connection = conn;
                cmd.CommandText = "DELETE FROM artikeltyp WHERE artikeltyp_id = @artikeltyp_id;";
                cmd.Parameters.AddWithValue("artikeltyp_id", artikeltyp_id);
                int result = cmd.ExecuteNonQuery();
                System.Console.WriteLine("Affected Rows: {0}", result.ToString()); //Testzwecken
                return result == 0 ? false : true;
            }
        }
    }
}
