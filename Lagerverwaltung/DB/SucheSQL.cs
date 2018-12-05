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


        public static void HoleSuchergebnisse(  string regal_name, string regalfach_name, string produkt_name, uint produkt_id, string produkt_zeichnungsnummer                 ,
                                                string paket_name, string paket_anschaffungsgrund, float produkt_gewicht, float produkt_gewicht2, float produkt_preis           ,
                                                float produkt_preis2, DateTime produkt_erstellt_am, DateTime produkt_erstellt_am2, DateTime produkt_geaendert_am                ,
                                                DateTime produkt_geaendert_am2, ushort paket_menge, ushort paket_menge2, DateTime paket_haltbarkeit, DateTime paket_haltbarkeit2,
                                                float hoehe, float hoehe2, float laenge, float laenge2, float breite, float breite2                                             )
        {
            bool moreThanOneSet = false;
            string temp;

            using (var cmd = new NpgsqlCommand())
            {
                

                cmd.Connection = conn;
                cmd.CommandText = "select pr.name as produktname, pr.produkt_id, pr.gewicht, pr.preis, pr.zeichnungsnummer, pr.hoehe as produkthoehe, pr.breite as produktbreite, pr.laenge as produktlaenge, pr.erstellt_am, pr.zuletzt_geändert, " +
                                    "p.paketname, p.menge, p.haltbarkeit, p.anschaffungsgrund, p.regalname, p.regalfachname, row_number() over (order by pr.name desc) as Zeile from produkt pr " +
                                    "join(select p.produkt_id, p.name as paketname, p.menge, p.haltbarkeit, p.anschaffungsgrund, rf.regalname, rf.regalfachname from paket p " +
                                    "join (select rf.regalfach_id, rf.regal_id, rf.name as regalfachname, rg.name as regalname from regalfach rf " +
                                    "join (select rg.name, rg.regal_id from regal rg) as rg on rf.regal_id = rg.regal_id) as rf on p.regalfach_id = rf.regalfach_id) as p on pr.produkt_id = p.produkt_id where @c1 @c2 @c3 @c4 @c5 @c6 @c7 @c8 @c9 @c10 @11 @12 @13 @14 @15 @16 @17 @18 @19 @20 @21 @22 @23 @24 @25;";
                /*
                if (regal_name != "" && regalfach_name != "" && produkt_name != "" && produkt_id != 0 && produkt_zeichnungsnummer != ""
                    && paket_name != "" && paket_anschaffungsgrund != "" && produkt_gewicht != 0.0f && produkt_gewicht2 != 0.0f && produkt_preis != 0.0f 
                    && produkt_preis2 != 0.0f && DateTime.Compare(produkt_erstellt_am, new DateTime(1970, 1, 1)) != 0
                    && DateTime.Compare(produkt_erstellt_am2, new DateTime(1970, 1, 1)) != 0 && DateTime.Compare(produkt_geaendert_am, new DateTime(1970, 1, 1)) != 0 
                    && DateTime.Compare(produkt_geaendert_am2, new DateTime(1970, 1, 1)) != 0 && paket_menge != 0 && paket_menge2 != 0 
                    && DateTime.Compare(paket_haltbarkeit, new DateTime(1970, 1, 1)) != 0 && DateTime.Compare(paket_haltbarkeit2, new DateTime(1970, 1, 1)) != 0
                    && hoehe != 0.0f && hoehe2 != 0.0f && laenge != 0.0f && laenge2 != 0.0f && breite != 0.0f && breite2 != 0.0f)
                {

                }
                */

                if(regal_name != "")
                {
                    temp = "p.regalname = '" + regal_name + "' ";
                    cmd.Parameters.AddWithValue("c1", temp);
                    moreThanOneSet = true;
                }

                if (regalfach_name != "")
                {
                    if(moreThanOneSet == true)
                        temp = "p.regalfachname = '" + regalfach_name + "' AND ";
                    else
                        temp = "p.regalfachname = '" + regalfach_name + "' ";
                    cmd.Parameters.AddWithValue("c2", temp);
                    moreThanOneSet = true;
                }






                //mit IFs WHEREs in commandtext einfügen


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
