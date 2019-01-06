using System;
using System.Diagnostics.Contracts;
using Lagerverwaltung.Core;
using Lagerverwaltung.Model;
using Npgsql;
using System.Windows.Forms;

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
                /*
                cmd.CommandText =   "select pr.name as produktname, pr.produkt_id, pr.gewicht, pr.preis, pr.zeichnungsnummer, pr.hoehe as produkthoehe, pr.breite as produktbreite, pr.laenge as produktlaenge, " +
                                    "pr.erstellt_am, pr.zuletzt_geändert, p.paketname, p.menge, p.haltbarkeit, p.anschaffungsgrund, p.regalname, p.regalfachname, p.lagername, row_number() OVER(ORDER BY pr.name DESC) as ID from produkt pr " +
                                    "join (select p.produkt_id, p.name as paketname, p.menge, p.haltbarkeit, p.anschaffungsgrund, rf.regalname, rf.regalfachname, rf.lagername from paket p " +
                                    "join(select rf.regalfach_id, rf.regal_id, rf.name as regalfachname, rg.name as regalname, rg.lagername from regalfach rf " +
                                    "join (select rg.lager_id, rg.name, rg.regal_id, lg.name as lagername from regal rg " + 
                                    "join (select lg.lager_id, lg.name from lager lg) as lg on rg.lager_id = lg.lager_id) as rg on rf.regal_id = rg.regal_id) as rf on p.regalfach_id = rf.regalfach_id) as p on pr.produkt_id = p.produkt_id limit @num;";
                */

                cmd.CommandText =   "select pr.name as produktname, pr.produkt_id, pr.gewicht, pr.preis, pr.zeichnungsnummer, pr.hoehe as produkthoehe, pr.breite as produktbreite, pr.laenge as produktlaenge, " +
                                    "pr.erstellt_am, pr.zuletzt_geaendert, p.paketname, p.menge, p.haltbarkeit, p.anschaffungsgrund, p.regalname, p.regalfachname, p.lagername, row_number() OVER(ORDER BY pr.name DESC) as ID from produkt pr " +
                                    "join (select p.produkt_id, p.name as paketname, p.menge, p.haltbarkeit, p.anschaffungsgrund, rf.regalname, rf.regalfachname, rf.lagername from paket p " +
                                    "join(select rf.regalfach_id, rf.regal_id, rf.name as regalfachname, rg.name as regalname, rg.lagername from regalfach rf " +
                                    "join (select rg.lager_id, rg.name, rg.regal_id, lg.name as lagername from regal rg " +
                                    "join (select lg.lager_id, lg.name from lager lg) as lg on rg.lager_id = lg.lager_id) as rg on rf.regal_id = rg.regal_id) as rf on p.regalfach_id = rf.regalfach_id) as p on pr.produkt_id = p.produkt_id limit @num;";
                cmd.Parameters.AddWithValue("num", limit);

                using (var reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        new Suche(reader.GetString(0), (uint)reader.GetInt32(1), reader.GetFloat(2), reader.GetFloat(3), reader.GetString(4), reader.GetFloat(5), reader.GetFloat(6), reader.GetFloat(7), reader.GetDateTime(8), reader.GetDateTime(9), reader.GetString(10), (ushort)reader.GetInt16(11), reader.GetDateTime(12), reader.GetString(13), reader.GetString(14), reader.GetString(15), reader.GetString(16), (uint)reader.GetInt64(17));
                    }
                }
            }
        }

        public static void HoleSuchergebnisse(  string lager_name, string regal_name, string regalfach_name, string produkt_name, /*uint produkt_id*/ long produkt_id, string produkt_zeichnungsnummer  ,
                                                string paket_name, string paket_anschaffungsgrund, float produkt_gewicht, float produkt_gewicht2, float produkt_preis               ,
                                                float produkt_preis2, string produkt_erstellt_am, string produkt_erstellt_am2, string produkt_geaendert_am                          ,
                                                string produkt_geaendert_am2, ushort paket_menge, ushort paket_menge2, string paket_haltbarkeit, string paket_haltbarkeit2          ,
                                                float hoehe, float hoehe2, float laenge, float laenge2, float breite, float breite2, bool[] changed, int change                     )
        {

            using (var cmd = new NpgsqlCommand())
            {
                

                cmd.Connection = conn;
                /*
                cmd.CommandText =   "select pr.name as produktname, pr.produkt_id, pr.gewicht, pr.preis, pr.zeichnungsnummer, pr.hoehe as produkthoehe, pr.breite as produktbreite, pr.laenge as produktlaenge, " +
                                    "pr.erstellt_am, pr.zuletzt_geändert, p.paketname, p.menge, p.haltbarkeit, p.anschaffungsgrund, p.regalname, p.regalfachname, p.lagername, row_number() OVER(ORDER BY pr.name DESC) as ID from produkt pr " +
                                    "join (select p.produkt_id, p.name as paketname, p.menge, p.haltbarkeit, p.anschaffungsgrund, rf.regalname, rf.regalfachname, rf.lagername from paket p " +
                                    "join(select rf.regalfach_id, rf.regal_id, rf.name as regalfachname, rg.name as regalname, rg.lagername from regalfach rf " +
                                    "join (select rg.lager_id, rg.name, rg.regal_id, lg.name as lagername from regal rg " +
                                    "join (select lg.lager_id, lg.name from lager lg) as lg on rg.lager_id = lg.lager_id) as rg on rf.regal_id = rg.regal_id) as rf on p.regalfach_id = rf.regalfach_id) as p on pr.produkt_id = p.produkt_id where ";
                */

                cmd.CommandText =   "select pr.name as produktname, pr.produkt_id, pr.gewicht, pr.preis, pr.zeichnungsnummer, pr.hoehe as produkthoehe, pr.breite as produktbreite, pr.laenge as produktlaenge, " +
                                    "pr.erstellt_am, pr.zuletzt_geaendert, p.paketname, p.menge, p.haltbarkeit, p.anschaffungsgrund, p.regalname, p.regalfachname, p.lagername, row_number() OVER(ORDER BY pr.name DESC) as ID from produkt pr " +
                                    "join (select p.produkt_id, p.name as paketname, p.menge, p.haltbarkeit, p.anschaffungsgrund, rf.regalname, rf.regalfachname, rf.lagername from paket p " +
                                    "join(select rf.regalfach_id, rf.regal_id, rf.name as regalfachname, rg.name as regalname, rg.lagername from regalfach rf " +
                                    "join (select rg.lager_id, rg.name, rg.regal_id, lg.name as lagername from regal rg " +
                                    "join (select lg.lager_id, lg.name from lager lg) as lg on rg.lager_id = lg.lager_id) as rg on rf.regal_id = rg.regal_id) as rf on p.regalfach_id = rf.regalfach_id) as p on pr.produkt_id = p.produkt_id where ";



                if (changed[0] == true)
                {
                    if (change > 1)
                    {
                        cmd.CommandText += "p.lagername like '%" + lager_name + "%' AND ";
                    }
                    else
                    {
                        cmd.CommandText += "p.lagername like '%" + lager_name + "%' ;";
                    }
                    change--;
                }

                if (changed[1] == true)
                {
                    if (change > 1)
                    {
                        cmd.CommandText += "p.regalname like '%" + regal_name + "%' AND ";
                    }
                    else
                    {
                        cmd.CommandText += "p.regalname like '%" + regal_name + "%' ;";
                    }
                    change--;
                }

                if (changed[2] == true)
                {
                    if (change > 1)
                    {
                        cmd.CommandText += "p.regalfachname like '%" + regalfach_name + "%' AND ";
                    }
                    else
                    {
                        cmd.CommandText += "p.regalfachname like '%" + regalfach_name + "%' ;";
                    }
                    change--;
                }

                if (changed[3] == true)
                {
                    if (change > 1)
                    {
                        cmd.CommandText += "pr.name like '%" + produkt_name + "%' AND ";
                    }
                    else
                    {
                        cmd.CommandText += "pr.name like '%" + produkt_name + "%' ;";
                    }
                    change--;
                }

                if (changed[4] == true)
                {
                    if (change > 1)
                    {
                        cmd.CommandText += "cast (pr.produkt_id as text) = '" + produkt_id + "' AND ";
                    }
                    else
                    {
                        cmd.CommandText += "cast (pr.produkt_id as text) = '" + produkt_id + "' ;";
                    }
                    change--;
                }

                if (changed[5] == true)
                {
                    if (change > 1)
                    {
                        cmd.CommandText += "pr.zeichnungsnummer like '%" + produkt_zeichnungsnummer + "%' AND ";
                    }
                    else
                    {
                        cmd.CommandText += "pr.zeichnungsnummer like '%" + produkt_zeichnungsnummer + "%' ;";
                    }
                    change--;
                }

                if (changed[6] == true)
                {
                    if (change > 1)
                    {
                        cmd.CommandText += "p.paketname like '%" + paket_name + "%' AND ";
                    }
                    else
                    {
                        cmd.CommandText += "p.paketname like '%" + paket_name + "%' ;";
                    }
                    change--;
                }

                if (changed[7] == true)
                {
                    if (change > 1)
                    {
                        cmd.CommandText += "p.anschaffungsgrund like '%" + paket_anschaffungsgrund + "%' AND ";
                    }
                    else
                    {
                        cmd.CommandText += "p.anschaffungsgrund like '%" + paket_anschaffungsgrund + "%' ;";
                    }
                    change--;
                }



                if (changed[8] != false || changed[9] != false)
                {
                    if (changed[8] == true && changed[9] == false)
                    {
                        if (change > 1)
                        {
                            cmd.CommandText += "cast (pr.gewicht as text) BETWEEN '" + produkt_gewicht + "' AND '9999999999999' AND ";
                        }
                        else
                        {
                            cmd.CommandText += "cast (pr.gewicht as text) BETWEEN '" + produkt_gewicht + "' AND '9999999999999' ;";
                        }
                        change--;
                    }
                    else if (changed[8] == false && changed[9] == true)
                    {
                        if (change > 1)
                        {
                            cmd.CommandText += "cast (pr.gewicht as text) BETWEEN '0' AND '" + produkt_gewicht2 + "' AND ";
                        }
                        else
                        {
                            cmd.CommandText += "cast (pr.gewicht as text) BETWEEN '0' AND '" + produkt_gewicht2 + "' ;";
                        }
                        change--;
                    }
                    else
                    {
                        if (change > 2)
                        {
                            cmd.CommandText += "cast (pr.gewicht as text) BETWEEN '" + produkt_gewicht + "' AND '" + produkt_gewicht2 + "' AND ";
                        }
                        else
                        {
                            cmd.CommandText += "cast (pr.gewicht as text) BETWEEN '" + produkt_gewicht + "' AND '" + produkt_gewicht2 + "' ;";
                        }
                        change = change - 2;
                    }
                }


                if (changed[10] != false || changed[11] != false)
                {
                    if (changed[10] == true && changed[11] == false)
                    {
                        if (change > 1)
                        {
                            cmd.CommandText += "cast (pr.preis as text) BETWEEN '" + produkt_preis + "' AND '9999999999999' AND ";
                        }
                        else
                        {
                            cmd.CommandText += "cast (pr.preis as text) BETWEEN '" + produkt_preis + "' AND '9999999999999' ;";
                        }
                        change--;
                    }
                    else if (changed[10] == false && changed[11] == true)
                    {
                        if (change > 1)
                        {
                            cmd.CommandText += "cast (pr.preis as text) BETWEEN '0' AND '" + produkt_preis2 + "' AND ";
                        }
                        else
                        {
                            cmd.CommandText += "cast (pr.preis as text) BETWEEN '0' AND '" + produkt_preis2 + "' ;";
                        }
                        change--;
                    }
                    else
                    {
                        if (change > 2)
                        {
                            cmd.CommandText += "cast (pr.preis as text) BETWEEN '" + produkt_preis + "' AND '" + produkt_preis2 + "' AND ";
                        }
                        else
                        {
                            cmd.CommandText += "cast (pr.preis as text) BETWEEN '" + produkt_preis + "' AND '" + produkt_preis2 + "' ;";
                        }
                        change = change - 2;
                    }
                }


                if (changed[12] != false || changed[13] != false)
                {
                    if (changed[12] == true && changed[13] == false)
                    {
                        if (change > 1)
                        {
                            cmd.CommandText += "pr.erstellt_am BETWEEN to_timestamp('" + produkt_erstellt_am + "', 'dd.MM.yyyy') AND to_timestamp('31.12.2100', 'dd.MM.yyyy') AND ";
                        }
                        else
                        {
                            cmd.CommandText += "pr.erstellt_am BETWEEN to_timestamp('" + produkt_erstellt_am + "', 'dd.MM.yyyy') AND to_timestamp('31.12.2100', 'dd.MM.yyyy') ;";
                        }
                        change--;
                    }
                    else if (changed[12] == false && changed[13] == true)
                    {
                        if (change > 1)
                        {
                            cmd.CommandText += "pr.erstellt_am BETWEEN to_timestamp('01.01.1970', 'dd.MM.yyyy') AND to_timestamp('" + produkt_erstellt_am2 + "', 'dd.MM.yyyy') AND ";
                        }
                        else
                        {
                            cmd.CommandText += "pr.erstellt_am BETWEEN to_timestamp('01.01.1970', 'dd.MM.yyyy') AND to_timestamp('" + produkt_erstellt_am2 + "', 'dd.MM.yyyy') ;";
                        }
                        change--;
                    }
                    else
                    {
                        if (change > 2)
                        {
                            cmd.CommandText += "pr.erstellt_am BETWEEN to_timestamp('" + produkt_erstellt_am + "', 'dd.MM.yyyy') AND to_timestamp('" + produkt_erstellt_am2 + "', 'dd.MM.yyyy') AND ";
                        }
                        else
                        {
                            cmd.CommandText += "pr.erstellt_am BETWEEN to_timestamp('" + produkt_erstellt_am + "', 'dd.MM.yyyy') AND to_timestamp('" + produkt_erstellt_am2 + "', 'dd.MM.yyyy') ;";
                        }
                        change = change - 2;
                    }
                }


                if (changed[14] != false || changed[15] != false)
                {
                    if (changed[14] == true && changed[15] == false)
                    {
                        if (change > 1)
                        {
                            cmd.CommandText += "pr.zuletzt_geändert BETWEEN to_timestamp('" + produkt_geaendert_am + "', 'dd.MM.yyyy') AND to_timestamp('31.12.2100', 'dd.MM.yyyy') AND ";
                        }
                        else
                        {
                            cmd.CommandText += "pr.zuletzt_geändert BETWEEN to_timestamp('" + produkt_geaendert_am + "', 'dd.MM.yyyy') AND to_timestamp('31.12.2100', 'dd.MM.yyyy') ;";
                        }
                        change--;
                    }
                    else if (changed[14] == false && changed[15] == true)
                    {
                        if (change > 1)
                        {
                            cmd.CommandText += "pr.zuletzt_geändert BETWEEN to_timestamp('01.01.1970', 'dd.MM.yyyy') AND to_timestamp('" + produkt_geaendert_am2 + "', 'dd.MM.yyyy') AND ";
                        }
                        else
                        {
                            cmd.CommandText += "pr.zuletzt_geändert BETWEEN to_timestamp('01.01.1970', 'dd.MM.yyyy') AND to_timestamp('" + produkt_geaendert_am2 + "', 'dd.MM.yyyy') ;";
                        }
                        change--;
                    }
                    else
                    {
                        if (change > 2)
                        {
                            cmd.CommandText += "pr.zuletzt_geändert BETWEEN to_timestamp('" + produkt_geaendert_am + "', 'dd.MM.yyyy') AND to_timestamp('" + produkt_geaendert_am2 + "', 'dd.MM.yyyy') AND ";
                        }
                        else
                        {
                            cmd.CommandText += "pr.zuletzt_geändert BETWEEN to_timestamp('" + produkt_geaendert_am + "', 'dd.MM.yyyy') AND to_timestamp('" + produkt_geaendert_am2 + "', 'dd.MM.yyyy') ;";
                        }
                        change = change - 2;
                    }
                }



                if (changed[16] != false || changed[17] != false)
                {
                    if (changed[16] == true && changed[17] == false)
                    {
                        if (change > 1)
                        {
                            cmd.CommandText += "cast (p.menge as text) BETWEEN '" + paket_menge + "' AND '9999999999999' AND ";
                        }
                        else
                        {
                            cmd.CommandText += "cast (p.menge as text) BETWEEN '" + paket_menge + "' AND '9999999999999' ;";
                        }
                        change--;
                    }
                    else if (changed[16] == false && changed[17] == true)
                    {
                        if (change > 1)
                        {
                            cmd.CommandText += "cast (p.menge as text) BETWEEN '0' AND '" + paket_menge2 + "' AND ";
                        }
                        else
                        {
                            cmd.CommandText += "cast (p.menge as text) BETWEEN '0' AND '" + paket_menge2 + "' ;";
                        }
                        change--;
                    }
                    else
                    {
                        if (change > 2)
                        {
                            cmd.CommandText += "cast (p.menge as text) BETWEEN '" + paket_menge + "' AND '" + paket_menge2 + "' AND ";
                        }
                        else
                        {
                            cmd.CommandText += "cast (p.menge as text) BETWEEN '" + paket_menge + "' AND '" + paket_menge2 + "' ;";
                        }
                        change = change - 2;
                    }
                }


                if (changed[18] != false || changed[19] != false)
                {
                    if (changed[18] == true && changed[19] == false)
                    {
                        if (change > 1)
                        {
                            cmd.CommandText += "p.haltbarkeit BETWEEN to_timestamp('" + paket_haltbarkeit + "', 'dd.MM.yyyy') AND to_timestamp('31.12.2100', 'dd.MM.yyyy') AND ";
                        }
                        else
                        {
                            cmd.CommandText += "p.haltbarkeit BETWEEN to_timestamp('" + paket_haltbarkeit + "', 'dd.MM.yyyy') AND to_timestamp('31.12.2100', 'dd.MM.yyyy') ;";
                        }
                        change--;
                    }
                    else if (changed[18] == false && changed[19] == true)
                    {
                        if (change > 1)
                        {
                            cmd.CommandText += "p.haltbarkeit BETWEEN to_timestamp('01.01.1970', 'dd.MM.yyyy') AND to_timestamp('" + paket_haltbarkeit2 + "', 'dd.MM.yyyy') AND ";
                        }
                        else
                        {
                            cmd.CommandText += "p.haltbarkeit BETWEEN to_timestamp('01.01.1970', 'dd.MM.yyyy') AND to_timestamp('" + paket_haltbarkeit2 + "', 'dd.MM.yyyy') ;";
                        }
                        change--;
                    }
                    else
                    {
                        if (change > 2)
                        {
                            cmd.CommandText += "p.haltbarkeit BETWEEN to_timestamp('" + paket_haltbarkeit + "', 'dd.MM.yyyy') AND to_timestamp('" + paket_haltbarkeit2 + "', 'dd.MM.yyyy') AND ";
                        }
                        else
                        {
                            cmd.CommandText += "p.haltbarkeit BETWEEN to_timestamp('" + paket_haltbarkeit + "', 'dd.MM.yyyy') AND to_timestamp('" + paket_haltbarkeit2 + "', 'dd.MM.yyyy') ;";
                        }
                        change = change - 2;
                    }
                }


                if (changed[20] != false || changed[21] != false)
                {
                    if (changed[20] == true && changed[21] == false)
                    {
                        if (change > 1)
                        {
                            cmd.CommandText += "cast (pr.hoehe as text) BETWEEN '" + hoehe + "' AND '9999999999999' AND ";
                        }
                        else
                        {
                            cmd.CommandText += "cast (pr.hoehe as text) BETWEEN '" + hoehe + "' AND '9999999999999' ;";
                        }
                        change--;
                    }
                    else if (changed[20] == false && changed[21] == true)
                    {
                        if (change > 1)
                        {
                            cmd.CommandText += "cast (pr.hoehe as text) BETWEEN '0' AND '" + hoehe2 + "' AND ";
                        }
                        else
                        {
                            cmd.CommandText += "cast (pr.hoehe as text) BETWEEN '0' AND '" + hoehe2 + "' ;";
                        }
                        change--;
                    }
                    else
                    {
                        if (change > 2)
                        {
                            cmd.CommandText += "cast (pr.hoehe as text) BETWEEN '" + hoehe + "' AND '" + hoehe2 + "' AND ";
                        }
                        else
                        {
                            cmd.CommandText += "cast (pr.hoehe as text) BETWEEN '" + hoehe + "' AND '" + hoehe2 + "' ;";
                        }
                        change = change - 2;
                    }
                }


                if (changed[22] != false || changed[23] != false)
                {
                    if (changed[22] == true && changed[23] == false)
                    {
                        if (change > 1)
                        {
                            cmd.CommandText += "cast (pr.laenge as text) BETWEEN '" + laenge + "' AND '9999999999999' AND ";
                        }
                        else
                        {
                            cmd.CommandText += "cast (pr.laenge as text) BETWEEN '" + laenge + "' AND '9999999999999' ;";
                        }
                        change--;
                    }
                    else if (changed[22] == false && changed[23] == true)
                    {
                        if (change > 1)
                        {
                            cmd.CommandText += "cast (pr.laenge as text) BETWEEN '0' AND '" + laenge2 + "' AND ";
                        }
                        else
                        {
                            cmd.CommandText += "cast (pr.laenge as text) BETWEEN '0' AND '" + laenge2 + "' ;";
                        }
                        change--;
                    }
                    else
                    {
                        if (change > 2)
                        {
                            cmd.CommandText += "cast (pr.laenge as text) BETWEEN '" + laenge + "' AND '" + laenge2 + "' AND ";
                        }
                        else
                        {
                            cmd.CommandText += "cast (pr.laenge as text) BETWEEN '" + laenge + "' AND '" + laenge2 + "' ;";
                        }
                        change = change - 2;
                    }
                }


                if (changed[24] != false || changed[25] != false)
                {
                    if (changed[24] == true && changed[25] == false)
                    {
                        if (change > 1)
                        {
                            cmd.CommandText += "cast (pr.breite as text) BETWEEN '" + breite + "' AND '9999999999999' AND ";
                        }
                        else
                        {
                            cmd.CommandText += "cast (pr.breite as text) BETWEEN '" + breite + "' AND '9999999999999' ;";
                        }
                        change--;
                    }
                    else if (changed[24] == false && changed[25] == true)
                    {
                        if (change > 1)
                        {
                            cmd.CommandText += "cast (pr.breite as text) BETWEEN '0' AND '" + breite2 + "' AND ";
                        }
                        else
                        {
                            cmd.CommandText += "cast (pr.breite as text) BETWEEN '0' AND '" + breite2 + "' ;";
                        }
                        change--;
                    }
                    else
                    {
                        if (change > 2)
                        {
                            cmd.CommandText += "cast (pr.breite as text) BETWEEN '" + breite + "' AND '" + breite2 + "' AND ";
                        }
                        else
                        {
                            cmd.CommandText += "cast (pr.breite as text) BETWEEN '" + breite + "' AND '" + breite2 + "' ;";
                        }
                        change = change - 2;
                    }
                }

                try
                {
                    using (var reader = cmd.ExecuteReader())
                    {

                        while (reader.Read())
                        {
                            new Suche(reader.GetString(0), (uint)reader.GetInt32(1), reader.GetFloat(2), reader.GetFloat(3), reader.GetString(4), reader.GetFloat(5), reader.GetFloat(6), reader.GetFloat(7), reader.GetDateTime(8), reader.GetDateTime(9), reader.GetString(10), (ushort)reader.GetInt16(11), reader.GetDateTime(12), reader.GetString(13), reader.GetString(14), reader.GetString(15), reader.GetString(16), (uint)reader.GetInt64(17));
                        }
                    }
                }
                catch (Exception)
                {
                    MessageBox.Show("Falsche Datumseingabe. Bitte überprüfen sie, dass ihr Datum nach TT.MM.JJJJ formatiert ist.", "Fehler", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

            }
        }

    }
}
