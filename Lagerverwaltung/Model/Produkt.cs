﻿using System;
using System.Collections.Generic;
using System.Diagnostics.Contracts;
using Lagerverwaltung.Core.Abstract;

namespace Lagerverwaltung.Model
{
   public sealed class Produkt : Base
    {
        public uint ProduktID { get; }
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

        private static List<Produkt> _list = new List<Produkt>();
        public static event EventHandler<EventArgs> ProduktHinzugefuegt;
        public static event EventHandler<EventArgs> ProduktEntfernt;

        public Produkt(uint produkt_id, string name, string zeichnungsnummer, float gewicht, float preis, DateTime erstellt_am, DateTime geaendert_am, ushort artikeltyp, float hoehe, float breite, float laenge)
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

            Hinzufuegen(this);
        }

        private void Hinzufuegen(Produkt tmp)
        {
            _list.Add(tmp);
            ProduktHinzugefuegt?.Invoke(this, EventArgs.Empty);
        }

        public static bool Entfernen(ref Produkt tmp)
        {
            if (_list.Remove(tmp))
            {
                ProduktEntfernt?.Invoke(tmp, EventArgs.Empty);
                tmp = null;
                return true;
            }
            return false;
        }
    }
}
