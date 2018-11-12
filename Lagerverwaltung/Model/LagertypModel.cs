using System.Collections.Generic;
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

        public static List<Lagertyp> HoleAlleLagertyp()
        {
            return HoleAlleLagertyp(short.MaxValue);
        }

        public static List<Lagertyp> HoleAlleLagertyp(short limit)
        {
            using (var cmd = new NpgsqlCommand())
            {
                cmd.Connection = conn;
                cmd.CommandText = "SELECT * FROM lagertyp LIMIT @limit;";
                cmd.Parameters.AddWithValue("limit", limit);

                // Prüfe noch auch irgendwelche Fehler etc.
                using (var reader = cmd.ExecuteReader())
                {
                    var _list = new List<Lagertyp>();
                    while (reader.Read())
                    {
                        _list.Add(new Lagertyp((ushort)reader.GetInt16(0),reader.GetString(1),reader.GetDateTime(2),reader.GetDateTime(3)));
                    }
                    return _list;
                }
            }
        }

        public static Lagertyp HoleLagertyp(ushort lagertyp_id)
        {
            using (var cmd = new NpgsqlCommand())
            {
                cmd.Connection = conn;
                cmd.CommandText = "SELECT * FROM lagertyp WHERE lagertyp_id = @lagertyp_id;";
                cmd.Parameters.AddWithValue("lagertyp_id", lagertyp_id);

                // Prüfe noch auch irgendwelche Fehler etc.
                using (var reader = cmd.ExecuteReader())
                {
                    reader.Read();
                    return new Lagertyp((ushort)reader.GetInt16(0), reader.GetString(1), reader.GetDateTime(2), reader.GetDateTime(3));
                }
            }
        }

        public static bool LoescheLagertyp(ushort lagertyp_id)
        {
            using (var cmd = new NpgsqlCommand())
            {
                cmd.Connection = conn;
                cmd.CommandText = "DELETE FROM lagertyp WHERE lagertyp_id = @lagertyp_id;";
                cmd.Parameters.AddWithValue("lagertyp_id", lagertyp_id);
                int result = cmd.ExecuteNonQuery();
                System.Console.WriteLine("Affected Rows: {0}", result.ToString()); //Testzwecken
                return result == 0 ? false : true;
            }
        }
    }
}
