using System;
using Lagerverwaltung.Core.Abstract;

namespace Lagerverwaltung.Core
{
   public sealed class Produkt : Base
    {
        public long ProduktID { get; }
        public string Name { get; set; }
        public string Zeichnungsnummer { get; set; }
        public float Gewicht { get; set; }
        public float Preis { get; set; }
        public int Erstellt_Am { get; }
        public int Geaendert_Am { get; }
        public Artikeltyp ArtikelTyp { get; set; }
        
        public override float Hoehe { get; set; }
        public override float Breite { get; set; }
        public override float Laenge { get; set; }

        public Produkt(long produkt_id, string name, string zeichnungsnummer, float gewicht, float preis, int erstellt_am, int geaendert_am, Artikeltyp artikeltyp, float hoehe, float breite, float laenge)
        {
            ProduktID = produkt_id;
            Name = name;
            Zeichnungsnummer = zeichnungsnummer;
            Gewicht = gewicht;
            Preis = preis;
            Erstellt_Am = erstellt_am;
            Geaendert_Am = geaendert_am;
            ArtikelTyp = artikeltyp;
            Hoehe = hoehe;
            Breite = breite;
            Laenge = laenge;
        }
    }
}
