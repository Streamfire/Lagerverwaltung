using System;
using System.Diagnostics.Contracts;
using Lagerverwaltung.Core;
using Lagerverwaltung.Model;
using Npgsql;

namespace Lagerverwaltung.DB
{
    /// <summary>
    /// Noch unvollständig
    /// </summary>
    public static class SucheSQL
    {
        private static readonly NpgsqlConnection conn;

        static SucheSQL()
        {
            conn = DatabaseFactory.GetFactory().GetConnection();
        }

        public static void HoleSuchergebnisse(long limit)
        {
            Contract.Requires(limit >= 1);

            using (var cmd = new NpgsqlCommand())
            {
                cmd.Connection = conn;
                cmd.CommandText =   "select pr.produkt_id, pr.name as produktname, pr.erstellt_am, pr.zuletzt_geändert, pr.gewicht, pr.preis, pr.zeichnungsnummer, pr.hoehe as produkthoehe, pr.breite as produktbreite, pr.laenge as produktlaenge, "  +
                                    "p.paketname, p.menge, p.haltbarkeit, p.anschaffungsgrund, p.regalname, p.regalfachname from produkt pr "                                                                                                           +
                                    "join(select p.produkt_id, p.name as paketname, p.menge, p.haltbarkeit, p.anschaffungsgrund, rf.regalname, rf.regalfachname from paket p "                                                                          +
                                    "join (select rf.regalfach_id, rf.regal_id, rf.name as regalfachname, rg.name as regalname from regalfach rf "                                                                                                      +
                                    "join (select rg.name, rg.regal_id from regal rg) as rg on rf.regal_id = rg.regal_id) as rf on p.regalfach_id = rf.regalfach_id) as p on pr.produkt_id = p.produkt_id LIMIT @num;";
                cmd.Parameters.AddWithValue("num", limit);

                using (var reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        
                        //new Suche( );
                    }
                }
            }
        }


        public static void HoleSuchergebnisse(  string produkt_name, string produkt_zeichnungsnummer, float produkt_gewicht, float produkt_preis, string paket_name , 
                                                string paket_anschaffungsgrund, ushort paket_menge, DateTime paket_erstellt_am, DateTime paket_geaendert_am         , 
                                                DateTime paket_haltbarkeit, float hoehe, float breite, float laenge                                                 )
        {
            using (var cmd = new NpgsqlCommand())
            {
                cmd.Connection = conn;
                cmd.CommandText = "SELECT * FROM historie WHERE log_id = @log_id;"; //hier kommt auch noch was richtiges rein
                //cmd.Parameters.AddWithValue("log_id", (long)historie_id); //hier kommt auch noch was richtiges rein

                using (var reader = cmd.ExecuteReader())
                {
                    reader.Read();
                    //new Suche( );
                }
            }
        }

    }
}
