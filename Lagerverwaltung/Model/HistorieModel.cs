using System.Collections.Generic;
using System.Diagnostics.Contracts;
using Lagerverwaltung.Core;
using Npgsql;

namespace Lagerverwaltung.Model
{
    public static class HistorieModel
    {
        private static readonly NpgsqlConnection conn;

        static HistorieModel()
        {
            conn = DatabaseFactory.GetFactory().GetConnection();
        }

        public static List<Historie> HoleHistorie()
        {
            return HoleHistorie(long.MaxValue);
        }

        public static List<Historie> HoleHistorie(long limit)
        {
            Contract.Requires(limit >= 1);

            using (var cmd = new NpgsqlCommand())
            {
                cmd.Connection = conn;
                cmd.CommandText = "SELECT * FROM historie LIMIT @num;";
                cmd.Parameters.AddWithValue("num", limit);

                // Prüfe noch auch irgendwelche Fehler etc.
                using (var reader = cmd.ExecuteReader())
                {
                    var _list = new List<Historie>();
                    while(reader.Read())
                    {
                        _list.Add(new Historie((ulong)reader.GetInt64(0), (ushort)reader.GetInt16(1), reader.GetString(2), reader.GetDateTime(3)));
                    }
                    return _list;
                }
            }
        }

        public static Historie HoleHistorie(ulong historie_id)
        {
            using (var cmd = new NpgsqlCommand())
            {
                cmd.Connection = conn;
                cmd.CommandText = "SELECT * FROM historie WHERE historie_id = @historie_id;";
                cmd.Parameters.AddWithValue("historie_id", (long)historie_id);

                // Prüfe noch auch irgendwelche Fehler etc.
                using (var reader = cmd.ExecuteReader())
                {
                    reader.Read();
                    return new Historie((ulong)reader.GetInt64(0),(ushort)reader.GetInt16(1),reader.GetString(2), reader.GetDateTime(3));
                }
            }
        }
    }
}
