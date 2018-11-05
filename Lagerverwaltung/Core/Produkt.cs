using System;
using Lagerverwaltung.Core.Abstract;

namespace Lagerverwaltung.Core
{
   public class Produkt : Base
    {
        public int Id { get; set; }
        public String Name { get; set; }
        public Artikeltyp ArtikelTyp { get; set; }
        public DateTime ErstelltAm { get; set; }
        public DateTime GeaendertAm { get; set; }
        public String Zeichnungsnummer { get; set; }
        public float Gewicht { get; set; }
        public float Preis { get; set; }

        // Groesse des Paketes wird in Artikel gespeichert, um Datenkohärenz zu vermeiden
        public override float Hoehe { get; set; }
        public override float Breite { get; set; }
        public override float Laenge { get; set; }

        public Produkt(int id, String name, Artikeltyp artikeltyp, DateTime erstelltAm, DateTime geaendertAm, String zeichnungsnummer, float gewicht, float preis, float hoehe, float breite, float laenge)
        {
            Id = id;
            Name = name;
            ErstelltAm = erstelltAm;
            GeaendertAm = geaendertAm;
            ArtikelTyp = artikeltyp;
            Zeichnungsnummer = zeichnungsnummer;
            Gewicht = gewicht;
            Preis = preis;
            Hoehe = hoehe;
            Breite = breite;
            Laenge = laenge;
        }
    }
}
