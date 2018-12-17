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
                cmd.CommandText =   "select pr.name as produktname, pr.produkt_id, pr.gewicht, pr.preis, pr.zeichnungsnummer, pr.hoehe as produkthoehe, pr.breite as produktbreite, pr.laenge as produktlaenge, pr.erstellt_am, pr.zuletzt_geaendert, "  +
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

        public static void HoleSuchergebnisse(string regal_name, string regalfach_name, string produkt_name, uint produkt_id, string produkt_zeichnungsnummer,
                                        string paket_name, string paket_anschaffungsgrund, float produkt_gewicht, float produkt_gewicht2, float produkt_preis,
                                        float produkt_preis2, string produkt_erstellt_am, string produkt_erstellt_am2, string produkt_geaendert_am,
                                        string produkt_geaendert_am2, ushort paket_menge, ushort paket_menge2, string paket_haltbarkeit, string paket_haltbarkeit2,
                                        float hoehe, float hoehe2, float laenge, float laenge2, float breite, float breite2, bool[] changed, int change)
        {

            using (var cmd = new NpgsqlCommand())
            {
                

                cmd.Connection = conn;
                cmd.CommandText = "select pr.name as produktname, pr.produkt_id, pr.gewicht, pr.preis, pr.zeichnungsnummer, pr.hoehe as produkthoehe, pr.breite as produktbreite, pr.laenge as produktlaenge, pr.erstellt_am, pr.zuletzt_geaendert, " +
                    "p.paketname, p.menge, p.haltbarkeit, p.anschaffungsgrund, p.regalname, p.regalfachname, row_number() over (order by pr.name desc) as Zeile from produkt pr " +
                    "join(select p.produkt_id, p.name as paketname, p.menge, p.haltbarkeit, p.anschaffungsgrund, rf.regalname, rf.regalfachname from paket p " +
                    "join (select rf.regalfach_id, rf.regal_id, rf.name as regalfachname, rg.name as regalname from regalfach rf " +
                    "join (select rg.name, rg.regal_id from regal rg) as rg on rf.regal_id = rg.regal_id) as rf on p.regalfach_id = rf.regalfach_id) as p on pr.produkt_id = p.produkt_id where ";

                if (changed[0] == true)
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

                if (changed[1] == true)
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

                if (changed[2] == true)
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

                if (changed[3] == true)
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

                if (changed[4] == true)
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

                if (changed[5] == true)
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

                if (changed[6] == true)
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



                if (changed[7] != false || changed[8] != false)
                {
                    if (changed[7] == true && changed[8] == false)
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
                    else if (changed[7] == false && changed[8] == true)
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


                if (changed[9] != false || changed[10] != false)
                {
                    if (changed[9] == true && changed[10] == false)
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
                    else if (changed[9] == false && changed[10] == true)
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


                if (changed[11] != false || changed[12] != false)
                {
                    if (changed[11] == true && changed[12] == false)
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
                    else if (changed[11] == false && changed[12] == true)
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


                if (changed[13] != false || changed[14] != false)
                {
                    if (changed[13] == true && changed[14] == false)
                    {
                        if (change > 1)
                        {
                            cmd.CommandText += "pr.zuletzt_geaendert BETWEEN to_timestamp('" + produkt_geaendert_am + "', 'dd.MM.yyyy') AND to_timestamp('31.12.2100', 'dd.MM.yyyy') AND ";
                        }
                        else
                        {
                            cmd.CommandText += "pr.zuletzt_geaendert BETWEEN to_timestamp('" + produkt_geaendert_am + "', 'dd.MM.yyyy') AND to_timestamp('31.12.2100', 'dd.MM.yyyy') ;";
                        }
                        change--;
                    }
                    else if (changed[13] == false && changed[14] == true)
                    {
                        if (change > 1)
                        {
                            cmd.CommandText += "pr.zuletzt_geaendert BETWEEN to_timestamp('01.01.1970', 'dd.MM.yyyy') AND to_timestamp('" + produkt_geaendert_am2 + "', 'dd.MM.yyyy') AND ";
                        }
                        else
                        {
                            cmd.CommandText += "pr.zuletzt_geaendert BETWEEN to_timestamp('01.01.1970', 'dd.MM.yyyy') AND to_timestamp('" + produkt_geaendert_am2 + "', 'dd.MM.yyyy') ;";
                        }
                        change--;
                    }
                    else
                    {
                        if (change > 2)
                        {
                            cmd.CommandText += "pr.zuletzt_geaendert BETWEEN to_timestamp('" + produkt_geaendert_am + "', 'dd.MM.yyyy') AND to_timestamp('" + produkt_geaendert_am2 + "', 'dd.MM.yyyy') AND ";
                        }
                        else
                        {
                            cmd.CommandText += "pr.zuletzt_geaendert BETWEEN to_timestamp('" + produkt_geaendert_am + "', 'dd.MM.yyyy') AND to_timestamp('" + produkt_geaendert_am2 + "', 'dd.MM.yyyy') ;";
                        }
                        change = change - 2;
                    }
                }



                if (changed[15] != false || changed[16] != false)
                {
                    if (changed[15] == true && changed[16] == false)
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
                    else if (changed[15] == false && changed[16] == true)
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


                if (changed[17] != false || changed[18] != false)
                {
                    if (changed[17] == true && changed[18] == false)
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
                    else if (changed[17] == false && changed[18] == true)
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


                if (changed[19] != false || changed[20] != false)
                {
                    if (changed[19] == true && changed[20] == false)
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
                    else if (changed[19] == false && changed[20] == true)
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


                if (changed[21] != false || changed[22] != false)
                {
                    if (changed[21] == true && changed[22] == false)
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
                    else if (changed[21] == false && changed[22] == true)
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


                if (changed[23] != false || changed[24] != false)
                {
                    if (changed[23] == true && changed[24] == false)
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
                    else if (changed[23] == false && changed[24] == true)
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
                            new Suche(reader.GetString(0), (uint)reader.GetInt32(1), reader.GetFloat(2), reader.GetFloat(3), reader.GetString(4), reader.GetFloat(5), reader.GetFloat(6), reader.GetFloat(7), reader.GetDateTime(8), reader.GetDateTime(9), reader.GetString(10), (ushort)reader.GetInt16(11), reader.GetDateTime(12), reader.GetString(13), reader.GetString(14), reader.GetString(15), (uint)reader.GetInt64(16));
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
