using System.Diagnostics.Contracts;
using Lagerverwaltung.Core;
using Lagerverwaltung.Model;
using Npgsql;

namespace Lagerverwaltung.DB
{
    public static class PaketSQL
    {
        private static readonly NpgsqlConnection conn;

        static PaketSQL()
        {
            conn = DatabaseFactory.GetFactory().GetConnection();
        }

		public static bool ErstellePaket(string name, uint regalfach, uint produkt, int menge, System.DateTime haltbar_bis, string anschafungsgrund, int hoehe, int breite, int laenge)
		{
			var regfach = RegalfachSQL.HoleRegalfach(System.Convert.ToInt16(regalfach));
			if (regfach.Paketliste.Count == 0)
			{ //Fach is leer also kann ich das einfach buchen
				using (var cmd = new NpgsqlCommand())
				{
					cmd.Connection = conn;
					cmd.CommandText = "INSERT INTO paket (name, erstellt_am,zuletzt_geändert,regalfach_id,produkt_id,menge,haltbarkeit,anschaffungsgrund,hoehe,breite,laenge) VALUES (@name, @erstellt_am,@zuletzt_geändert,@regalfach_id,@produkt_id,@menge,@haltbarkeit,@anschaffungsgrund,@hoehe,@breite,@laenge)";
					cmd.Parameters.AddWithValue("name", name);
					cmd.Parameters.AddWithValue("erstellt_am", System.DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss"));
					cmd.Parameters.AddWithValue("zuletzt_geändert", System.DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss"));
					cmd.Parameters.AddWithValue("regalfach_id", regalfach);
					cmd.Parameters.AddWithValue("produkt_id", produkt);
					cmd.Parameters.AddWithValue("menge", menge);
					cmd.Parameters.AddWithValue("haltbarkeit", haltbar_bis.ToString("yyyy-MM-dd HH:mm:ss"));
					cmd.Parameters.AddWithValue("anschaffungsgrund", anschafungsgrund);
					cmd.Parameters.AddWithValue("hoehe", hoehe);
					cmd.Parameters.AddWithValue("breite", breite);
					cmd.Parameters.AddWithValue("laenge", laenge);


					PaketSQL.HoleAllePakete();


					DB.LagerSQL.HoleLager(Views.Dashboard.Verwaltung.getActiveTabPageName());
					Views.Dashboard.Verwaltung.UpdateForm(Model.Lager.HoleListe);

					int result = cmd.ExecuteNonQuery();
					return result == 0 ? false : true;
				}
				

			}
			else
			{//Fach ist mit anderem Produkt besetzt -> ich kanns nicht buchen
				return false;
			}
        }

        public static void HoleAllePakete()
        {
            HoleAllePakete(int.MaxValue);
        }

        public static void HoleAllePakete(int limit)
        {
            Contract.Requires(limit >= 1);

            using (var cmd = new NpgsqlCommand())
            {
                cmd.Connection = conn;
                cmd.CommandText = "SELECT * FROM paket LIMIT @num;";
                cmd.Parameters.AddWithValue("num", limit);

                // Prüfe noch auch irgendwelche Fehler etc.
                using (var reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        new Paket((uint)reader.GetInt32(0),(ushort)reader.GetInt16(4),reader.GetString(1),(ushort)reader.GetInt16(6),reader.GetDateTime(2),reader.GetDateTime(3),reader.GetDateTime(7),(uint)reader.GetInt32(5),reader.GetFloat(9), reader.GetFloat(10), reader.GetFloat(11),reader.GetString(8));
                    }
                }
            }
        }

        public static void HolePaket(int paket_id)
        {
            using (var cmd = new NpgsqlCommand())
            {
                cmd.Connection = conn;
                cmd.CommandText = "SELECT * FROM paket WHERE paket_id = @paket_id;";
                cmd.Parameters.AddWithValue("paket_id", paket_id);

                // Prüfe noch auch irgendwelche Fehler etc.
                using (var reader = cmd.ExecuteReader())
                {
                    reader.Read();
                    new Paket((uint)reader.GetInt32(0), (ushort)reader.GetInt16(4), reader.GetString(1), (ushort)reader.GetInt16(6), reader.GetDateTime(2), reader.GetDateTime(3), reader.GetDateTime(7), (uint)reader.GetInt32(5), reader.GetFloat(9), reader.GetFloat(10), reader.GetFloat(11), reader.GetString(8));
                }
            }
        }

        public static bool LoeschePaket(int paket_id)
        {
            using (var cmd = new NpgsqlCommand())
            {
                cmd.Connection = conn;
                cmd.CommandText = "DELETE FROM paket WHERE paket_id = @paket_id;";
                cmd.Parameters.AddWithValue("paket_id", paket_id);
                int result = cmd.ExecuteNonQuery();
                return result == 0 ? false : true;
            }
        }
    }
}
