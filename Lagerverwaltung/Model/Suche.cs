﻿using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using Lagerverwaltung.Core.Abstract;

namespace Lagerverwaltung.Model
{
    /// <summary>
    /// Noch unvollständig
    /// </summary>
    public sealed class Suche : Base
    {
        public uint ProduktID { get; set; }
        public string ProduktName { get; set; }
        public float ProduktGewicht { get; set; }
        public float ProduktPreis { get; set; }
        public string ProduktZeichnungsnummer { get; set; }
        //Produkthoehe
        public override float Hoehe { get; set; }
        //Produktbreite
        public override float Breite { get; set; }
        //Produktlaenge
        public override float Laenge { get; set; }
        public DateTime ProduktErstelltAm { get; set; }
        public DateTime ProduktGeaendertAm { get; set; }


        public string PaketName { get; set; }
        public ushort PaketMenge { get; set; }
        public DateTime PaketHaltbarkeit { get; set; }
        public string PaketAnschaffungsgrund { get; set; }


        public string RegalName { get; set; }
        public string RegalfachName { get; set; }


        private static Dictionary<ulong, Suche> _dict = new Dictionary<ulong, Suche>();
        public static ReadOnlyDictionary<ulong, Suche> HoleSuchergebnisse => new ReadOnlyDictionary<ulong, Suche>(_dict);

        public Suche(   uint produkt_id, string produkt_name, float produkt_gewicht, float produkt_preis, string produkt_zeichnungsnummer, float hoehe, float breite, float laenge, DateTime produkt_erstellt_am, DateTime produkt_geaendert_am  ,
                        string paket_name, ushort paket_menge, DateTime paket_haltbarkeit, string paket_anschaffungsgrund, string regal_name, string regalfach_name                                                                             )
        {
            ProduktID = produkt_id;
            ProduktName = produkt_name;
            ProduktGewicht = produkt_gewicht;
            ProduktPreis = produkt_preis;
            ProduktZeichnungsnummer = produkt_zeichnungsnummer;
            Hoehe = hoehe;
            Breite = breite;
            Laenge = laenge;
            ProduktErstelltAm = produkt_erstellt_am;
            ProduktGeaendertAm = produkt_geaendert_am;

            PaketName = paket_name;
            PaketMenge = paket_menge;
            PaketHaltbarkeit = paket_haltbarkeit;
            PaketAnschaffungsgrund = paket_anschaffungsgrund;

            RegalName = regal_name;
            RegalfachName = regalfach_name;
        }
    }
}
