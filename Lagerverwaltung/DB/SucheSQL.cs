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

        public static void HoleSuchergebnisse()
        {
            HoleSuchergebnisse(long.MaxValue);
        }

        public static void HoleSuchergebnisse(long limit)
        {
            Contract.Requires(limit >= 1);

            using (var cmd = new NpgsqlCommand())
            {
                cmd.Connection = conn;
                cmd.CommandText =   "select pr.name as produktname, pr.produkt_id, pr.gewicht, pr.preis, pr.zeichnungsnummer, pr.hoehe as produkthoehe, pr.breite as produktbreite, pr.laenge as produktlaenge, pr.erstellt_am, pr.zuletzt_geändert, "  +
                                    "p.paketname, p.menge, p.haltbarkeit, p.anschaffungsgrund, p.regalname, p.regalfachname, row_number() over (order by pr.name desc) as Zeile from produkt pr " +
                                    "join(select p.produkt_id, p.name as paketname, p.menge, p.haltbarkeit, p.anschaffungsgrund, rf.regalname, rf.regalfachname from paket p "                                                                          +
                                    "join (select rf.regalfach_id, rf.regal_id, rf.name as regalfachname, rg.name as regalname from regalfach rf "                                                                                                      +
                                    "join (select rg.name, rg.regal_id from regal rg) as rg on rf.regal_id = rg.regal_id) as rf on p.regalfach_id = rf.regalfach_id) as p on pr.produkt_id = p.produkt_id limit @num;";
                cmd.Parameters.AddWithValue("num", limit);

                using (var reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        new Suche(reader.GetString(0), (uint)reader.GetInt32(1), reader.GetFloat(2), reader.GetFloat(3), reader.GetString(4), reader.GetFloat(5), reader.GetFloat(6), reader.GetFloat(7), reader.GetDateTime(8), reader.GetDateTime(9), reader.GetString(10), (ushort)reader.GetInt16(11), reader.GetDateTime(12), reader.GetString(13), reader.GetString(14), reader.GetString(15), (uint)reader.GetInt64(16));
                    }
                }
            }
        }


        public static void HoleSuchergebnisse(  string produkt_name, uint produkt_id, float produkt_gewicht, float produkt_preis, string produkt_zeichnungsnummer   , 
                                                float hoehe, float breite, float laenge, DateTime produkt_erstellt_am, DateTime produkt_geaendert_am                ,
                                                string paket_name, ushort paket_menge, DateTime paket_haltbarkeit, string paket_anschaffungsgrund                   ,
                                                string regal_name, string regalfach_name                                                                            )
        {
            using (var cmd = new NpgsqlCommand())
            {
                cmd.Connection = conn;
                cmd.CommandText = "select pr.name as produktname, pr.produkt_id, pr.gewicht, pr.preis, pr.zeichnungsnummer, pr.hoehe as produkthoehe, pr.breite as produktbreite, pr.laenge as produktlaenge, pr.erstellt_am, pr.zuletzt_geändert, " +
                                    "p.paketname, p.menge, p.haltbarkeit, p.anschaffungsgrund, p.regalname, p.regalfachname, row_number() over (order by pr.name desc) as Zeile from produkt pr " +
                                    "join(select p.produkt_id, p.name as paketname, p.menge, p.haltbarkeit, p.anschaffungsgrund, rf.regalname, rf.regalfachname from paket p " +
                                    "join (select rf.regalfach_id, rf.regal_id, rf.name as regalfachname, rg.name as regalname from regalfach rf " +
                                    "join (select rg.name, rg.regal_id from regal rg) as rg on rf.regal_id = rg.regal_id) as rf on p.regalfach_id = rf.regalfach_id) as p on pr.produkt_id = p.produkt_id ";

                //mit switch-cases where's in commandtext einfügen


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
