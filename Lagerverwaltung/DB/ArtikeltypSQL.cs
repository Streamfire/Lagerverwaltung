using System.Diagnostics.Contracts;
using Lagerverwaltung.Core;
using Lagerverwaltung.Model;
using Npgsql;

namespace Lagerverwaltung.DB
{
    public static class ArtikeltypSQL
    {
        private static readonly NpgsqlConnection conn;

        static ArtikeltypSQL()
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
                return result==0 ? false : true;
            }
        }

        public static void HoleAlleArtikeltyp()
        {
            HoleAlleArtikeltyp(short.MaxValue);
        }

        public static void HoleAlleArtikeltyp(short limit)
        {
            Contract.Requires(limit >= 1);

            using (var cmd = new NpgsqlCommand())
            {
                cmd.Connection = conn;
                cmd.CommandText = "SELECT * FROM artikeltyp LIMIT @limit;";
                cmd.Parameters.AddWithValue("limit", limit);

                // Prüfe noch auch irgendwelche Fehler etc.
                using (var reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        // wenn feld null dann Exception!
                        new Artikeltyp((ushort)reader.GetInt16(0),reader.GetString(1),reader.GetDateTime(2), reader.GetDateTime(3));
                    }
                }
            }
        }

        public static void HoleArtikeltyp(ushort artikeltyp_id)
        {
            using (var cmd = new NpgsqlCommand())
            {
                cmd.Connection = conn;
                cmd.CommandText = "SELECT * FROM artikeltyp WHERE artikeltyp_id = @artikeltyp_id;";
                cmd.Parameters.AddWithValue("artikeltyp_id", artikeltyp_id);

                // Prüfe noch auch irgendwelche Fehler etc.
                using (var reader = cmd.ExecuteReader())
                {
                    reader.Read();
                    new Artikeltyp((ushort)reader.GetInt16(0), reader.GetString(1), reader.GetDateTime(2), reader.GetDateTime(3));
                }
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
                return result == 0 ? false : true;
            }
        }
    }
}
