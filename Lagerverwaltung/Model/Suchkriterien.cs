using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using Lagerverwaltung.Core.Abstract;
using System.Globalization;

namespace Lagerverwaltung.Model
{
    public sealed class Suchkriterien : Base
    {
        public string ProduktName { get; set; }
        public uint ProduktID { get; set; }
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


        public uint Zeile { get; set; }


        public float Hoehe2 { get; set; }
        public float Breite2 { get; set; }
        public float Laenge2 { get; set; }
        public float ProduktPreis2 { get; set; }
        public float ProduktGewicht2 { get; set; }
        public DateTime ProduktErstelltAm2 { get; set; }
        public DateTime ProduktGeaendertAm2 { get; set; }
        public ushort PaketMenge2 { get; set; }
        public DateTime PaketHaltbarkeit2 { get; set; }

        public Suchkriterien()
        {
            ProduktName = "";
            ProduktID = 0;
            ProduktGewicht = 0.0f;
            ProduktPreis = 0.0f;
            ProduktZeichnungsnummer = "";
            Hoehe = 0.0f;
            Breite = 0.0f;
            Laenge = 0.0f;
            ProduktErstelltAm = DateTime.ParseExact("1970-01-01", "yyyy-MM-dd", CultureInfo.InvariantCulture);
            ProduktGeaendertAm = DateTime.ParseExact("1970-01-01", "yyyy-MM-dd", CultureInfo.InvariantCulture);

            PaketName = "";
            PaketMenge = 0;
            PaketHaltbarkeit = DateTime.ParseExact("1970-01-01", "yyyy-MM-dd", CultureInfo.InvariantCulture);
            PaketAnschaffungsgrund = "";

            RegalName = "";
            RegalfachName = "";

            Zeile = 0;

            Hoehe2 = 0.0f;
            Breite2 = 0.0f;
            Laenge2 = 0.0f;
            ProduktPreis2 = 0.0f;
            ProduktGewicht2 = 0.0f;
            ProduktErstelltAm2 = DateTime.ParseExact("1970-01-01", "yyyy-MM-dd", CultureInfo.InvariantCulture);
            ProduktGeaendertAm2 = DateTime.ParseExact("1970-01-01", "yyyy-MM-dd", CultureInfo.InvariantCulture);
            PaketMenge2 = 0;
            PaketHaltbarkeit2 = DateTime.ParseExact("1970-01-01", "yyyy-MM-dd", CultureInfo.InvariantCulture);
        }
    }
}
