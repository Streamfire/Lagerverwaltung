using Lagerverwaltung.Core.Abstract;

namespace Lagerverwaltung.Core
{
    public sealed class Suchkriterien : Base
    {
        public string LagerName { get; set; }

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
        public string ProduktErstelltAm { get; set; }
        public string ProduktGeaendertAm { get; set; }


        public string PaketName { get; set; }
        public ushort PaketMenge { get; set; }
        public string PaketHaltbarkeit { get; set; }
        public string PaketAnschaffungsgrund { get; set; }


        public string RegalName { get; set; }
        public string RegalfachName { get; set; }


        public uint Zeile { get; set; }


        public float Hoehe2 { get; set; }
        public float Breite2 { get; set; }
        public float Laenge2 { get; set; }
        public float ProduktPreis2 { get; set; }
        public float ProduktGewicht2 { get; set; }
        public string ProduktErstelltAm2 { get; set; }
        public string ProduktGeaendertAm2 { get; set; }
        public ushort PaketMenge2 { get; set; }
        public string PaketHaltbarkeit2 { get; set; }

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
            //ProduktErstelltAm = DateTime.ParseExact("01.01.1970", "dd.MM.yyyy", CultureInfo.InvariantCulture);
            //ProduktGeaendertAm = DateTime.ParseExact("01.01.1970", "dd.MM.yyyy", CultureInfo.InvariantCulture);
            ProduktErstelltAm = "01.01.1970";
            ProduktGeaendertAm = "01.01.1970";

            PaketName = "";
            PaketMenge = 0;
            //PaketHaltbarkeit = DateTime.ParseExact("01.01.1970", "dd.MM.yyyy", CultureInfo.InvariantCulture);
            PaketHaltbarkeit = "01.01.1970";
            PaketAnschaffungsgrund = "";

            RegalName = "";
            RegalfachName = "";

            LagerName = "";

            Zeile = 0;

            Hoehe2 = 0.0f;
            Breite2 = 0.0f;
            Laenge2 = 0.0f;
            ProduktPreis2 = 0.0f;
            ProduktGewicht2 = 0.0f;
            //ProduktErstelltAm2 = DateTime.ParseExact("01.01.1970", "dd.MM.yyyy", CultureInfo.InvariantCulture);
            //ProduktGeaendertAm2 = DateTime.ParseExact("01.01.1970", "dd.MM.yyyy", CultureInfo.InvariantCulture);
            ProduktErstelltAm2 = "01.01.1970";
            ProduktGeaendertAm2 = "01.01.1970";
            PaketMenge2 = 0;
            //PaketHaltbarkeit2 = DateTime.ParseExact("01.01.1970", "dd.MM.yyyy", CultureInfo.InvariantCulture);
            PaketHaltbarkeit2 = "01.01.1970";
        }
    }
}
