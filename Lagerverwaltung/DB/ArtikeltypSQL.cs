using System.Collections.Generic;
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
                System.Console.WriteLine("Affected Rows: {0}", result.ToString()); //Testzwecken
                return result==0 ? false : true;
            }
        }

        // return typ ändern!
        public static List<Artikeltyp> HoleAlleArtikeltyp()
        {
            return HoleAlleArtikeltyp(short.MaxValue);
        }

        // return typ ändern!
        public static List<Artikeltyp> HoleAlleArtikeltyp(short limit)
        {
            using (var cmd = new NpgsqlCommand())
            {
                cmd.Connection = conn;
                cmd.CommandText = "SELECT * FROM artikeltyp LIMIT @limit;";
                cmd.Parameters.AddWithValue("limit", limit);

                // Prüfe noch auch irgendwelche Fehler etc.
                using (var reader = cmd.ExecuteReader())
                {
                    var _list = new List<Artikeltyp>();
                    while (reader.Read())
                    {
                        _list.Add(new Artikeltyp((ushort)reader.GetInt16(0),reader.GetString(1),reader.GetDateTime(2), reader.GetDateTime(3)));
                    }
                    return _list;
                }
            }
        }

        // return typ ändern!
        public static Artikeltyp HoleArtikeltyp(ushort artikeltyp_id)
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
                    return new Artikeltyp((ushort)reader.GetInt16(0), reader.GetString(1), reader.GetDateTime(2), reader.GetDateTime(3));
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
                System.Console.WriteLine("Affected Rows: {0}", result.ToString()); //Testzwecken
                return result == 0 ? false : true;
            }
        }
    }
}
