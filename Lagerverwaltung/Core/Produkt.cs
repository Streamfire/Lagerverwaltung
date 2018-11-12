using System;
using System.Diagnostics.Contracts;
using Lagerverwaltung.Core.Abstract;

namespace Lagerverwaltung.Core
{
   public sealed class Produkt : Base
    {
        public ulong ProduktID { get; }
        public string Name { get; set; }
        public string Zeichnungsnummer { get; set; }
        public float Gewicht { get; set; }
        public float Preis { get; set; }
        public DateTime ErstelltAm { get; }
        public DateTime GeaendertAm { get; }
        public ushort ArtikelTyp { get; set; }
        
        public override float Hoehe { get; set; }
        public override float Breite { get; set; }
        public override float Laenge { get; set; }

        public Produkt(ulong produkt_id, string name, string zeichnungsnummer, float gewicht, float preis, DateTime erstellt_am, DateTime geaendert_am, ushort artikeltyp, float hoehe, float breite, float laenge)
        {
            Contract.Requires(produkt_id >= 1);
            Contract.Requires(name.Length <= 25);   // plus minimal Länge laut Data Dictionary später
            Contract.Requires(gewicht >= 0);
            Contract.Requires(preis >= 0);
            Contract.Requires(hoehe >= 0);
            Contract.Requires(breite >= 0);
            Contract.Requires(laenge >= 0);
            ProduktID = produkt_id;
            Name = name;
            Zeichnungsnummer = zeichnungsnummer;
            Gewicht = gewicht;
            Preis = preis;
            ErstelltAm = erstellt_am;
            GeaendertAm = geaendert_am;
            ArtikelTyp = artikeltyp;
            Hoehe = hoehe;
            Breite = breite;
            Laenge = laenge;
        }
    }
}
