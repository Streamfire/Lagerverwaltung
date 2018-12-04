using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using Lagerverwaltung.Core.Abstract;

namespace Lagerverwaltung.Model
{
    /// <summary>
    /// Unvollständig und noch nicht nochmal aktualisiert
    /// </summary>
    public sealed class Suche : Base
    {
        public string ProduktName { get; set; }
        public string ProduktZeichnungsnummer { get; set; }
        public float ProduktGewicht { get; set; }
        public float ProduktPreis { get; set; }
        public string PaketName { get; set; }
        public string PaketAnschaffungsgrund { get; set; }
        public ushort PaketMenge { get; set; }
        public DateTime PaketErstelltAm { get; }
        public DateTime PaketGeaendertAm { get; }
        public DateTime PaketHaltbarkeit { get; set; }
        //PaketHoehe
        public override float Hoehe { get; set; }
        //PaketBreite
        public override float Breite { get; set; }
        //PaketLaenge
        public override float Laenge { get; set; }

        private static Dictionary<ulong, Suche> _dict = new Dictionary<ulong, Suche>();
        public static ReadOnlyDictionary<ulong, Suche> HoleSuchergebnisse => new ReadOnlyDictionary<ulong, Suche>(_dict);

        public Suche(   string produkt_name, string produkt_zeichnungsnummer, float produkt_gewicht, float produkt_preis, string paket_name, string paket_anschaffungsgrund , 
                        ushort paket_menge, DateTime paket_erstellt_am, DateTime paket_geaendert_am, DateTime paket_haltbarkeit, float hoehe, float breite, float laenge    )
        {
            ProduktName = produkt_name;
            ProduktZeichnungsnummer = produkt_zeichnungsnummer;
            ProduktGewicht = produkt_gewicht;
            ProduktPreis = produkt_preis;
            PaketName = paket_name;
            PaketAnschaffungsgrund = paket_anschaffungsgrund;
            PaketMenge = paket_menge;
            PaketErstelltAm = paket_erstellt_am;
            PaketGeaendertAm = paket_geaendert_am;
            PaketHaltbarkeit = paket_haltbarkeit;
            Hoehe = hoehe;
            Breite = breite;
            Laenge = laenge;
        }
    }
}
